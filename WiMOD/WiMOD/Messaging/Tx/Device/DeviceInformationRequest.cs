// <copyright file="DeviceInformationRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace WiMOD.Messaging.Tx.Device
{
    /// <summary>
    /// This message can be used to identify the local connected device. As a result the device sends a response message which contains a Device Information Field.
    /// </summary>
    public class DeviceInformationRequest : DeviceTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInformationRequest"/> class.
        /// </summary>
        public DeviceInformationRequest()
            : base(DeviceManagementMessageIdentifier.DeviceInfoRequest, null)
        {
        }
    }
}