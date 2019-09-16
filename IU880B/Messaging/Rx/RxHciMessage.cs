// <copyright file="RxHciMessage.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx
{
    /// <summary>
    /// HCI Message received from IU880B Modem.
    /// </summary>
    public abstract class RxHciMessage : HciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RxHciMessage"/> class.
        /// </summary>
        /// <param name="endpointIdentifier">the identifier of the endpoint.</param>
        /// <param name="payload">the payload.</param>
        protected RxHciMessage(EndpointIdentifier endpointIdentifier, IList<byte> payload)
        {
            EndpointIdentifier = endpointIdentifier;
            Payload = payload ?? throw new ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Gets the identifier of the endpoint this message was sent to.
        /// </summary>
        public EndpointIdentifier EndpointIdentifier { get; private set; }

        /// <summary>
        /// Gets the message identifier.
        /// </summary>
        public abstract byte MessageIdentifier { get; }

        /// <summary>
        /// Gets or sets the payload of the response.
        /// </summary>
        protected IList<byte> Payload { get; set; }
    }
}