// <copyright file="SendUnreliableDataMessageResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace WiMOD.Messaging.Rx.LoRaWAN
{
    /// <summary>
    /// A LoRaWAN Data Transmission not requiring acknowledgement response.
    /// </summary>
    public class SendUnreliableDataMessageResponse : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendUnreliableDataMessageResponse"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public SendUnreliableDataMessageResponse(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.SendUDataResponse, payload)
        {
        }

        /// <summary>
        /// Gets the status relayed in this message.
        /// </summary>
        public ResponseStatus Status => new ResponseStatus(Payload[2]);

        /// <summary>
        /// Gets the time [ms] remaining till channel available (sent if channel blocked by Duty Cycle).
        /// </summary>
        public int? TimeUntilChannelAvailableMillis => BlockedByDutyCycle ? (int?)BitConverter.ToInt32(Payload.Skip(3).ToArray()) : null;

        /// <summary>
        /// Gets a value indicating whether or not the channel was blocked by duty cycle.
        /// </summary>
        public bool BlockedByDutyCycle => Status.Status == ResponseStatusIdentifier.ChannelBlockedByDutyCycle;

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Send Unreliable Data Message Response Response. Status: " + Status.ToString() + (BlockedByDutyCycle ? $"Time remaining till channel available: {TimeUntilChannelAvailableMillis} ms." : ".");
        }
    }
}