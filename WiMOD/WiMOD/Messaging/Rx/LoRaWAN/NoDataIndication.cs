// <copyright file="NoDataIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace WiMOD.Messaging.Rx.LoRaWAN
{
    /// <summary>
    /// This HCI message is sent to the host in case no expected confirmation or data has been received as a result of prior reliable uplink radio packet.
    /// </summary>
    public class NoDataIndication : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoDataIndication"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public NoDataIndication(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.ReceiveNoDataIndication, payload)
        {
            // TODO: Finish class..
        }
    }
}