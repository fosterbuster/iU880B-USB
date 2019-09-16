// <copyright file="IU880BServiceCollectionExtensions.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using FosterBuster.IU880B.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace FosterBuster.IU880B.DependencyInjection
{
    /// <summary>
    /// Extension methods for DI.
    /// </summary>
    public static class IU880BServiceCollectionExtensions
    {
        /// <summary>
        /// Adds IU880B Dependencies.
        /// </summary>
        /// <param name="services">the service collection to be modified.</param>
        /// <param name="setupAction">an action for hooking into.</param>
        /// <returns>a modified service collection.</returns>
        public static IServiceCollection AddIU880BModem(this IServiceCollection services, Action<IU880BOptions> setupAction)
        {
            services.Configure(setupAction);
            services.AddSingleton<IU880BModem>();
            services.AddSingleton<PortFinder>();
            return services;
        }
    }
}