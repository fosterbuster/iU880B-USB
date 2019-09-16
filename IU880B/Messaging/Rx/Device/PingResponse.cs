// <copyright file="PingResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx.Device
{
    /// <summary>
    /// Response to a Ping Request.
    /// </summary>
    public class PingResponse : DeviceRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PingResponse"/> class.
        /// </summary>
        /// <param name="payload">The payload.</param>
        public PingResponse(IList<byte> payload)
            : base(DeviceManagementMessageIdentifier.PingResponse, payload)
        {
        }

        /// <summary>
        /// Gets the status relayed in this message.
        /// </summary>
        public ResponseStatus Status => new ResponseStatus(Payload[2]);

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Ping Response. Status: " + Status.ToString();
        }
    }
}