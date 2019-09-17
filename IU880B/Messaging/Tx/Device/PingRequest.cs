// <copyright file="PingRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.Messaging.Tx.Device
{
    /// <summary>
    /// This command is used to check if the serial connection is ok and if the connected radiomodule is alive. The host should expect a Ping Response within a very short time interval.
    /// </summary>
    public sealed class PingRequest : DeviceTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PingRequest"/> class.
        /// </summary>
        public PingRequest()
            : base(DeviceManagementMessageIdentifier.PingRequest, null)
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Ping Request";
        }
    }
}