// <copyright file="SetJoinParametersRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using WiMOD.Helpers.Extensions;

namespace WiMOD.Messaging.Tx.LoRa.Activation
{
    /// <summary>
    /// This request can be used to configure the over-the-air activation parameters which are used during the join procedure.
    /// </summary>
    public class SetJoinParametersRequest : LoRaWanTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetJoinParametersRequest"/> class.
        /// </summary>
        /// <param name="applicationEui">A globally unique 64-Bit application ID as a Hex-formatted string.</param>
        /// <param name="applicationKey">A device-specific 128-Bit AES application key as a Hex-formatted string.</param>
        public SetJoinParametersRequest(string applicationEui, string applicationKey)
            : base(LoRaWanMessageIdentifier.SetJoinParameterRequest, new List<byte>())
        {
            Payload.AddRange(applicationEui.HexStringToBytes());
            Payload.AddRange(applicationKey.HexStringToBytes());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetJoinParametersRequest"/> class.
        /// </summary>
        /// <param name="applicationEui">A globally unique 64-Bit application ID.</param>
        /// <param name="applicationKey">A device-specific 128-Bit AES application key.</param>
        public SetJoinParametersRequest(IList<byte> applicationEui, IList<byte> applicationKey)
            : base(LoRaWanMessageIdentifier.SetJoinParameterRequest, new List<byte>())
        {
            Payload.AddRange(applicationEui);
            Payload.AddRange(applicationKey);
        }
    }
}