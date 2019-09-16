// <copyright file="NetworkStatusRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.Messaging.Tx.LoRa.Configuration
{
    /// <summary>
    /// This request allows to read the current network / activation status.
    /// </summary>
    public class NetworkStatusRequest : LoRaWanTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkStatusRequest"/> class.
        /// </summary>
        public NetworkStatusRequest()
            : base(LoRaWanMessageIdentifier.NetworkStatusRequest, null)
        {
        }
    }
}