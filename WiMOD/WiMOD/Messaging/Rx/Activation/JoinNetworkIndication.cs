// <copyright file="JoinNetworkIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using WiMOD.Helpers.Extensions;
using WiMOD.Messaging.Tx.LoRa.Configuration;

namespace WiMOD.Messaging.Rx.Activation
{
    /// <summary>
    /// This message is sent to the host either after successful reception of a server join response packet or after the expiration of a complete join process without success (the join request will be retransmitted changing the spreading factor from SF7 till SF12, reusing each spreading factor twice).
    /// </summary>
    public class JoinNetworkIndication : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinNetworkIndication"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public JoinNetworkIndication(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.JoinNetworkIndication, payload)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the device was activated (true), or if an error occured (false).
        /// </summary>
        public bool DeviceActivated => Payload[2] == 0x00 || Payload[2] == 0x01;

        /// <summary>
        /// Gets the device address.
        /// </summary>
        public byte[] DeviceAddress => ExtendedFormat ? GetNewDeviceAddress() : null;

        /// <summary>
        /// Gets the channel index the transmission was sent on.
        /// </summary>
        public int? ChannelIndex => ExtendedFormat ? (int?)Payload[7] : null;

        /// <summary>
        /// Gets the Data rate (spreading factor) the transmission was sent on.
        /// </summary>
        public DataRateIndex? DataRate => ExtendedFormat ? (DataRateIndex?)Payload[8] : null;

        /// <summary>
        /// Gets the RSSI value in dBm.
        /// </summary>
        public int? RelativeSignalStrenghtIndicator => ExtendedFormat ? (int?)Payload[9] : null;

        /// <summary>
        /// Gets the SNR value in dB.
        /// </summary>
        public int? SignalToNoiseRatio => ExtendedFormat ? (int?)Payload[10] : null;

        /// <summary>
        /// Gets the Rx Slot value.
        /// </summary>
        public int? RxSlot => ExtendedFormat ? (int?)Payload[11] : null;

        private bool ExtendedFormat => Payload[2] == 0x01;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Join Network Indication. Device Activbated: {DeviceActivated}" + (ExtendedFormat ? $"Channel Index: {ChannelIndex.Value}, DataRate: {DataRate.Value.ToFormattedString()}, New Device Address: {DeviceAddress.ToHexString()}, RSSI: {RelativeSignalStrenghtIndicator.Value} dBm, SnR: {SignalToNoiseRatio.Value} dB, Rx Slot: {RxSlot.Value}" : ".");
        }

        private byte[] GetNewDeviceAddress()
        {
            return Payload.Skip(3).Take(4).ToArray();
        }
    }
}