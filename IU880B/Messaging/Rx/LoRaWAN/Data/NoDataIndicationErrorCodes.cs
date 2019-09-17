// <copyright file="NoDataIndicationErrorCodes.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Data
{
    /// <summary>
    /// Errorcodes possibly present in a No Data Indication.
    /// </summary>
    [Flags]
    public enum NoDataIndicationErrorCodes
    {
        /// <summary>
        /// No error
        /// </summary>
        None = 0,

        /// <summary>
        /// Wrong MType received
        /// </summary>
        WrongMtypeReceived = 1,

        /// <summary>
        /// Wrong Device Address received
        /// </summary>
        WrongDeviceAddressReceived = 2,

        /// <summary>
        /// Wrong MIC received
        /// </summary>
        WrongMicReceived = 3,

        /// <summary>
        /// Unexpected FCnt received
        /// </summary>
        UnexpectedFcountReceived = 4,

        /// <summary>
        /// Wrong MAC commands received (e.g. MAC commands simultaneously present in the payload field and the frame options field)
        /// </summary>
        WrongMacCommandsReceived = 5,

        /// <summary>
        /// Wrong downlink received
        /// </summary>
        WrongDownLinkReceived = 6,

        /// <summary>
        /// Expected ACK missing
        /// </summary>
        ExpectedAckMissing = 7,
    }
}