// <copyright file="WiModServiceCollectionExtensions.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using Microsoft.Extensions.DependencyInjection;
using WiMOD.Helpers;

namespace WiMOD.DependencyInjection
{
    /// <summary>
    /// Extension methods for DI.
    /// </summary>
    public static class WiModServiceCollectionExtensions
    {
        /// <summary>
        /// Adds WiMOD Dependencies.
        /// </summary>
        /// <param name="services">the service collection to be modified.</param>
        /// <param name="setupAction">an action for hooking into.</param>
        /// <returns>a modified service collection.</returns>
        public static IServiceCollection AddWiModModem(this IServiceCollection services, Action<WiModOptions> setupAction)
        {
            services.Configure(setupAction);
            services.AddSingleton<WiModModem>();
            services.AddSingleton<PortFinder>();
            return services;
        }
    }
}