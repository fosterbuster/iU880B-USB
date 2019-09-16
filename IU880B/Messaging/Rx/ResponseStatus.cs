// <copyright file="ResponseStatus.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using FosterBuster.Extensions;

namespace FosterBuster.IU880B.Messaging.Rx
{
    /// <summary>
    /// Device Management Endpoint Status Byte.
    /// </summary>
    public class ResponseStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStatus"/> class.
        /// </summary>
        /// <param name="statusByte">the byte indicating the status.</param>
        public ResponseStatus(byte statusByte)
        {
            Status = (ResponseStatusIdentifier)statusByte;
        }

        /// <summary>
        /// Gets the status.
        /// </summary>
        public ResponseStatusIdentifier Status { get; private set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Status.ToFormattedString();
        }
    }
}