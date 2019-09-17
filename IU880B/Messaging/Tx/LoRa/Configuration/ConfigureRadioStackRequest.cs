// <copyright file="ConfigureRadioStackRequest.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using FosterBuster.Extensions;

namespace FosterBuster.IU880B.Messaging.Tx.LoRa.Configuration
{
    /// <summary>
    /// This request can be used to configure the integrated radio stack.
    /// </summary>
    public sealed class ConfigureRadioStackRequest : LoRaWanTxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureRadioStackRequest"/> class.
        /// </summary>
        /// <param name="dataRateIndex">Default Data Rate Index.</param>
        /// <param name="adaptiveDataRateEnabled">Adaptive Data Rate enabled/disabled.</param>
        /// <param name="dutyCycleControlEnabled">Duty Cycle Control enabled/disabled. (Customer Mode Required).</param>
        /// <param name="isClassC">Class indicator. Class A if false, Class C device if true.</param>
        /// <param name="extendedOutputFormatEnabled">Extended RF packet output format: Tx/Rx channel info attached if true.</param>
        /// <param name="rxMacForwardingEnabled">Rx MAC Command Forwarding enabled/disabled.</param>
        /// <param name="powerSavingEnabled">Power Saving. Off is false, automatic if true.</param>
        /// <param name="retryAttemps">Maximum number of retries for a reliable radio packet (parameter range: 0 to 254).</param>
        /// <param name="headerMacCmdCapacity">Maximum length of the MAC commands to be piggybacked in the header (parameter range: 0 to 15).</param>
        public ConfigureRadioStackRequest(
            DataRateIndex dataRateIndex,
            bool adaptiveDataRateEnabled = false,
            bool dutyCycleControlEnabled = true,
            bool isClassC = true,
            bool extendedOutputFormatEnabled = true,
            bool rxMacForwardingEnabled = true,
            bool powerSavingEnabled = false,
            byte retryAttemps = 10,
            byte headerMacCmdCapacity = 15)
            : base(LoRaWanMessageIdentifier.SetRadioStackRequest, new List<byte>())
        {
            var dataRateByte = (byte)dataRateIndex;
            byte trxLevel = 0x10; // 16 in dec
            var powerSavingByte = powerSavingEnabled ? (byte)0x01 : (byte)0x00;
            var optionsByte = BuildOptionsByte(adaptiveDataRateEnabled, dutyCycleControlEnabled, isClassC, extendedOutputFormatEnabled, rxMacForwardingEnabled);
            byte bandIndex = 0x01; // Doesn't seem to work with any other value than 1. Could be a bug, but I can't be assed to investigate. Or maybe something with regions...

            Payload.Add(dataRateByte);
            Payload.Add(trxLevel);
            Payload.Add(optionsByte);
            Payload.Add(powerSavingByte);
            Payload.Add(retryAttemps);
            Payload.Add(bandIndex);
            Payload.Add(headerMacCmdCapacity);
        }

        private byte BuildOptionsByte(bool adaptiveDataRateEnabled, bool dutyCycleControlEnabled, bool isClassC, bool extendedOutputFormatEnabled, bool rxMacForwardingEnabled)
        {
            byte value = 0x00;

            if (adaptiveDataRateEnabled)
            {
                value = value.SetBit(0);
            }

            if (dutyCycleControlEnabled)
            {
                value = value.SetBit(1);
            }

            if (isClassC)
            {
                value = value.SetBit(2);
            }

            if (extendedOutputFormatEnabled)
            {
                value = value.SetBit(6);
            }

            if (rxMacForwardingEnabled)
            {
                value = value.SetBit(7);
            }

            return value;
        }
    }
}