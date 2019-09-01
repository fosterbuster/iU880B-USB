// <copyright file="LoRaWanRxHciMessage.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using WiMOD.Messaging.Tx.LoRa;

namespace WiMOD.Messaging.Rx
{
    /// <summary>
    /// A message received from the LoRaWAN SAP.
    /// </summary>
    public abstract class LoRaWanRxHciMessage : RxHciMessage
    {
        private readonly LoRaWanMessageIdentifier _identifier;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoRaWanRxHciMessage"/> class.
        /// </summary>
        /// <param name="identifier">The identifier of this message.</param>
        /// <param name="payload">the payload.</param>
        protected LoRaWanRxHciMessage(LoRaWanMessageIdentifier identifier, IList<byte> payload)
            : base(EndpointIdentifier.LoRaWANModem, payload)
        {
            _identifier = identifier;
        }

        /// <inheritdoc/>
        public override byte MessageIdentifier => (byte)_identifier;
    }
}