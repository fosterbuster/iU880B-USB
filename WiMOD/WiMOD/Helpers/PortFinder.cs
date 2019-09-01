// <copyright file="PortFinder.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.IO.Ports;
using System.Management;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WiMOD.DependencyInjection;

namespace WiMOD.Helpers
{
    /// <summary>
    /// Finds connected serialdevices automagically on windows machines.
    /// </summary>
    public class PortFinder
    {
        private readonly string _deviceName;
        private readonly string _mgmtObjQuery = "Name";
        private readonly string _portRegex = @"\(([^)]*)\)";
        private readonly ILogger<PortFinder> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortFinder"/> class.
        /// </summary>
        /// <param name="options">options object.</param>
        /// <param name="loggerFactory">logger factory.</param>
        public PortFinder(IOptions<WiModOptions> options, ILoggerFactory loggerFactory)
        {
            _deviceName = options.Value.Name;
            _logger = loggerFactory.CreateLogger<PortFinder>();
        }

        /// <summary>
        /// Gets the first port number mathcing the device name.
        /// </summary>
        /// <returns>A string representation of the devices COM-port.</returns>
        public string ConnectedPortName => FindConnectedPort();

        /// <summary>
        /// Gets a serial connection to the first port number matching the device name.
        /// </summary>
        /// <returns>the connected <see cref="SerialPort"/>.</returns>
        public SerialPort ConnectedSerialPort => GetConnectedSerialPort();

        /// <summary>
        /// Checks if any device is available.
        /// </summary>
        /// <returns>A boolean indicating if any device is available.</returns>
        public bool DeviceAvailable() => !string.IsNullOrEmpty(FindConnectedPort());

        private string FindConnectedPort()
        {
            _logger.LogTrace("Starting search for virtual COM device with name: {name}", _deviceName);
            string foundPort = null;
            try
            {
                var search = new ManagementObjectSearcher(
                    "root\\CIMV2",
                    "SELECT * FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e978-e325-11ce-bfc1-08002be10318}\"");

                foreach (ManagementBaseObject mgmtObj in search.Get())
                {
                    var queryObj = mgmtObj as ManagementObject;
                    var name = queryObj[_mgmtObjQuery] as string;
                    if (name.Contains(_deviceName))
                    {
                        var port = Regex.Match(name, _portRegex).Groups[1].Value;
                        foundPort = port;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error whilst looking for virtual COM device {name}", _deviceName);
            }

            return foundPort;
        }

        private SerialPort GetConnectedSerialPort()
        {
            var port = FindConnectedPort();
            return port != null ? new SerialPort(FindConnectedPort()) : null;
        }
    }
}