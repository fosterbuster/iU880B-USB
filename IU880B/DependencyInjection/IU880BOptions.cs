// <copyright file="IU880BOptions.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FosterBuster.IU880B.DependencyInjection
{
    /// <summary>
    /// Options which should fit any operating system.
    /// </summary>
    public class IU880BOptions
    {
        /// <summary>
        /// Gets or sets of the name of the serial port.
        /// </summary>
        /// <remarks>
        /// On UNIX-like systems this shoud be /dev/ttySOMETHINGSOMETHING.
        /// On Windows this would be COM[number].
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the baud rate for the iU880B-stick.
        /// </summary>
        public int BaudRate { get; set; } = 115200;

        /// <summary>
        /// Gets or sets a value indicating whether or not <see cref="Name"/> should be used to query a port on Windows.
        /// </summary>
        public bool UsePortFinder { get; set; }
    }
}