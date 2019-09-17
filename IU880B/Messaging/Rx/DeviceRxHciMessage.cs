// <copyright file="DeviceRxHciMessage.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace FosterBuster.IU880B.Messaging.Rx
{
    /// <summary>
    /// A message received from the Device SAP.
    /// </summary>
    public abstract class DeviceRxHciMessage : RxHciMessage
    {
        private readonly DeviceManagementMessageIdentifier _identifier;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRxHciMessage"/> class.
        /// </summary>
        /// <param name="identifier">The identifier of this message.</param>
        /// <param name="payload">the payload.</param>
        protected DeviceRxHciMessage(DeviceManagementMessageIdentifier identifier, IList<byte> payload)
            : base(EndpointIdentifier.DeviceManager, payload)
        {
            _identifier = identifier;
        }

        /// <inheritdoc/>
        public sealed override byte MessageIdentifier => (byte)_identifier;
    }
}