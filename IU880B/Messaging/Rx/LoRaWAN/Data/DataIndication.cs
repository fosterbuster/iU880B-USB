// <copyright file="DataIndication.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using FosterBuster.Extensions;

namespace FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Data
{
    /// <summary>
    /// Super class for Data Indication messages.
    /// </summary>
    public abstract class DataIndication : LoRaWanRxHciMessage
    {
        private const int ApplicationPayloadStart = 4;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataIndication"/> class.
        /// </summary>
        /// <param name="identifier">the message identifier.</param>
        /// <param name="payload">the payload.</param>
        protected DataIndication(LoRaWanMessageIdentifier identifier, IList<byte> payload)
            : base(identifier, payload)
        {
        }

        /// <summary>
        /// Gets the LoRaWAN Port number.
        /// </summary>
        public int? Port => IsAcknowledgement ? null : (int?)Payload[3]; // If its an ACK, there is no port (or at least thats how I read it).

        /// <summary>
        /// Gets the Application Layer Payload.
        /// </summary>
        public byte[]? ApplicationPayload => IsAcknowledgement ? null : GetApplicationPayload();

        /// <summary>
        /// Gets a value indicating whether or not the message is an acknowledgement sent from the server.
        /// </summary>
        public bool IsAcknowledgement => Payload[2].GetBit(1); // ACK is indicated via Unreliable or Reliable Data Indication with empty LoRaWAN Port and empty Application Payload Field.

        /// <summary>
        /// Gets the channel index.
        /// </summary>
        public int? ChannelIndex => IsExtended ? (int?)Payload[Payload.Count - 5] : null;

        /// <summary>
        /// Gets the spreading factor this message was received with.
        /// </summary>
        public DataRateIndex? DataRate => IsExtended ? (DataRateIndex?)Payload[Payload.Count - 4].As<DataRateIndex>() : null;

        /// <summary>
        /// Gets the RSSI-level in dBm.
        /// </summary>
        public int? RelativeSignalStrengthIndicator => IsExtended ? (int?)-Payload[Payload.Count - 3] : null;

        /// <summary>
        /// Gets the SNR in dBm.
        /// </summary>
        public int? SignalToNoiseRatio => IsExtended ? (int?)-Payload[Payload.Count - 2] : null;

        /// <summary>
        /// Gets the Rx Slot Value.
        /// </summary>
        public int? RxSlot => IsExtended ? (int?)Payload[Payload.Count - 1] : null;

        private bool IsExtended => Payload[2].GetBit(0);

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"ACK: {IsAcknowledgement}" +
                (IsExtended ? $" Channel Index: {ChannelIndex!.Value}, Data Rate: {DataRate!.Value.ToFormattedString()}, RSSI: {RelativeSignalStrengthIndicator!.Value}, SNR: {SignalToNoiseRatio!.Value}, Rx Slot Value: {RxSlot!.Value}" : string.Empty) +
                (!IsAcknowledgement ? $" - Application Layer Payload: {ApplicationPayload!.ToHexString()}, Port: {Port!.Value}" : string.Empty);
        }

        private byte[] GetApplicationPayload()
        {
            // If the message is 'extended' we need to take into account the n+[1-5] bytes following the application layer payload.
            var skipBytes = IsExtended ? ApplicationPayloadStart - 5 : ApplicationPayloadStart;
            return Payload.Skip(ApplicationPayloadStart).Take(Payload.Count - skipBytes).ToArray();
        }
    }
}