// <copyright file="LoRaWanTxMessage.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Tx.LoRaWAN
{
    /// <summary>
    /// Message to be sent to the LoRaWAN SAP.
    /// </summary>
    public abstract class LoRaWanTxMessage : TxHciMessage
    {
        private readonly LoRaWanMessageIdentifier _messageIdentifier;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoRaWanTxMessage"/> class.
        /// </summary>
        /// <param name="messageIdentifier">the message identifier.</param>
        /// <param name="payload">the payload.</param>
        protected LoRaWanTxMessage(LoRaWanMessageIdentifier messageIdentifier, List<byte> payload)
            : base(EndpointIdentifier.LoRaWANModem, payload)
        {
            _messageIdentifier = messageIdentifier;
        }

        /// <inheritdoc/>
        public sealed override byte MessageIdentifier => (byte)_messageIdentifier;
    }
}