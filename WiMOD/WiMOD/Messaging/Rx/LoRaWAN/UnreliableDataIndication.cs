// <copyright file="UnreliableDataIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace WiMOD.Messaging.Rx.LoRaWAN
{
    /// <summary>
    /// This HCI message is sent to the host after reception of an unreliable radio packet containing application payload.
    /// </summary>
    public class UnreliableDataIndication : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreliableDataIndication"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public UnreliableDataIndication(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.ReceiveUDataIndication, payload)
        {
        }

        // TODO finish class.

        /// <summary>
        /// Gets a value indicating whether or not the message is an acknowledgement sent from the server.
        /// </summary>
        public bool IsAcknowledgement => Payload.Count < 3; // ACK is indicated via Unreliable or Reliable Data Indication with empty LoRaWAN Port and empty Application Payload Field.
    }
}