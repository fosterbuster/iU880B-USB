// <copyright file="ActivationByPersonalisationRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using FosterBuster.Extensions;

namespace FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Activation
{
    /// <summary>
    /// This requesr can be used to activate the device. The passed parameters will be stored in a non-volatile memory.
    /// </summary>
    public sealed class ActivationByPersonalisationRequest : LoRaWanTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivationByPersonalisationRequest"/> class.
        /// </summary>
        /// <param name="deviceAddress">A unique 32-Bit device-address, used for radio communication within a network formatted as a Hex-string.</param>
        /// <param name="networkSessionKey">A device-specific 128-Bit network session key used for MIC calculation and verification formatted as a Hex-string.</param>
        /// <param name="applicationSessionKey">A device-specific 128-Bit application session key used to encrypt and decrypt the payload field of application specific messages formatted as a Hex-string.</param>
        public ActivationByPersonalisationRequest(string deviceAddress, string networkSessionKey, string applicationSessionKey)
            : base(LoRaWanMessageIdentifier.ActivateDeviceRequest, new List<byte>())
        {
            Payload!.AddRange(deviceAddress.HexStringToBytes());
            Payload!.AddRange(networkSessionKey.HexStringToBytes());
            Payload!.AddRange(applicationSessionKey.HexStringToBytes());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivationByPersonalisationRequest"/> class.
        /// </summary>
        /// <param name="deviceAddress">A unique 32-Bit device-address, used for radio communication within a network.</param>
        /// <param name="networkSessionKey">A device-specific 128-Bit network session key used for MIC calculation and verification.</param>
        /// <param name="applicationSessionKey">A device-specific 128-Bit application session key used to encrypt and decrypt the payload field of application specific messages.</param>
        public ActivationByPersonalisationRequest(IList<byte> deviceAddress, IList<byte> networkSessionKey, IList<byte> applicationSessionKey)
           : base(LoRaWanMessageIdentifier.ActivateDeviceRequest, new List<byte>())
        {
            Payload!.AddRange(deviceAddress);
            Payload!.AddRange(networkSessionKey);
            Payload!.AddRange(applicationSessionKey);
        }
    }
}