// <copyright file="OverTheAirActivationResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using WiMOD.Messaging.Tx.LoRa;

namespace WiMOD.Messaging.Rx.Activation
{
    /// <summary>
    /// Response for OTAA Request.
    /// </summary>
    public class OverTheAirActivationResponse : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverTheAirActivationResponse"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public OverTheAirActivationResponse(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.JoinNetworkResponse, payload)
        {
        }

        /// <summary>
        /// Gets the status of the response.
        /// </summary>
        public ResponseStatus Status => new ResponseStatus(Payload[2]);

        /// <inheritdoc/>
        public override string ToString()
        {
            return "OTAA Response. Status: " + Status.ToString();
        }
    }
}