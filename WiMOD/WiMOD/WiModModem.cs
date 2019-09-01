// <copyright file="WiModModem.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WiMOD.DependencyInjection;
using WiMOD.Helpers;
using WiMOD.Helpers.Extensions;
using WiMOD.Messaging.Rx;
using WiMOD.Messaging.Tx;

namespace WiMOD
{
    /// <summary>
    /// Represents a physical iMST WiMOD iU880B LoRa Modem.
    /// </summary>
    public class WiModModem
    {
        private static readonly byte[] SerialWakeUpMessage =
            {
            0xC0, 0xC0, 0xC0, 0xC0, 0xC0,
            0xC0, 0xC0, 0xC0, 0xC0, 0xC0,
            0xC0, 0xC0, 0xC0, 0xC0, 0xC0,
            0xC0, 0xC0, 0xC0, 0xC0, 0xC0,
            0xC0, 0xC0, 0xC0, 0xC0, 0xC0,
            0xC0, 0xC0, 0xC0, 0xC0, 0xC0,
            0xC0, 0xC0, 0xC0, 0xC0, 0xC0,
            0xC0, 0xC0, 0xC0, 0xC0, 0xC0,
            };

        private readonly SerialPort _serialConnection;
        private readonly ILogger<WiModModem> _logger;
        private Func<RxHciMessage, Task> _onData;

        /// <summary>
        /// Initializes a new instance of the <see cref="WiModModem"/> class.
        /// </summary>
        /// <param name="options">options object.</param>
        /// <param name="loggerFactory">loggerfactory.</param>
        /// <param name="portfinder">port finder.</param>
        public WiModModem(IOptions<WiModOptions> options, ILoggerFactory loggerFactory, PortFinder portfinder)
        {
            _logger = loggerFactory.CreateLogger<WiModModem>();

            WiModOptions opts = options.Value;
            var portName = string.Empty;

            if (opts.UsePortFinder)
            {
                portName = portfinder.ConnectedPortName;
            }
            else
            {
                portName = opts.Name;
            }

            _serialConnection = new SerialPort(portName, opts.BaudRate);
            _serialConnection.DataReceived += SerialConnection_DataReceived;

            _logger.LogDebug("Opening serial connection and sending wakeup bytes");
            _serialConnection.Open();
            _serialConnection.Write(SerialWakeUpMessage, 0, SerialWakeUpMessage.Length);
        }

        /// <summary>
        /// Set the action to be triggered, when new data is available.
        /// </summary>
        /// <param name="onData">the action to be triggered.</param>
        public void SetReceiver(Func<RxHciMessage, Task> onData)
        {
            _onData = onData ?? throw new ArgumentNullException(nameof(onData));
        }

        /// <summary>
        /// Transmits the passed <paramref name="message"/> to the physical modem.
        /// </summary>
        /// <param name="message">the message to be sent.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task TransmitMessage(TxHciMessage message)
        {
            // Retreieve the payload from the message.
            List<byte> bytes = message.Payload ?? new List<byte>();

            // Add recipient bytes to the start of the payload.
            bytes.Insert(0, (byte)message.EndpointIdentifier);
            bytes.Insert(1, message.MessageIdentifier);

            // Encode the frame as SLIP.
            bytes = bytes.EncodeSlipFrame(appendCrc: true).ToList();
            _logger.LogDebug("Transmitting {bytes}", bytes.ToHexString());
            await _serialConnection.BaseStream.WriteAsync(bytes.ToArray(), 0, bytes.Count);
        }

        // TODO: Make it async.
        private void SerialConnection_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // TODO: Implement some kind of streamreader, for chunking in C0, discarding any and all bytes which are not part of a C0....C0 packet.
            // When sending Reset, the device sends some weird ass 0xFF - So make sure to deal with invalid bytes!!!
            var data = new byte[_serialConnection.BytesToRead]; // Get rid of this buggy property. Does not gurantee to tell you how many bytes we want.
            _serialConnection.Read(data, 0, data.Length);
            _logger.LogTrace("Received {bytes}", data.ToHexString());

            IList<byte> decoded;
            try
            {
                _logger.LogDebug("Attempting to unslip {bytes}", data.ToHexString());
                decoded = data.StripSlipFrame();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed unslipping bytes {bytes}. Reason: {reason}", data.ToHexString(), ex.Message);
                return;
            }

            RxHciMessage message;
            try
            {
                _logger.LogDebug("Attempting to marshal {bytes} into an RX message.", decoded.ToHexString());
                message = RxHciMessageFactory.Create(decoded);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed marshalling bytes {bytes} into a RX message. Reason: {reason}", decoded.ToHexString(), ex.Message);
                return;
            }

            _logger.LogDebug("Marshalling successful, received: {message}", message.ToString());

            _onData(message).Wait();
        }
    }
}