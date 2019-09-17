// <copyright file="ConfigureRadioStackResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Configuration
{
    /// <summary>
    /// Response to a <see cref="Tx.LoRaWAN.Configuration.ConfigureRadioStackRequest"/>.
    /// </summary>
    public sealed class ConfigureRadioStackResponse : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureRadioStackResponse"/> class.
        /// </summary>
        /// <param name="payload">The payload.</param>
        public ConfigureRadioStackResponse(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.SetRadioStackResponse, payload)
        {
        }

        /// <summary>
        /// Gets the status relayed in this message.
        /// </summary>
        public ResponseStatus Status => new ResponseStatus(Payload[2]);

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Configure Radio Stack Response. Status: " + Status.ToString();
        }
    }
}