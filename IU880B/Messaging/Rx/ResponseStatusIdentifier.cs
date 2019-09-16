// <copyright file="ResponseStatusIdentifier.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.Messaging.Rx
{
    /// <summary>
    /// Container for device status bytes and their meaning.
    /// </summary>
    public enum ResponseStatusIdentifier : byte
    {
        /// <summary>
        /// Operation successful
        /// </summary>
        Ok = 0x00,

        /// <summary>
        /// Operation failed
        /// </summary>
        Error = 0x01,

        /// <summary>
        /// Command is not supported
        /// </summary>
        CommandNotSupported = 0x02,

        /// <summary>
        /// HCI message contains wrong parameter
        /// </summary>
        WrongParameter = 0x03,

        /// <summary>
        /// Stack is running in a wrong mode
        /// </summary>
        StackRunningInWrongMode = 0x04,

        /// <summary>
        /// Device is not activated
        /// </summary>
        DeviceNotActivated = 0x05,

        /// <summary>
        /// Device is busy, command rejected
        /// </summary>
        DeviceBusyCommandRejected = 0x06,

        /// <summary>
        /// Message queue is full, command rejected
        /// </summary>
        MessageQueueFullCommandRejected = 0x07,

        /// <summary>
        /// HCI message length is invalid or radio payload size is too large
        /// </summary>
        HciMessageLengthIsInvalidOrRadioPayloadSizeTooLarge = 0x08,

        /// <summary>
        /// Factory Settings EEPROM block missing
        /// </summary>
        FactorySettingsEepromBlockMissing = 0x09,

        /// <summary>
        /// Channel blocked by Duty Cycle
        /// </summary>
        ChannelBlockedByDutyCycle = 0x0A,

        /// <summary>
        /// No channel available (e.g. no channel defined for the configured spreading factor)
        /// </summary>
        NoChannelAvailable = 0x0B,
    }
}