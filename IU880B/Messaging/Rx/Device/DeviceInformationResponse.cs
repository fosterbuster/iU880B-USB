// <copyright file="DeviceInformationResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using FosterBuster.Extensions;

namespace FosterBuster.IU880B.Messaging.Rx.Device
{
    /// <summary>
    /// Response to a Device Information Request.
    /// </summary>
    public sealed class DeviceInformationResponse : DeviceRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInformationResponse"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public DeviceInformationResponse(IList<byte> payload)
            : base(DeviceManagementMessageIdentifier.DeviceInfoResponse, payload)
        {
        }

        /// <summary>
        /// Gets the Status of the response.
        /// </summary>
        public ResponseStatus Status => new ResponseStatus(Payload[2]);

        /// <summary>
        /// Gets the Module Type of the device.
        /// </summary>
        public IU880BModuleType ModuleType => Payload[3].As<IU880BModuleType>();

        /// <summary>
        /// Gets the device address of the device.
        /// </summary>
        public byte[] DeviceAddress => GetDeviceAddress();

        /// <summary>
        /// Gets the devices ID.
        /// </summary>
        public byte[] DeviceId => GetDeviceId();

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Device Information Response. Status: " + Status.ToString() + ", Module Type: " + ModuleType.ToString() + ", Device Address: " + DeviceAddress.ToHexString() + ", Device ID: " + DeviceId.ToHexString();
        }

        private byte[] GetDeviceAddress()
        {
            return Payload.Skip(4).Take(4).ToArray();
        }

        private byte[] GetDeviceId()
        {
            return Payload.Skip(8).Take(4).ToArray();
        }
    }
}