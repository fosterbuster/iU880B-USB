// <copyright file="OverTheAirActivationRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Activation
{
    /// <summary>
    /// This request can be used to start the join network procedure. The module sends a join network radio packet and waits for a response from server side.
    /// </summary>
    public sealed class OverTheAirActivationRequest : LoRaWanTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverTheAirActivationRequest"/> class.
        /// </summary>
        public OverTheAirActivationRequest()
            : base(LoRaWanMessageIdentifier.JoinNetworkRequest, null)
        {
        }
    }
}