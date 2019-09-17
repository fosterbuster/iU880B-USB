// <copyright file="ReliableDataIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN
{
    /// <summary>
    /// This HCI message is sent to the host after reception of a reliable radio packet containing application payload. The device will acknowledge the reception with a set Ack-Bit in the next reliable/unreliable uplink radio packet to the network server.
    /// </summary>
    public sealed class ReliableDataIndication : DataIndication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReliableDataIndication"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public ReliableDataIndication(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.ReceiveCDataIndication, payload)
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Reliable Data Indication. " + base.ToString();
        }
    }
}