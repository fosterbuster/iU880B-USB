// <copyright file="SendUnreliableDataMessageResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN
{
    /// <summary>
    /// A LoRaWAN Data Transmission not requiring acknowledgement response.
    /// </summary>
    public sealed class SendUnreliableDataMessageResponse : DataMessageResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendUnreliableDataMessageResponse"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public SendUnreliableDataMessageResponse(IList<byte> payload)
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