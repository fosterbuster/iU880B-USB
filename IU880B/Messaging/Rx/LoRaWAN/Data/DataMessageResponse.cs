// <copyright file="DataMessageResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Data
{
    /// <summary>
    /// Superclass for Data Message Responses.
    /// </summary>
    public abstract class DataMessageResponse : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataMessageResponse"/> class.
        /// </summary>
        /// <param name="identifier">the identifier.</param>
        /// <param name="payload">the payload.</param>
        protected DataMessageResponse(LoRaWanMessageIdentifier identifier, IList<byte> payload)
            : base(identifier, payload)
        {
        }

        /// <summary>
        /// Gets the status relayed in this message.
        /// </summary>
        public ResponseStatus Status => new ResponseStatus(Payload[2]);

        /// <summary>
        /// Gets the time [ms] remaining till channel available (sent if channel blocked by Duty Cycle).
        /// </summary>
        public int? TimeUntilChannelAvailableMillis => BlockedByDutyCycle ? (int?)BitConverter.ToInt32(Payload.Skip(3).ToArray(), 0) : null;

        /// <summary>
        /// Gets a value indicating whether or not the channel was blocked by duty cycle.
        /// </summary>
        public bool BlockedByDutyCycle => Status.Status == ResponseStatusIdentifier.ChannelBlockedByDutyCycle;

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Status: " + Status.ToString() + (BlockedByDutyCycle ? $" Time remaining till channel available: {TimeUntilChannelAvailableMillis} ms." : string.Empty);
        }
    }
}