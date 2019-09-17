// <copyright file="RequestResponseMappings.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using FosterBuster.IU880B.Messaging.Rx.Device;
using FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Activation;
using FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Configuration;
using FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Data;
using FosterBuster.IU880B.Messaging.Tx.Device;
using FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Activation;
using FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Configuration;
using FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Data;

namespace FosterBuster.IU880B.Utilities
{
    /// <summary>
    /// A utility class which serves the reponse types for requests, and vice-versa. Made to mitigate poor early design choices.
    /// </summary>
    public static class RequestResponseMappings
    {
        private static readonly Dictionary<Type, Type> _requestToResponse = new Dictionary<Type, Type>
        {
            { typeof(ReliableDataMessageRequest), typeof(ReliableDataMessageResponse) },
            { typeof(UnreliableDataMessageRequest), typeof(UnreliableDataMessageResponse) },
            { typeof(ConfigureRadioStackRequest), typeof(ConfigureRadioStackResponse) },
            { typeof(NetworkStatusRequest), typeof(NetworkStatusResponse) },
            { typeof(ActivationByPersonalisationRequest), typeof(ActivationByPersonalisationResponse) },
            { typeof(OverTheAirActivationRequest), typeof(OverTheAirActivationResponse) },
            { typeof(SetJoinParametersRequest), typeof(SetJoinParametersResponse) },
            { typeof(DeviceInformationRequest), typeof(DeviceInformationResponse) },
            { typeof(PingRequest), typeof(PingResponse) },
            { typeof(ResetRequest), typeof(ResetResponse) },
        };

        private static readonly Dictionary<Type, Type> _responseToRequest = _requestToResponse.ToDictionary((item) => item.Value, (i) => i.Key);

        /// <summary>
        /// Gets the <see cref="Messaging.Rx.RxHciMessage"/> equivalent for the passed <paramref name="type"/> of <see cref="Messaging.Tx.TxHciMessage"/>.
        /// </summary>
        /// <param name="type">the type to look up.</param>
        /// <returns>The equivalent <see cref="Messaging.Rx.RxHciMessage"/> for the passed <paramref name="type"/>. Null if no match.</returns>
        public static Type GetResponseTypeFor(Type type)
        {
            if (_requestToResponse.TryGetValue(type, out Type result))
            {
                return result;
            }

            return null;
        }

        /// <summary>
        /// Gets the <see cref="Messaging.Tx.TxHciMessage"/> equivalent for the passed <paramref name="type"/> of <see cref="Messaging.Rx.RxHciMessage"/>.
        /// </summary>
        /// <param name="type">the type to look up.</param>
        /// <returns>The equivalent <see cref="Messaging.Tx.TxHciMessage"/> for the passed <paramref name="type"/>. Null if no match.</returns>
        public static Type GetRequestTypeFor(Type type)
        {
            if (_responseToRequest.TryGetValue(type, out Type result))
            {
                return result;
            }

            return null;
        }
    }
}