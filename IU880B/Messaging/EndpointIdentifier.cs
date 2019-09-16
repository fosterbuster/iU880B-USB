// <copyright file="EndpointIdentifier.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.Messaging
{
    /// <summary>
    /// Endpoint identifier values.
    /// </summary>
    public enum EndpointIdentifier : byte
    {
        /// <summary>
        /// Device manager Identifier
        /// </summary>
        DeviceManager = 0x01,

        /// <summary>
        /// LoRaWAN Modem
        /// </summary>
        LoRaWANModem = 0x10,
    }
}