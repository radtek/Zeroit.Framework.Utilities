﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="DateToOrdinalWordsExtensions.cs" company="Zeroit Dev Technologies">
//    This program contains Utilities for all C# programming activities.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Zeroit.Framework.Utilities.StringProcessing.HumanizerConfiguration;

namespace Zeroit.Framework.Utilities.StringProcessing.Humanizer
{
    /// <summary>
    /// Humanizes DateTime into human readable sentence
    /// </summary>
    public static class DateToOrdinalWordsExtensions
    {
        /// <summary>
        /// Turns the provided date into ordinal words
        /// </summary>
        /// <param name="input">The date to be made into ordinal words</param>
        /// <returns>The date in ordinal words</returns>
        public static string ToOrdinalWords(this DateTime input)
        {
            return Configurator.DateToOrdinalWordsConverter.Convert(input);
        }
        /// <summary>
        /// Turns the provided date into ordinal words
        /// </summary>
        /// <param name="input">The date to be made into ordinal words</param>
        /// <param name="grammaticalCase">The grammatical case to use for output words</param>
        /// <returns>The date in ordinal words</returns>
        public static string ToOrdinalWords(this DateTime input, Zeroit.Framework.Utilities.StringProcessing.Humanizer.GrammaticalCase grammaticalCase)
        {
            return Configurator.DateToOrdinalWordsConverter.Convert(input, grammaticalCase);
        }
    }
}