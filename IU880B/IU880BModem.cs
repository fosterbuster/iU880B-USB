// <copyright file="IU880BModem.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using FosterBuster.Extensions;
using FosterBuster.IU880B.DependencyInjection;
using FosterBuster.IU880B.Messaging;
using FosterBuster.IU880B.Messaging.Rx;
using FosterBuster.IU880B.Messaging.Tx;
using FosterBuster.IU880B.Utilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FosterBuster.IU880B
{
    /// <summary>
    /// Represents a physical iMST IU880B iU880B LoRa Modem.
    /// </summary>
    public class IU880BModem
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
        private readonly SlipReader _slipReader;
        private readonly ILogger<IU880BModem> _logger;
        private Func<RxHciMessage, Task> _onData;

        /// <summary>
        /// Initializes a new instance of the <see cref="IU880BModem"/> class.
        /// </summary>
        /// <param name="options">options object.</param>
        /// <param name="loggerFactory">loggerfactory.</param>
        /// <param name="portfinder">port finder.</param>
        public IU880BModem(IOptions<IU880BOptions> options, ILoggerFactory loggerFactory, PortFinder portfinder)
        {
            _logger = loggerFactory.CreateLogger<IU880BModem>();

            IU880BOptions opts = options.Value;
            var portName = string.Empty;

            if (opts.UsePortFinder)
            {
                portName = portfinder.ConnectedPortName;
            }
            else
            {
                portName = opts.Name;
            }

            _slipReader = new SlipReader(OnSlipFrameReceived);

            _serialConnection = new SerialPort(portName, opts.BaudRate);
            _serialConnection.DataReceived += OnSerialDataAvailable;
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
            _onData += onData ?? throw new ArgumentNullException(nameof(onData));
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
            _logger.LogTrace("Transmitting {bytes}", bytes.ToHexString());
            await _serialConnection.BaseStream.WriteAsync(bytes.ToArray(), 0, bytes.Count).ConfigureAwait(false);
        }

        private void OnSerialDataAvailable(object sender, SerialDataReceivedEventArgs e)
        {
           _slipReader.Read(_serialConnection.BaseStream).Wait();
        }

        private async Task OnSlipFrameReceived(byte[] data)
        {
            if (data.Length == 0)
            {
                _logger.LogWarning("No data available");
                return;
            }

            IList<byte> decoded;
            try
            {
                _logger.LogTrace("Attempting to unslip {bytes}", data.ToHexString());
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
                _logger.LogTrace("Attempting to marshal {bytes} into an RX message.", decoded.ToHexString());
                message = RxHciMessageFactory.Create(decoded);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed marshalling bytes {bytes} into a RX message. Reason: {reason}", decoded.ToHexString(), ex.Message);
                return;
            }

            _logger.LogDebug("Marshalling successful, received: {message}", message.ToString());

            await _onData(message).ConfigureAwait(false);
        }
    }
}