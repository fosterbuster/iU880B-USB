// <copyright file="UnreliableDataMessageRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Data
{
    /// <summary>
    /// A LoRaWAN Data Transmission not requiring acknowledgement.
    /// </summary>
    public sealed class UnreliableDataMessageRequest : LoRaWanTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreliableDataMessageRequest"/> class.
        /// </summary>
        /// <param name="port">The port to use.</param>
        /// <param name="payload">The payload.</param>
        public UnreliableDataMessageRequest(byte port, List<byte> payload)
            : base(LoRaWanMessageIdentifier.SendUDataRequest, payload)
        {
            if (port < 1 && port > 224)
            {
                throw new ArgumentException("Port value is invalid. Please consult the LoRaWAN Specification (4.3.2).");
            }

            payload.Insert(0, port);
        }
    }
}