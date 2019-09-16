// <copyright file="LoRaWanMessageIdentifier.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.Messaging
{
    /// <summary>
    /// Message identifiers for LoRaWAN Messages.
    /// </summary>
    public enum LoRaWanMessageIdentifier : byte
    {
        /// <summary>
        /// Activate Device Request
        /// </summary>
        ActivateDeviceRequest = 0x01,

        /// <summary>
        /// Activate Device Response
        /// </summary>
        ActivateDeviceResponse = 0x02,

        /// <summary>
        /// Set Join Parameters Request
        /// </summary>
        SetJoinParameterRequest = 0x05,

        /// <summary>
        /// Set Join Parameters Response
        /// </summary>
        SetJoinParameterResponse = 0x06,

        /// <summary>
        /// Join Network Request
        /// </summary>
        JoinNetworkRequest = 0x09,

        /// <summary>
        /// Join Network Response
        /// </summary>
        JoinNetworkResponse = 0x0A,

        /// <summary>
        /// Join Network Transmission Indication
        /// </summary>
        JoinNetworkTxIndication = 0x0B,

        /// <summary>
        /// Join Network Indication
        /// </summary>
        JoinNetworkIndication = 0x0C,

        /// <summary>
        /// Send Reliable Data Request
        /// </summary>
        SendCDataRequest = 0x11,

        /// <summary>
        /// Send Reliable Data Response
        /// </summary>
        SendCDataResponse = 0x12,

        /// <summary>
        /// Send Reliable Data Transmission Indication
        /// </summary>
        SendCDataTxIndication = 0x13,

        /// <summary>
        /// Reliable Data Indication
        /// </summary>
        ReceiveCDataIndication = 0x14,

        /// <summary>
        /// Send Unreliable Data Request
        /// </summary>
        SendUDataRequest = 0x0D,

        /// <summary>
        /// Send Unreliable Data Response
        /// </summary>
        SendUDataResponse = 0x0E,

        /// <summary>
        /// Send Unreliable Data Transmission Indication
        /// </summary>
        SendUDataTxIndication = 0x0F,

        /// <summary>
        /// Receive Unreliable Data Acknowledgement Indication
        /// </summary>
        ReceiveUDataIndication = 0x10,

        /// <summary>
        /// Receive ACK Indication
        /// </summary>
        ReceiveAckIndication = 0x15,

        /// <summary>
        /// Receive No-Data Indication
        /// </summary>
        ReceiveNoDataIndication = 0x16,

        /// <summary>
        /// Set Radio Stack Request
        /// </summary>
        SetRadioStackRequest = 0x19,

        /// <summary>
        /// Set Radio Stack Response
        /// </summary>
        SetRadioStackResponse = 0x1A,

        /// <summary>
        /// Network Status Request
        /// </summary>
        NetworkStatusRequest = 0x29,

        /// <summary>
        /// Network Status Response
        /// </summary>
        NetworkStatusResponse = 0x2A,
    }
}