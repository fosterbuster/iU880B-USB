// <copyright file="TxHciMessage.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Tx
{
    /// <summary>
    /// HCI Message for transmission to IU880B Modem.
    /// </summary>
    public abstract class TxHciMessage : HciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TxHciMessage"/> class.
        /// </summary>
        /// <param name="identifier">Identifier for destination endpoint.</param>
        /// <param name="payload">payload to be sent.</param>
        protected TxHciMessage(EndpointIdentifier identifier, List<byte> payload)
        {
            EndpointIdentifier = identifier;
            Payload = payload;
        }

        /// <summary>
        /// Gets the identifier of the endpoint this message should be sent to.
        /// </summary>
        public EndpointIdentifier EndpointIdentifier { get; private set; }

        /// <summary>
        /// Gets the payload of this message.
        /// </summary>
        public List<byte> Payload { get; private set; }

        /// <summary>
        /// Gets the message identifier.
        /// </summary>
        public abstract byte MessageIdentifier { get; }
    }
}