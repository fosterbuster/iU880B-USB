// <copyright file="IU880BModuleType.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.Messaging.Rx.Device
{
    /// <summary>
    /// Module types for IU880B.
    /// </summary>
    public enum IU880BModuleType : byte
    {
#pragma warning disable SA1602 // Enumeration items should be documented
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        IM8880A = 0x90,
        IM889AL = 0x92,
        IU880A = 0x93,
        IM880BL = 0x98,
        IU880B = 0x99,
        IM980A = 0x9A,
        IM881A = 0xA0,
#pragma warning restore SA1602 // Enumeration items should be documented
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}