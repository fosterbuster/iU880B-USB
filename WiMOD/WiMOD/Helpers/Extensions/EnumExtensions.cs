// <copyright file="EnumExtensions.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Text.RegularExpressions;

namespace WiMOD.Helpers.Extensions
{
    /// <summary>
    /// Extensions for enum-types.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Transforms a byte to an enum.
        /// </summary>
        /// <typeparam name="T">the enum type.</typeparam>
        /// <param name="value">the byte.</param>
        /// <returns>the byte 'cast' to the enum.</returns>
        public static T As<T>(this byte value)
            where T : struct
        {
            return (T)Enum.Parse(typeof(T), value.ToString(), false);
        }

        /// <summary>
        /// Formats a string by insering space before uppercase letters.
        /// </summary>
        /// <typeparam name="T">The type. Should be named integer.</typeparam>
        /// <param name="value">the named integer of the enum.</param>
        /// <returns>a formatted string.</returns>
        public static string ToFormattedString<T>(this T value)
            where T : struct
        {
            return Regex.Replace(value.ToString(), "([A-Z])", " $1", RegexOptions.Compiled).Trim();
        }
    }
}