﻿// <copyright file="ActivationByPersonalisationResponse.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Activation
{
    /// <summary>
    /// Response to a <see cref="Tx.LoRaWAN.Activation.ActivationByPersonalisationRequest"/>.
    /// </summary>
    public sealed class ActivationByPersonalisationResponse : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivationByPersonalisationResponse"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public ActivationByPersonalisationResponse(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.ActivateDeviceResponse, payload)
        {
        }

        /// <summary>
        /// Gets the status of the response.
        /// </summary>
        public ResponseStatus Status => new ResponseStatus(Payload[2]);

        /// <inheritdoc/>
        public override string ToString()
        {
            return "ABP Response. Status: " + Status.ToString();
        }
    }
}