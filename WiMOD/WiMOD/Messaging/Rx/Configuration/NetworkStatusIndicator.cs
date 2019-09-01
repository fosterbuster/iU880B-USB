// <copyright file="NetworkStatusIndicator.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace WiMOD.Messaging.Rx.Configuration
{
    /// <summary>
    /// Indicates the current network status.
    /// </summary>
    public enum NetworkStatusIndicator
    {
        /// <summary>
        /// Device inactive
        /// </summary>
        DeviceInactive = 0x00,

        /// <summary>
        /// Active (ABP)
        /// </summary>
        DeviceActiveByActivationByPersonalisation = 0x01,

        /// <summary>
        /// Active (OTAA)
        /// </summary>
        DeviceActiveByOverTheAirActivation = 0x02,

        /// <summary>
        /// Joining (OTAA)
        /// </summary>
        DeviceJoiningByOverTheAirActivation = 0x03,
    }
}