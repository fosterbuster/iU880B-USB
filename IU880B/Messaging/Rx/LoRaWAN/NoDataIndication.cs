// <copyright file="NoDataIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using FosterBuster.Extensions;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN
{
    /// <summary>
    /// This HCI message is sent to the host in case no expected confirmation or data has been received as a result of prior reliable uplink radio packet.
    /// </summary>
    public sealed class NoDataIndication : LoRaWanRxHciMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoDataIndication"/> class.
        /// </summary>
        /// <param name="payload">the payload.</param>
        public NoDataIndication(IList<byte> payload)
            : base(LoRaWanMessageIdentifier.ReceiveNoDataIndication, payload)
        {
        }

        /// <summary>
        /// Gets errorcode flags, if any.
        /// </summary>
        public NoDataIndicationErrorCodes ErrorCode => DetermineErrors();

        private bool ContainsErrorFlag => Payload[2] != 0x00;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"No Data Indication. Errors: {ErrorCode.ToString()}.";
        }

        private NoDataIndicationErrorCodes DetermineErrors()
        {
            if (!ContainsErrorFlag)
            {
                return NoDataIndicationErrorCodes.None;
            }

            NoDataIndicationErrorCodes res = NoDataIndicationErrorCodes.None;
            var errorByte = Payload[3];
            if (errorByte.GetBit(0))
            {
                res |= NoDataIndicationErrorCodes.WrongMtypeReceived;
            }

            if (errorByte.GetBit(1))
            {
                res |= NoDataIndicationErrorCodes.WrongDeviceAddressReceived;
            }

            if (errorByte.GetBit(2))
            {
                res |= NoDataIndicationErrorCodes.WrongMicReceived;
            }

            if (errorByte.GetBit(3))
            {
                res |= NoDataIndicationErrorCodes.UnexpectedFcountReceived;
            }

            if (errorByte.GetBit(4))
            {
                res |= NoDataIndicationErrorCodes.WrongMacCommandsReceived;
            }

            if (errorByte.GetBit(5))
            {
                res |= NoDataIndicationErrorCodes.WrongDownLinkReceived;
            }

            if (errorByte.GetBit(6))
            {
                res |= NoDataIndicationErrorCodes.ExpectedAckMissing;
            }

            return res;
        }
    }
}