// <copyright file="ResetRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.Messaging.Tx.Device
{
    /// <summary>
    /// This message can be used to reset the radio module. The reset will be performed after approx. 200ms.
    /// </summary>
    public sealed class ResetRequest : DeviceTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetRequest"/> class.
        /// </summary>
        public ResetRequest()
            : base(DeviceManagementMessageIdentifier.ResetReqest, null)
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Reset Request";
        }
    }
}