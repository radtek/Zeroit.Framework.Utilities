﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 06-14-2018
// ***********************************************************************
// <copyright file="NumberToNumberExtensions.cs" company="Zeroit Dev Technologies">
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
using System.Runtime.CompilerServices;

namespace Zeroit.Framework.Utilities.StringProcessing.Humanizer
{
    /// <summary>
    /// Number to Number extensions
    /// </summary>
    public static class NumberToNumberExtensions
    {
        /// <summary>
        /// 5.Tens == 50
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Tens(this int input)
        {
            return input*10;
        }

        /// <summary>
        /// 5.Tens == 50
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Tens(this uint input)
        {
            return input*10;
        }

        /// <summary>
        /// 5.Tens == 50
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Tens(this long input)
        {
            return input*10;
        }

        /// <summary>
        /// 5.Tens == 50
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Tens(this ulong input)
        {
            return input*10;
        }

        /// <summary>
        /// 5.Tens == 50
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Double.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Tens(this double input)
        {
            return input*10;
        }

        /// <summary>
        /// 4.Hundreds() == 400
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Hundreds(this int input)
        {
            return input*100;
        }

        /// <summary>
        /// 4.Hundreds() == 400
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hundreds(this uint input)
        {
            return input*100;
        }

        /// <summary>
        /// 4.Hundreds() == 400
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Hundreds(this long input)
        {
            return input*100;
        }

        /// <summary>
        /// 4.Hundreds() == 400
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Hundreds(this ulong input)
        {
            return input*100;
        }

        /// <summary>
        /// 4.Hundreds() == 400
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Double.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Hundreds(this double input)
        {
            return input*100;
        }

        /// <summary>
        /// 3.Thousands() == 3000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Thousands(this int input)
        {
            return input*1000;
        }

        /// <summary>
        /// 3.Thousands() == 3000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Thousands(this uint input)
        {
            return input*1000;
        }

        /// <summary>
        /// 3.Thousands() == 3000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Thousands(this long input)
        {
            return input*1000;
        }

        /// <summary>
        /// 3.Thousands() == 3000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Thousands(this ulong input)
        {
            return input*1000;
        }

        /// <summary>
        /// 3.Thousands() == 3000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Double.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Thousands(this double input)
        {
            return input*1000;
        }

        /// <summary>
        /// 2.Millions() == 2000000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Millions(this int input)
        {
            return input*1000000;
        }

        /// <summary>
        /// 2.Millions() == 2000000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Millions(this uint input)
        {
            return input*1000000;
        }

        /// <summary>
        /// 2.Millions() == 2000000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Millions(this long input)
        {
            return input*1000000;
        }

        /// <summary>
        /// 2.Millions() == 2000000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Millions(this ulong input)
        {
            return input*1000000;
        }

        /// <summary>
        /// 2.Millions() == 2000000
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Double.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Millions(this double input)
        {
            return input*1000000;
        }

        /// <summary>
        /// 1.Billions() == 1000000000 (short scale)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Billions(this int input)
        {
            return input*1000000000;
        }

        /// <summary>
        /// 1.Billions() == 1000000000 (short scale)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt32.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Billions(this uint input)
        {
            return input*1000000000;
        }

        /// <summary>
        /// 1.Billions() == 1000000000 (short scale)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Int64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Billions(this long input)
        {
            return input*1000000000;
        }

        /// <summary>
        /// 1.Billions() == 1000000000 (short scale)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.UInt64.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Billions(this ulong input)
        {
            return input*1000000000;
        }

        /// <summary>
        /// 1.Billions() == 1000000000 (short scale)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.Double.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Billions(this double input)
        {
            return input*1000000000;
        }
    }
}
