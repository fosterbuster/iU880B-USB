// <copyright file="NetworkStatusResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using FosterBuster.Extensions;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Configuration
{
    /// <summary>
    /// Response to a <see cref="Tx.LoRaWAN.Configuration.NetworkStatusRequest"/>.
    /// </summary>
    public sealed class NetworkStatusResponse : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkStatusResponse"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public NetworkStatusResponse(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.NetworkStatusResponse, payload)
        {
        }

        /// <summary>
        /// Gets the status of the response.
        /// </summary>
        public ResponseStatus Status => new ResponseStatus(Payload[2]);

        /// <summary>
        /// Gets the status of the network.
        /// </summary>
        public NetworkStatusIndicator NetworkStatus => (NetworkStatusIndicator)Payload[3];

        /// <summary>
        /// Gets a value indicating whether the device is active on the network or not.
        /// </summary>
        public bool DeviceActive => NetworkStatus == NetworkStatusIndicator.DeviceActiveByActivationByPersonalisation || NetworkStatus == NetworkStatusIndicator.DeviceActiveByOverTheAirActivation;

        /// <summary>
        /// Gets a value indicating whether the device is currently joining the network.
        /// </summary>
        public bool DeviceJoining => NetworkStatus == NetworkStatusIndicator.DeviceJoiningByOverTheAirActivation;

        /// <summary>
        /// Gets the device address.
        /// </summary>
        public byte[]? DeviceAddress => ExtendedFormat ? GetDeviceAddress() : null;

        /// <summary>
        /// Gets the current Data rate (spreading factor) of the device.
        /// </summary>
        public DataRateIndex? DataRate => ExtendedFormat ? (DataRateIndex?)Payload[8] : null;

        /// <summary>
        /// Gets the current Power Level (EIRP) of the device in dBm.
        /// </summary>
        public int? PowerLevel => ExtendedFormat ? (int?)Payload[9] : null;

        /// <summary>
        /// Gets current maximum payload size of the device.
        /// </summary>
        public int? MaximumPayloadSize => ExtendedFormat ? (int?)Payload[10] : null;

        private bool ExtendedFormat => Payload.Count > 4;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Network Status Response. Status: {Status.ToString()}, Network Status: {NetworkStatus.ToFormattedString()}" + (ExtendedFormat ? $"Device Address {DeviceAddress!.ToHexString()}, Data rate: {DataRate!.Value.ToFormattedString()}, Power Level (EIRP): {PowerLevel!.Value} dBm, Maximum payload size {MaximumPayloadSize!.Value}." : string.Empty);
        }

        private byte[] GetDeviceAddress()
        {
            return Payload.Skip(3).Take(4).ToArray();
        }
    }
}