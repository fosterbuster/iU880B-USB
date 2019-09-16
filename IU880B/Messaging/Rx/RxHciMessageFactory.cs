// <copyright file="RxHciMessageFactory.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FosterBuster.IU880B.Messaging.Rx
{
    internal static class RxHciMessageFactory
    {
        private static readonly Dictionary<(byte endpointIdentifier, byte messageIdentifier), Type> _knownSubTypes = new Dictionary<(byte, byte), Type>();

        static RxHciMessageFactory()
        {
            RegisterAllRxHciMessageTypes();
        }

        public static RxHciMessage Create(IList<byte> payload)
        {
            if (_knownSubTypes.TryGetValue((endpointIdentifier: payload[0], messageIdentifier: payload[1]), out Type type))
            {
                return (RxHciMessage)Activator.CreateInstance(type, payload);
            }

            throw new KeyNotFoundException("Could not find a compatible message to marshal into. Please ensure the response message has been implemented.");
        }

        private static void RegisterAllRxHciMessageTypes()
        {
            Type rxHciBaseType = typeof(RxHciMessage);
            foreach (Assembly domainAssembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in domainAssembly.GetTypes()
                    .Where(type => type.IsSubclassOf(rxHciBaseType) && !type.IsAbstract))
                {
                    // this is really ugly, and should properly never be done. I, however cannot think of a more painless way of creating a factory.
                    // Also forces whoever is implementing new messages to have lazy initialization - Which I am fine with.
                    var instance = (RxHciMessage)Activator.CreateInstance(type, new byte[] { });
                    var endpointValue = (byte)type.GetProperty("EndpointIdentifier").GetValue(instance);
                    var messageValue = (byte)type.GetProperty("MessageIdentifier").GetValue(instance);
                    _knownSubTypes.Add((endpointIdentifier: endpointValue, messageIdentifier: messageValue), type);
                }
            }
        }
    }
}