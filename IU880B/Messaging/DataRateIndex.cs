// <copyright file="DataRateIndex.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.Messaging
{
    /// <summary>
    /// Data Rate Index.
    /// </summary>
    public enum DataRateIndex : byte
    {
        /// <summary>
        /// LoRa / SF12. Bandwith kHz: 125. Indicative physical bit rate: 250. Maximum payload size: 51.
        /// </summary>
        SpreadingFactor12 = 0x00,

        /// <summary>
        /// LoRa / SF11. Bandwith kHz: 125. Indicative physical bit rate: 440. Maximum payload size: 51.
        /// </summary>
        SpreadingFactor11 = 0x01,

        /// <summary>
        /// LoRa / SF10. Bandwith kHz: 125. Indicative physical bit rate: 890. Maximum payload size: 51.
        /// </summary>
        SpreadingFactor10 = 0x02,

        /// <summary>
        /// LoRa / SF9. Bandwith kHz: 125. Indicative physical bit rate: 1760. Maximum payload size: 115.
        /// </summary>
        SpreadingFactor9 = 0x03,

        /// <summary>
        /// LoRa / SF8. Bandwith kHz: 125. Indicative physical bit rate: 3125. Maximum payload size: 242.
        /// </summary>
        SpreadingFactor8 = 0x04,

        /// <summary>
        /// LoRa / SF12. Bandwith kHz: 125. Indicative physical bit rate: 5470. Maximum payload size: 242.
        /// </summary>
        SpreadingFactor7 = 0x05,

#pragma warning disable SA1005 // Single line comments should begin with single space
        ///// <summary>
        ///// LoRa / SF12. Bandwith kHz: 250. Indicative physical bit rate: 11000. Maximum payload size: 242.
        ///// </summary>
        //SpreadingFactor7_250 = 0x06,

        ///// <summary>
        ///// LoRa / SF12. Bandwith kHz: 250?. Indicative physical bit rate: 50kbps.
        ///// </summary>
        //FSK = 0x07,
#pragma warning restore SA1005 // Single line comments should begin with single space
    }
}