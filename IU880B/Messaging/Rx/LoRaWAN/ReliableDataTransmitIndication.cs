// <copyright file="ReliableDataTransmitIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using FosterBuster.Extensions;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN
{
    /// <summary>
    /// This HCI message is sent to the host after the radio packet has been sent.
    /// </summary>
    public class ReliableDataTransmitIndication : DataTransmitIndication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReliableDataTransmitIndication"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public ReliableDataTransmitIndication(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.SendCDataTxIndication, payload)
        {
        }

        /// <summary>
        /// Gets a value indicating whether or not maximum number of retransmissions reached (error).
        /// </summary>
        public bool MaximumNumberOfRetransmissionsReached => Payload[2] == 0x02;

        /// <summary>
        /// Gets a value indicating whether or not maximum payload size exceeded for current data rate (error).
        /// </summary>
        public bool MaximumPayloadSizeExceededForCurrentDataRate => Payload[2] == 0x04;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Reliable Data Transmission Indication. Packet sent: {RadioPacketSent}, Maximum number of retransmissions reached: {MaximumNumberOfRetransmissionsReached}, Maximum payload size exceeded for current data rate: {MaximumPayloadSizeExceededForCurrentDataRate}" + (ExtendedFormat ? $" Channel Index: {ChannelIndex.Value}, DataRate: {DataRate.Value.ToFormattedString()}, Transmitted radio packets: {TransmittedRadioPackets.Value}, Transmit Power Level: {TransmitPowerLevel} dBm, Air time: {MessageAirTimeMillis} ms." : string.Empty);
        }
    }
}