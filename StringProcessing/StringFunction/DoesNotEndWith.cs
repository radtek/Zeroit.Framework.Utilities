﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="DoesNotEndWith.cs" company="Zeroit Dev Technologies">
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


namespace Zeroit.Framework.Utilities.StringProcessing
{
    /// <summary>
    /// Class StringFunctions.
    /// </summary>
    public static partial class StringFunctions
    {
        //---------------------------------Implementation-----------------------------//

        //Assert.IsTrue("Test".DoesNotEndWith('?'));

        //---------------------------------Implementation-----------------------------//

        /// <summary>
        /// It returns true if string does not end with the character otherwise returns false.
        /// If you pass null or empty string, false will be returned.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="pattern">The pattern.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool DoesNotEndWith(this string input, string pattern)
        {
            return string.IsNullOrEmpty(pattern) ||
                   input.IsNullOrEmptyOrWhiteSpace() ||
                   !input.EndsWith(pattern, StringComparison.CurrentCulture);
        }
    }
}
