// <copyright file="UnreliableDataIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Data
{
    /// <summary>
    /// This HCI message is sent to the host after reception of an unreliable radio packet containing application payload.
    /// </summary>
    public sealed class UnreliableDataIndication : DataIndication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreliableDataIndication"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public UnreliableDataIndication(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.ReceiveUDataIndication, payload)
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Unreliable Data Indication. " + base.ToString();
        }
    }
}