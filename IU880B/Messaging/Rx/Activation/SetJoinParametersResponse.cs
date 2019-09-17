// <copyright file="SetJoinParametersResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx.Activation
{
    /// <summary>
    /// Response to a <see cref="IU880B.Messaging.Tx.LoRa.Activation.SetJoinParametersRequest"/>.
    /// </summary>
    public sealed class SetJoinParametersResponse : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetJoinParametersResponse"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public SetJoinParametersResponse(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.SetJoinParameterResponse, payload)
        {
        }

        /// <summary>
        /// Gets the status of the response.
        /// </summary>
        public ResponseStatus Status => new ResponseStatus(Payload[2]);

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Set Join Parameters Response. Status: " + Status.ToString();
        }
    }
}