// <copyright file="SendReliableDataMessageResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN
{
    /// <summary>
    /// A LoRaWAN Data Transmission not requiring acknowledgement response.
    /// </summary>
    public class SendReliableDataMessageResponse : DataMessageResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendReliableDataMessageResponse"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public SendReliableDataMessageResponse(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.SendCDataResponse, payload)
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Send Reliable Data Message Response. " + base.ToString();
        }
    }
}