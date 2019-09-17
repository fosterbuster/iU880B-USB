// <copyright file="Program.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using FosterBuster.Extensions;
using FosterBuster.IU880B.Messaging.Rx;
using FosterBuster.IU880B;

using FosterBuster.IU880B.DependencyInjection;
using FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Data;
using FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Activation;
using FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Activation;
using FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Configuration;
using FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Data;

namespace Example
{
    internal class Program
    {
        protected static async Task Main(string[] args)
        {
            // Notice that this configuration spawns up the PortFinder, which is a utility class thats a bit helpful if yoir USB-stick keeps deciding it wants to be registered as a different port. Only works on windows (and you should use .net core 3 preview if running linux).
            ServiceProvider serviceCollection = new ServiceCollection().AddIU880BModem(x =>
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

            logger.LogDebug("Starting IU880B.");
            IU880BModem modem = serviceCollection.GetService<IU880BModem>();

            // Fo.r the sake of showing that this is how you listen, I just made it a lambda. When you make an actual program you should do something a bit smarter perhaps.
            modem.SetReceiver(async (RxHciMessage message) =>
            {
                #region Receiving ACKs and payloads sent downlink

                // UnreliableDataIndication and ReliableDataIndication shares exactly the same format and logic, so we just use their parent class.
                if (message is DataIndication indication)
                {
                    if (indication.IsAcknowledgement)
                    {
                        logger.LogInformation("Received an ACK for a previously sent package");
                    }
                    else
                    {
                        logger.LogInformation("Received message: {payload} on port {port}", indication.ApplicationPayload.ToHexString(), indication.Port);
                    }
                }
                #endregion

                #region Over The Air Activation and handling device not activated errors.

                // Imagine that we for some reason have not activated the device.
                if (message is DataMessageResponse dmr)
                {
                    // Device isnt activated :'(
                    if (dmr.Status.Status == ResponseStatusIdentifier.DeviceNotActivated)
                    {
                        // FIXME: This should contain your OTAA params.
                        await modem.TransmitMessage(new SetJoinParametersRequest("", ""));
                    }
                }

                // We have successfully set our join params. Lets activate the device.
                if (message is SetJoinParametersResponse joinParametersResponse)
                {
                    if (joinParametersResponse.Status.Status == ResponseStatusIdentifier.Ok)
                    {
                        await modem.TransmitMessage(new OverTheAirActivationRequest());
                    }
                }

                if (message is JoinNetworkIndication joinNetworkIndication)
                {
                    if (joinNetworkIndication.DeviceActivated)
                    {
                        // Device is activated through OTAA. You can now start sending and reciving data.
                    }
                }

                #endregion

                #region Activation By Personalisation
                // Imagine we want to check if the device is activated or not. We previously sent a NetworkStatusRequest..
                if (message is NetworkStatusResponse networkStatusResponse)
                {
                    switch (networkStatusResponse.NetworkStatus)
                    {
                        // Its not active, lets activate it using ABP.
                        case NetworkStatusIndicator.DeviceInactive:
                            // FIXME: Add your ABP params.
                            await modem.TransmitMessage(new ActivationByPersonalisationRequest("", "", ""));
                            break;

                        // For the ones below, we don't really care right now. Either its already active, or its currently joining by OTAA.
                        case NetworkStatusIndicator.DeviceActiveByActivationByPersonalisation:
                        case NetworkStatusIndicator.DeviceActiveByOverTheAirActivation:
                        case NetworkStatusIndicator.DeviceJoiningByOverTheAirActivation:
                        default:
                            break;
                    }
                }

                // Lets check if we did everything correctly.
                if (message is ActivationByPersonalisationResponse abpResponse)
                {
                    if (abpResponse.Status.Status == ResponseStatusIdentifier.Ok)
                    {
                        // The request was accepted by the device - We can now ASSUME that its activated.
                    }
                }

                #endregion

                await Task.CompletedTask;
            });

            // Transmit a message. Unreliable just means that we do not want an ACK from the gateway - Reliable makes the device spam until it gets an ACK.
            await modem.TransmitMessage(new UnreliableDataMessageRequest(5, new List<byte>() { 0xFF }));

            Console.ReadKey(true);
        }
    }
}