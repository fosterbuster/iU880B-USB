// <copyright file="SendUnreliableDataMessageResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Data
{
    /// <summary>
    /// Response to a <see cref="Tx.LoRaWAN.Data.UnreliableDataMessageRequest"/>.
    /// </summary>
    public sealed class UnreliableDataMessageResponse : DataMessageResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreliableDataMessageResponse"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public UnreliableDataMessageResponse(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.SendUDataResponse, payload)
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Send Unreliable Data Message Response. " + base.ToString();
        }
    }
}