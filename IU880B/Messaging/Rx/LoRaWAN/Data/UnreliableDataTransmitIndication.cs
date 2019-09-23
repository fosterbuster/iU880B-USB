// <copyright file="UnreliableDataTransmitIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using FosterBuster.Extensions;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Data
{
    /// <summary>
    /// This HCI message is sent to the host after the radio packet has been sent or if the retransmission procedure finishes without success, containing in this case the corresponding error code.
    /// </summary>
    public sealed class UnreliableDataTransmitIndication : DataTransmitIndication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreliableDataTransmitIndication"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public UnreliableDataTransmitIndication(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.SendUDataTxIndication, payload)
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Unreliable Data Transmission Indication. Packet sent: {RadioPacketSent}, " + (ExtendedFormat ? $", Channel Index: {ChannelIndex!.Value}, DataRate: {DataRate!.Value.ToFormattedString()}, Transmitted radio packets: {TransmittedRadioPackets!.Value}, Transmit Power Level: {TransmitPowerLevel!} dBm, Air time: {MessageAirTimeMillis!} ms." : string.Empty);
        }
    }
}