// <copyright file="UnreliableDataTransmitIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using WiMOD.Helpers.Extensions;
using WiMOD.Messaging.Tx.LoRa.Configuration;

namespace WiMOD.Messaging.Rx.LoRaWAN
{
    /// <summary>
    /// This HCI message is sent to the host after the radio packet has been sent or if the retransmission procedure finishes without success, containing in this case the corresponding error code.
    /// </summary>
    public class UnreliableDataTransmitIndication : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreliableDataTransmitIndication"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public UnreliableDataTransmitIndication(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.SendUDataTxIndication, payload)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the radio packet was sent (true), or if an error occured (false).
        /// </summary>
        public bool RadioPacketSent => Payload[2] == 0x00 || Payload[2] == 0x01;

        /// <summary>
        /// Gets the channel index the transmission was sent on.
        /// </summary>
        public int? ChannelIndex => ExtendedFormat ? (int?)Payload[3] : null;

        /// <summary>
        /// Gets the Data rate (spreading factor) the transmission was sent on.
        /// </summary>
        public DataRateIndex? DataRate => ExtendedFormat ? (DataRateIndex?)Payload[4] : null;

        /// <summary>
        /// Gets the number of transmitted radio packets of last request.
        /// </summary>
        public int? TransmittedRadioPackets => ExtendedFormat ? (int?)Payload[5] : null;

        /// <summary>
        /// Gets the transmit power level configured in transceiver in dBm (min. value 0 dBm).
        /// </summary>
        /// <remarks>The minimum TRX power level depends on the radio module and it could slightly vary from the given power level value for the low power levels.</remarks>
        public int? TransmitPowerLevel => ExtendedFormat ? (int?)Payload[6] : null;

        /// <summary>
        /// Gets the airrtime in milliseconds of transmitted radio message.
        /// </summary>
        public int? MessageAirTimeMillis => ExtendedFormat ? (int?)BitConverter.ToInt32(Payload.Skip(6).ToArray()) : null;

        /// <summary>
        /// Gets a value indicating whether or not maximum number of retransmissions reached (error).
        /// </summary>
        public bool MaximumNumberOfRetransmissionsReached => Payload[2] == 0x02;

        /// <summary>
        /// Gets a value indicating whether or not maximum payload size exceeded for current data rate (error).
        /// </summary>
        public bool MaximumPayloadSizeExceededForCurrentDataRate => Payload[2] == 0x04;

        private bool ExtendedFormat => Payload[2] == 0x01;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Unreliable Data Transmission Indication. Packet sent: {RadioPacketSent}, Maximum number of retransmissions reached: {MaximumNumberOfRetransmissionsReached}, Maximum payload size exceeded for current data rate: {MaximumPayloadSizeExceededForCurrentDataRate} " + (ExtendedFormat ? $"Channel Index: {ChannelIndex.Value}, DataRate: {DataRate.Value.ToFormattedString()}, Transmitted radio packets: {TransmittedRadioPackets.Value}, Transmit Power Level: {TransmitPowerLevel} dBm, Air time: {MessageAirTimeMillis} ms." : ".");
        }
    }
}