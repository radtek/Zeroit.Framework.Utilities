﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 06-14-2018
// ***********************************************************************
// <copyright file="NumberToTimeSpanExtensions.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.Utilities.StringProcessing.Humanizer
{
    /// <summary>
    /// Number to TimeSpan extensions
    /// </summary>
    public static class NumberToTimeSpanExtensions
    {
        /// <summary>
        /// 5.Milliseconds() == TimeSpan.FromMilliseconds(5)
        /// </summary>
        /// <param name="ms">The ms.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Milliseconds(this byte ms)
        {
            return Milliseconds((double)ms);
        }

        /// <summary>
        /// 5.Milliseconds() == TimeSpan.FromMilliseconds(5)
        /// </summary>
        /// <param name="ms">The ms.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Milliseconds(this sbyte ms)
        {
            return Milliseconds((double)ms);
        }

        /// <summary>
        /// 5.Milliseconds() == TimeSpan.FromMilliseconds(5)
        /// </summary>
        /// <param name="ms">The ms.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Milliseconds(this short ms)
        {
            return Milliseconds((double)ms);
        }

        /// <summary>
        /// 5.Milliseconds() == TimeSpan.FromMilliseconds(5)
        /// </summary>
        /// <param name="ms">The ms.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Milliseconds(this ushort ms)
        {
            return Milliseconds((double)ms);
        }

        /// <summary>
        /// 5.Milliseconds() == TimeSpan.FromMilliseconds(5)
        /// </summary>
        /// <param name="ms">The ms.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Milliseconds(this int ms)
        {
            return Milliseconds((double) ms);
        }

        /// <summary>
        /// 5.Milliseconds() == TimeSpan.FromMilliseconds(5)
        /// </summary>
        /// <param name="ms">The ms.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Milliseconds(this uint ms)
        {
            return Milliseconds((double) ms);
        }

        /// <summary>
        /// 5.Milliseconds() == TimeSpan.FromMilliseconds(5)
        /// </summary>
        /// <param name="ms">The ms.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Milliseconds(this long ms)
        {
            return Milliseconds((double) ms);
        }

        /// <summary>
        /// 5.Milliseconds() == TimeSpan.FromMilliseconds(5)
        /// </summary>
        /// <param name="ms">The ms.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Milliseconds(this ulong ms)
        {
            return Milliseconds((double)ms);
        }

        /// <summary>
        /// 5.Milliseconds() == TimeSpan.FromMilliseconds(5)
        /// </summary>
        /// <param name="ms">The ms.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Milliseconds(this double ms)
        {
            return TimeSpan.FromMilliseconds(ms);
        }

        /// <summary>
        /// 5.Seconds() == TimeSpan.FromSeconds(5)
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Seconds(this byte seconds)
        {
            return Seconds((double)seconds);
        }

        /// <summary>
        /// 5.Seconds() == TimeSpan.FromSeconds(5)
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Seconds(this sbyte seconds)
        {
            return Seconds((double)seconds);
        }

        /// <summary>
        /// 5.Seconds() == TimeSpan.FromSeconds(5)
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Seconds(this short seconds)
        {
            return Seconds((double)seconds);
        }

        /// <summary>
        /// 5.Seconds() == TimeSpan.FromSeconds(5)
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Seconds(this ushort seconds)
        {
            return Seconds((double)seconds);
        }

        /// <summary>
        /// 5.Seconds() == TimeSpan.FromSeconds(5)
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Seconds(this int seconds)
        {
            return Seconds((double) seconds);
        }

        /// <summary>
        /// 5.Seconds() == TimeSpan.FromSeconds(5)
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Seconds(this uint seconds)
        {
            return Seconds((double) seconds);
        }

        /// <summary>
        /// 5.Seconds() == TimeSpan.FromSeconds(5)
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Seconds(this long seconds)
        {
            return Seconds((double) seconds);
        }

        /// <summary>
        /// 5.Seconds() == TimeSpan.FromSeconds(5)
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Seconds(this ulong seconds)
        {
            return Seconds((double)seconds);
        }

        /// <summary>
        /// 5.Seconds() == TimeSpan.FromSeconds(5)
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Seconds(this double seconds)
        {
            return TimeSpan.FromSeconds(seconds);
        }

        /// <summary>
        /// 4.Minutes() == TimeSpan.FromMinutes(4)
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Minutes(this byte minutes)
        {
            return Minutes((double)minutes);
        }

        /// <summary>
        /// 4.Minutes() == TimeSpan.FromMinutes(4)
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Minutes(this sbyte minutes)
        {
            return Minutes((double)minutes);
        }

        /// <summary>
        /// 4.Minutes() == TimeSpan.FromMinutes(4)
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Minutes(this short minutes)
        {
            return Minutes((double)minutes);
        }

        /// <summary>
        /// 4.Minutes() == TimeSpan.FromMinutes(4)
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Minutes(this ushort minutes)
        {
            return Minutes((double)minutes);
        }

        /// <summary>
        /// 4.Minutes() == TimeSpan.FromMinutes(4)
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Minutes(this int minutes)
        {
            return Minutes((double) minutes);
        }

        /// <summary>
        /// 4.Minutes() == TimeSpan.FromMinutes(4)
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Minutes(this uint minutes)
        {
            return Minutes((double) minutes);
        }

        /// <summary>
        /// 4.Minutes() == TimeSpan.FromMinutes(4)
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Minutes(this long minutes)
        {
            return Minutes((double) minutes);
        }

        /// <summary>
        /// 4.Minutes() == TimeSpan.FromMinutes(4)
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Minutes(this ulong minutes)
        {
            return Minutes((double)minutes);
        }

        /// <summary>
        /// 4.Minutes() == TimeSpan.FromMinutes(4)
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Minutes(this double minutes)
        {
            return TimeSpan.FromMinutes(minutes);
        }

        /// <summary>
        /// 3.Hours() == TimeSpan.FromHours(3)
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Hours(this byte hours)
        {
            return Hours((double)hours);
        }

        /// <summary>
        /// 3.Hours() == TimeSpan.FromHours(3)
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Hours(this sbyte hours)
        {
            return Hours((double)hours);
        }

        /// <summary>
        /// 3.Hours() == TimeSpan.FromHours(3)
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Hours(this short hours)
        {
            return Hours((double)hours);
        }

        /// <summary>
        /// 3.Hours() == TimeSpan.FromHours(3)
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Hours(this ushort hours)
        {
            return Hours((double)hours);
        }

        /// <summary>
        /// 3.Hours() == TimeSpan.FromHours(3)
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Hours(this int hours)
        {
            return Hours((double) hours);
        }

        /// <summary>
        /// 3.Hours() == TimeSpan.FromHours(3)
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Hours(this uint hours)
        {
            return Hours((double) hours);
        }

        /// <summary>
        /// 3.Hours() == TimeSpan.FromHours(3)
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Hours(this long hours)
        {
            return Hours((double) hours);
        }

        /// <summary>
        /// 3.Hours() == TimeSpan.FromHours(3)
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Hours(this ulong hours)
        {
            return Hours((double)hours);
        }

        /// <summary>
        /// 3.Hours() == TimeSpan.FromHours(3)
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Hours(this double hours)
        {
            return TimeSpan.FromHours(hours);
        }

        /// <summary>
        /// 2.Days() == TimeSpan.FromDays(2)
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Days(this byte days)
        {
            return Days((double)days);
        }

        /// <summary>
        /// 2.Days() == TimeSpan.FromDays(2)
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Days(this sbyte days)
        {
            return Days((double)days);
        }

        /// <summary>
        /// 2.Days() == TimeSpan.FromDays(2)
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Days(this short days)
        {
            return Days((double)days);
        }

        /// <summary>
        /// 2.Days() == TimeSpan.FromDays(2)
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Days(this ushort days)
        {
            return Days((double)days);
        }

        /// <summary>
        /// 2.Days() == TimeSpan.FromDays(2)
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Days(this int days)
        {
            return Days((double) days);
        }

        /// <summary>
        /// 2.Days() == TimeSpan.FromDays(2)
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Days(this uint days)
        {
            return Days((double) days);
        }

        /// <summary>
        /// 2.Days() == TimeSpan.FromDays(2)
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Days(this long days)
        {
            return Days((double) days);
        }

        /// <summary>
        /// 2.Days() == TimeSpan.FromDays(2)
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Days(this ulong days)
        {
            return Days((double)days);
        }

        /// <summary>
        /// 2.Days() == TimeSpan.FromDays(2)
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Days(this double days)
        {
            return TimeSpan.FromDays(days);
        }

        /// <summary>
        /// 2.Weeks() == new TimeSpan(14, 0, 0, 0)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Weeks(this byte input)
        {
            return Weeks((double)input);
        }

        /// <summary>
        /// 2.Weeks() == new TimeSpan(14, 0, 0, 0)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Weeks(this sbyte input)
        {
            return Weeks((double)input);
        }

        /// <summary>
        /// 2.Weeks() == new TimeSpan(14, 0, 0, 0)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Weeks(this short input)
        {
            return Weeks((double)input);
        }

        /// <summary>
        /// 2.Weeks() == new TimeSpan(14, 0, 0, 0)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Weeks(this ushort input)
        {
            return Weeks((double)input);
        }

        /// <summary>
        /// 2.Weeks() == new TimeSpan(14, 0, 0, 0)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Weeks(this int input)
        {
            return Weeks((double) input);
        }

        /// <summary>
        /// 2.Weeks() == new TimeSpan(14, 0, 0, 0)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Weeks(this uint input)
        {
            return Weeks((double) input);
        }

        /// <summary>
        /// 2.Weeks() == new TimeSpan(14, 0, 0, 0)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Weeks(this long input)
        {
            return Weeks((double) input);
        }

        /// <summary>
        /// 2.Weeks() == new TimeSpan(14, 0, 0, 0)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Weeks(this ulong input)
        {
            return Weeks((double)input);
        }

        /// <summary>
        /// 2.Weeks() == new TimeSpan(14, 0, 0, 0)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan Weeks(this double input)
        {
            return Days(7*input);
        }
    }
}