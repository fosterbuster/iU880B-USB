// <copyright file="ReliableDataMessageRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Data
{
    /// <summary>
    /// A LoRaWAN Data Transmission requiring acknowledgement.
    /// </summary>
    public sealed class ReliableDataMessageRequest : LoRaWanTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReliableDataMessageRequest"/> class.
        /// </summary>
        /// <param name="port">the port to send the message on.</param>
        /// <param name="payload">the payload.</param>
        public ReliableDataMessageRequest(byte port, List<byte> payload)
            : base(LoRaWanMessageIdentifier.SendCDataRequest, payload)
        {
            if (port < 1 && port > 224)
            {
                throw new ArgumentException("Port value is invalid. Please consult the LoRaWAN Specification (4.3.2).");
            }

            payload.Insert(0, port);
        }
    }
}