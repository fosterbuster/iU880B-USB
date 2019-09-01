// <copyright file="DeviceManagementMessageIdentifier.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace WiMOD.Messaging
{
    /// <summary>
    /// Message idenfiers for device management messages.
    /// </summary>
    public enum DeviceManagementMessageIdentifier : byte
    {
        /// <summary>
        /// Ping request
        /// </summary>
        PingRequest = 0x01,

        /// <summary>
        /// Ping response
        /// </summary>
        PingResponse = 0x02,

        /// <summary>
        /// Device information request
        /// </summary>
        DeviceInfoRequest = 0x03,

        /// <summary>
        /// Device information response.
        /// </summary>
        DeviceInfoResponse = 0x04,

        /// <summary>
        /// Firmware version request.
        /// </summary>
        FirmwareVersionRequest = 0x05,

        /// <summary>
        /// Firmware version response
        /// </summary>
        FirmwareVersionResponse = 0x06,

        /// <summary>
        /// Reset Request
        /// </summary>
        ResetReqest = 0x07,

        /// <summary>
        /// Reset Response
        /// </summary>
        ResetResponse = 0x08,

        /// <summary>
        /// Operation mode request.
        /// </summary>
        SystemOperationModeRequest = 0x0B,

        /// <summary>
        /// Operation mode response.
        /// </summary>
        SystemOperationModeResponse = 0x0C,
    }
}