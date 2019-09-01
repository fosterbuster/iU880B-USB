// <copyright file="Program.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
#pragma warning disable S1118 // Utility classes should not have public constructors

using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WiMOD.DependencyInjection;
using WiMOD.Messaging.Rx;
using WiMOD.Messaging.Rx.Device;
using WiMOD.Messaging.Tx.Device;
using WiMOD.Messaging.Tx.LoRa.Configuration;

namespace WiMOD
{
    internal class Program
    {
        protected static async Task Main(string[] args)
        {
            // Notice that this configuration spawns up the PortFinder, which is a utility class thats a bit helpful if yoir USB-stick keeps deciding it wants to be registered as a different port. Only works on windows.
            ServiceProvider serviceCollection = new ServiceCollection().AddWiModModem(x =>
            {
                x.Name = "USB";
                x.UsePortFinder = true;
            })
            .AddSingleton<ILoggerFactory, LoggerFactory>()
            .AddLogging(loggingBuilder => loggingBuilder
            .AddConsole()
            .SetMinimumLevel(LogLevel.Trace))
            .BuildServiceProvider();

            ILogger<Program> logger = serviceCollection.GetService<ILoggerFactory>().CreateLogger<Program>();

            logger.LogDebug("Starting WiMod.");
            WiModModem modem = serviceCollection.GetService<WiModModem>();

            // For the sake of showing that this is how you listen, I just made it a lambda. When you make an actual program you should do something a bit smarter perhaps.
            modem.SetReceiver(async (RxHciMessage message) =>
            {
                if (message is PingResponse)
                {
                    await modem.TransmitMessage(new DeviceInformationRequest());
                }
                else
                {
                    await modem.TransmitMessage(new NetworkStatusRequest());
                }
            });

            // Transmit a message just to get things rolling.
            await modem.TransmitMessage(new PingRequest());

            Console.ReadKey(true);
        }
    }
}

#pragma warning restore S1118 // Utility classes should not have public constructors