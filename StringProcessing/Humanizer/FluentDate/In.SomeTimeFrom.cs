﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 06-14-2018
// ***********************************************************************
// <copyright file="In.SomeTimeFrom.cs" company="Zeroit Dev Technologies">
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
    /// Class In.
    /// </summary>
    public partial class In
    {

        /// <summary>
        /// Class One.
        /// </summary>
        public static class One
		{
            /// <summary>
            /// 1 seconds from now
            /// </summary>
            /// <value>The second.</value>
            public static DateTime Second
			{
				get { return DateTime.UtcNow.AddSeconds(1); }
			}

            /// <summary>
            /// 1 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondFrom(DateTime date)
			{
				return date.AddSeconds(1);
			}

            /// <summary>
            /// 1 minutes from now
            /// </summary>
            /// <value>The minute.</value>
            public static DateTime Minute
			{
				get { return DateTime.UtcNow.AddMinutes(1); }
			}

            /// <summary>
            /// 1 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinuteFrom(DateTime date)
			{
				return date.AddMinutes(1);
			}

            /// <summary>
            /// 1 hours from now
            /// </summary>
            /// <value>The hour.</value>
            public static DateTime Hour
			{
				get { return DateTime.UtcNow.AddHours(1); }
			}

            /// <summary>
            /// 1 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HourFrom(DateTime date)
			{
				return date.AddHours(1);
			}

            /// <summary>
            /// 1 days from now
            /// </summary>
            /// <value>The day.</value>
            public static DateTime Day
			{
				get { return DateTime.UtcNow.AddDays(1); }
			}

            /// <summary>
            /// 1 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DayFrom(DateTime date)
			{
				return date.AddDays(1);
			}

            /// <summary>
            /// 1 weeks from now
            /// </summary>
            /// <value>The week.</value>
            public static DateTime Week
			{
				get { return DateTime.UtcNow.AddDays(7); }
			}

            /// <summary>
            /// 1 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeekFrom(DateTime date)
			{
				return date.AddDays(7);
			}

            /// <summary>
            /// 1 months from now
            /// </summary>
            /// <value>The month.</value>
            public static DateTime Month
			{
				get { return DateTime.UtcNow.AddMonths(1); }
			}

            /// <summary>
            /// 1 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthFrom(DateTime date)
			{
				return date.AddMonths(1);
			}

            /// <summary>
            /// 1 years from now
            /// </summary>
            /// <value>The year.</value>
            public static DateTime Year
			{
				get { return DateTime.UtcNow.AddYears(1); }
			}

            /// <summary>
            /// 1 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearFrom(DateTime date)
			{
				return date.AddYears(1);
			}
		}

        /// <summary>
        /// Class Two.
        /// </summary>
        public static class Two
		{
            /// <summary>
            /// 2 seconds from now
            /// </summary>
            /// <value>The seconds.</value>
            public static DateTime Seconds
			{
				get { return DateTime.UtcNow.AddSeconds(2); }
			}

            /// <summary>
            /// 2 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondsFrom(DateTime date)
			{
				return date.AddSeconds(2);
			}

            /// <summary>
            /// 2 minutes from now
            /// </summary>
            /// <value>The minutes.</value>
            public static DateTime Minutes
			{
				get { return DateTime.UtcNow.AddMinutes(2); }
			}

            /// <summary>
            /// 2 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinutesFrom(DateTime date)
			{
				return date.AddMinutes(2);
			}

            /// <summary>
            /// 2 hours from now
            /// </summary>
            /// <value>The hours.</value>
            public static DateTime Hours
			{
				get { return DateTime.UtcNow.AddHours(2); }
			}

            /// <summary>
            /// 2 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HoursFrom(DateTime date)
			{
				return date.AddHours(2);
			}

            /// <summary>
            /// 2 days from now
            /// </summary>
            /// <value>The days.</value>
            public static DateTime Days
			{
				get { return DateTime.UtcNow.AddDays(2); }
			}

            /// <summary>
            /// 2 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DaysFrom(DateTime date)
			{
				return date.AddDays(2);
			}

            /// <summary>
            /// 2 weeks from now
            /// </summary>
            /// <value>The weeks.</value>
            public static DateTime Weeks
			{
				get { return DateTime.UtcNow.AddDays(14); }
			}

            /// <summary>
            /// 2 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeeksFrom(DateTime date)
			{
				return date.AddDays(14);
			}

            /// <summary>
            /// 2 months from now
            /// </summary>
            /// <value>The months.</value>
            public static DateTime Months
			{
				get { return DateTime.UtcNow.AddMonths(2); }
			}

            /// <summary>
            /// 2 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthsFrom(DateTime date)
			{
				return date.AddMonths(2);
			}

            /// <summary>
            /// 2 years from now
            /// </summary>
            /// <value>The years.</value>
            public static DateTime Years
			{
				get { return DateTime.UtcNow.AddYears(2); }
			}

            /// <summary>
            /// 2 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearsFrom(DateTime date)
			{
				return date.AddYears(2);
			}
		}

        /// <summary>
        /// Class Three.
        /// </summary>
        public static class Three
		{
            /// <summary>
            /// 3 seconds from now
            /// </summary>
            /// <value>The seconds.</value>
            public static DateTime Seconds
			{
				get { return DateTime.UtcNow.AddSeconds(3); }
			}

            /// <summary>
            /// 3 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondsFrom(DateTime date)
			{
				return date.AddSeconds(3);
			}

            /// <summary>
            /// 3 minutes from now
            /// </summary>
            /// <value>The minutes.</value>
            public static DateTime Minutes
			{
				get { return DateTime.UtcNow.AddMinutes(3); }
			}

            /// <summary>
            /// 3 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinutesFrom(DateTime date)
			{
				return date.AddMinutes(3);
			}

            /// <summary>
            /// 3 hours from now
            /// </summary>
            /// <value>The hours.</value>
            public static DateTime Hours
			{
				get { return DateTime.UtcNow.AddHours(3); }
			}

            /// <summary>
            /// 3 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HoursFrom(DateTime date)
			{
				return date.AddHours(3);
			}

            /// <summary>
            /// 3 days from now
            /// </summary>
            /// <value>The days.</value>
            public static DateTime Days
			{
				get { return DateTime.UtcNow.AddDays(3); }
			}

            /// <summary>
            /// 3 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DaysFrom(DateTime date)
			{
				return date.AddDays(3);
			}

            /// <summary>
            /// 3 weeks from now
            /// </summary>
            /// <value>The weeks.</value>
            public static DateTime Weeks
			{
				get { return DateTime.UtcNow.AddDays(21); }
			}

            /// <summary>
            /// 3 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeeksFrom(DateTime date)
			{
				return date.AddDays(21);
			}

            /// <summary>
            /// 3 months from now
            /// </summary>
            /// <value>The months.</value>
            public static DateTime Months
			{
				get { return DateTime.UtcNow.AddMonths(3); }
			}

            /// <summary>
            /// 3 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthsFrom(DateTime date)
			{
				return date.AddMonths(3);
			}

            /// <summary>
            /// 3 years from now
            /// </summary>
            /// <value>The years.</value>
            public static DateTime Years
			{
				get { return DateTime.UtcNow.AddYears(3); }
			}

            /// <summary>
            /// 3 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearsFrom(DateTime date)
			{
				return date.AddYears(3);
			}
		}

        /// <summary>
        /// Class Four.
        /// </summary>
        public static class Four
		{
            /// <summary>
            /// 4 seconds from now
            /// </summary>
            /// <value>The seconds.</value>
            public static DateTime Seconds
			{
				get { return DateTime.UtcNow.AddSeconds(4); }
			}

            /// <summary>
            /// 4 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondsFrom(DateTime date)
			{
				return date.AddSeconds(4);
			}

            /// <summary>
            /// 4 minutes from now
            /// </summary>
            /// <value>The minutes.</value>
            public static DateTime Minutes
			{
				get { return DateTime.UtcNow.AddMinutes(4); }
			}

            /// <summary>
            /// 4 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinutesFrom(DateTime date)
			{
				return date.AddMinutes(4);
			}

            /// <summary>
            /// 4 hours from now
            /// </summary>
            /// <value>The hours.</value>
            public static DateTime Hours
			{
				get { return DateTime.UtcNow.AddHours(4); }
			}

            /// <summary>
            /// 4 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HoursFrom(DateTime date)
			{
				return date.AddHours(4);
			}

            /// <summary>
            /// 4 days from now
            /// </summary>
            /// <value>The days.</value>
            public static DateTime Days
			{
				get { return DateTime.UtcNow.AddDays(4); }
			}

            /// <summary>
            /// 4 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DaysFrom(DateTime date)
			{
				return date.AddDays(4);
			}

            /// <summary>
            /// 4 weeks from now
            /// </summary>
            /// <value>The weeks.</value>
            public static DateTime Weeks
			{
				get { return DateTime.UtcNow.AddDays(28); }
			}

            /// <summary>
            /// 4 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeeksFrom(DateTime date)
			{
				return date.AddDays(28);
			}

            /// <summary>
            /// 4 months from now
            /// </summary>
            /// <value>The months.</value>
            public static DateTime Months
			{
				get { return DateTime.UtcNow.AddMonths(4); }
			}

            /// <summary>
            /// 4 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthsFrom(DateTime date)
			{
				return date.AddMonths(4);
			}

            /// <summary>
            /// 4 years from now
            /// </summary>
            /// <value>The years.</value>
            public static DateTime Years
			{
				get { return DateTime.UtcNow.AddYears(4); }
			}

            /// <summary>
            /// 4 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearsFrom(DateTime date)
			{
				return date.AddYears(4);
			}
		}

        /// <summary>
        /// Class Five.
        /// </summary>
        public static class Five
		{
            /// <summary>
            /// 5 seconds from now
            /// </summary>
            /// <value>The seconds.</value>
            public static DateTime Seconds
			{
				get { return DateTime.UtcNow.AddSeconds(5); }
			}

            /// <summary>
            /// 5 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondsFrom(DateTime date)
			{
				return date.AddSeconds(5);
			}

            /// <summary>
            /// 5 minutes from now
            /// </summary>
            /// <value>The minutes.</value>
            public static DateTime Minutes
			{
				get { return DateTime.UtcNow.AddMinutes(5); }
			}

            /// <summary>
            /// 5 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinutesFrom(DateTime date)
			{
				return date.AddMinutes(5);
			}

            /// <summary>
            /// 5 hours from now
            /// </summary>
            /// <value>The hours.</value>
            public static DateTime Hours
			{
				get { return DateTime.UtcNow.AddHours(5); }
			}

            /// <summary>
            /// 5 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HoursFrom(DateTime date)
			{
				return date.AddHours(5);
			}

            /// <summary>
            /// 5 days from now
            /// </summary>
            /// <value>The days.</value>
            public static DateTime Days
			{
				get { return DateTime.UtcNow.AddDays(5); }
			}

            /// <summary>
            /// 5 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DaysFrom(DateTime date)
			{
				return date.AddDays(5);
			}

            /// <summary>
            /// 5 weeks from now
            /// </summary>
            /// <value>The weeks.</value>
            public static DateTime Weeks
			{
				get { return DateTime.UtcNow.AddDays(35); }
			}

            /// <summary>
            /// 5 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeeksFrom(DateTime date)
			{
				return date.AddDays(35);
			}

            /// <summary>
            /// 5 months from now
            /// </summary>
            /// <value>The months.</value>
            public static DateTime Months
			{
				get { return DateTime.UtcNow.AddMonths(5); }
			}

            /// <summary>
            /// 5 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthsFrom(DateTime date)
			{
				return date.AddMonths(5);
			}

            /// <summary>
            /// 5 years from now
            /// </summary>
            /// <value>The years.</value>
            public static DateTime Years
			{
				get { return DateTime.UtcNow.AddYears(5); }
			}

            /// <summary>
            /// 5 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearsFrom(DateTime date)
			{
				return date.AddYears(5);
			}
		}

        /// <summary>
        /// Class Six.
        /// </summary>
        public static class Six
		{
            /// <summary>
            /// 6 seconds from now
            /// </summary>
            /// <value>The seconds.</value>
            public static DateTime Seconds
			{
				get { return DateTime.UtcNow.AddSeconds(6); }
			}

            /// <summary>
            /// 6 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondsFrom(DateTime date)
			{
				return date.AddSeconds(6);
			}

            /// <summary>
            /// 6 minutes from now
            /// </summary>
            /// <value>The minutes.</value>
            public static DateTime Minutes
			{
				get { return DateTime.UtcNow.AddMinutes(6); }
			}

            /// <summary>
            /// 6 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinutesFrom(DateTime date)
			{
				return date.AddMinutes(6);
			}

            /// <summary>
            /// 6 hours from now
            /// </summary>
            /// <value>The hours.</value>
            public static DateTime Hours
			{
				get { return DateTime.UtcNow.AddHours(6); }
			}

            /// <summary>
            /// 6 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HoursFrom(DateTime date)
			{
				return date.AddHours(6);
			}

            /// <summary>
            /// 6 days from now
            /// </summary>
            /// <value>The days.</value>
            public static DateTime Days
			{
				get { return DateTime.UtcNow.AddDays(6); }
			}

            /// <summary>
            /// 6 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DaysFrom(DateTime date)
			{
				return date.AddDays(6);
			}

            /// <summary>
            /// 6 weeks from now
            /// </summary>
            /// <value>The weeks.</value>
            public static DateTime Weeks
			{
				get { return DateTime.UtcNow.AddDays(42); }
			}

            /// <summary>
            /// 6 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeeksFrom(DateTime date)
			{
				return date.AddDays(42);
			}

            /// <summary>
            /// 6 months from now
            /// </summary>
            /// <value>The months.</value>
            public static DateTime Months
			{
				get { return DateTime.UtcNow.AddMonths(6); }
			}

            /// <summary>
            /// 6 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthsFrom(DateTime date)
			{
				return date.AddMonths(6);
			}

            /// <summary>
            /// 6 years from now
            /// </summary>
            /// <value>The years.</value>
            public static DateTime Years
			{
				get { return DateTime.UtcNow.AddYears(6); }
			}

            /// <summary>
            /// 6 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearsFrom(DateTime date)
			{
				return date.AddYears(6);
			}
		}

        /// <summary>
        /// Class Seven.
        /// </summary>
        public static class Seven
		{
            /// <summary>
            /// 7 seconds from now
            /// </summary>
            /// <value>The seconds.</value>
            public static DateTime Seconds
			{
				get { return DateTime.UtcNow.AddSeconds(7); }
			}

            /// <summary>
            /// 7 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondsFrom(DateTime date)
			{
				return date.AddSeconds(7);
			}

            /// <summary>
            /// 7 minutes from now
            /// </summary>
            /// <value>The minutes.</value>
            public static DateTime Minutes
			{
				get { return DateTime.UtcNow.AddMinutes(7); }
			}

            /// <summary>
            /// 7 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinutesFrom(DateTime date)
			{
				return date.AddMinutes(7);
			}

            /// <summary>
            /// 7 hours from now
            /// </summary>
            /// <value>The hours.</value>
            public static DateTime Hours
			{
				get { return DateTime.UtcNow.AddHours(7); }
			}

            /// <summary>
            /// 7 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HoursFrom(DateTime date)
			{
				return date.AddHours(7);
			}

            /// <summary>
            /// 7 days from now
            /// </summary>
            /// <value>The days.</value>
            public static DateTime Days
			{
				get { return DateTime.UtcNow.AddDays(7); }
			}

            /// <summary>
            /// 7 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DaysFrom(DateTime date)
			{
				return date.AddDays(7);
			}

            /// <summary>
            /// 7 weeks from now
            /// </summary>
            /// <value>The weeks.</value>
            public static DateTime Weeks
			{
				get { return DateTime.UtcNow.AddDays(49); }
			}

            /// <summary>
            /// 7 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeeksFrom(DateTime date)
			{
				return date.AddDays(49);
			}

            /// <summary>
            /// 7 months from now
            /// </summary>
            /// <value>The months.</value>
            public static DateTime Months
			{
				get { return DateTime.UtcNow.AddMonths(7); }
			}

            /// <summary>
            /// 7 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthsFrom(DateTime date)
			{
				return date.AddMonths(7);
			}

            /// <summary>
            /// 7 years from now
            /// </summary>
            /// <value>The years.</value>
            public static DateTime Years
			{
				get { return DateTime.UtcNow.AddYears(7); }
			}

            /// <summary>
            /// 7 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearsFrom(DateTime date)
			{
				return date.AddYears(7);
			}
		}

        /// <summary>
        /// Class Eight.
        /// </summary>
        public static class Eight
		{
            /// <summary>
            /// 8 seconds from now
            /// </summary>
            /// <value>The seconds.</value>
            public static DateTime Seconds
			{
				get { return DateTime.UtcNow.AddSeconds(8); }
			}

            /// <summary>
            /// 8 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondsFrom(DateTime date)
			{
				return date.AddSeconds(8);
			}

            /// <summary>
            /// 8 minutes from now
            /// </summary>
            /// <value>The minutes.</value>
            public static DateTime Minutes
			{
				get { return DateTime.UtcNow.AddMinutes(8); }
			}

            /// <summary>
            /// 8 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinutesFrom(DateTime date)
			{
				return date.AddMinutes(8);
			}

            /// <summary>
            /// 8 hours from now
            /// </summary>
            /// <value>The hours.</value>
            public static DateTime Hours
			{
				get { return DateTime.UtcNow.AddHours(8); }
			}

            /// <summary>
            /// 8 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HoursFrom(DateTime date)
			{
				return date.AddHours(8);
			}

            /// <summary>
            /// 8 days from now
            /// </summary>
            /// <value>The days.</value>
            public static DateTime Days
			{
				get { return DateTime.UtcNow.AddDays(8); }
			}

            /// <summary>
            /// 8 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DaysFrom(DateTime date)
			{
				return date.AddDays(8);
			}

            /// <summary>
            /// 8 weeks from now
            /// </summary>
            /// <value>The weeks.</value>
            public static DateTime Weeks
			{
				get { return DateTime.UtcNow.AddDays(56); }
			}

            /// <summary>
            /// 8 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeeksFrom(DateTime date)
			{
				return date.AddDays(56);
			}

            /// <summary>
            /// 8 months from now
            /// </summary>
            /// <value>The months.</value>
            public static DateTime Months
			{
				get { return DateTime.UtcNow.AddMonths(8); }
			}

            /// <summary>
            /// 8 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthsFrom(DateTime date)
			{
				return date.AddMonths(8);
			}

            /// <summary>
            /// 8 years from now
            /// </summary>
            /// <value>The years.</value>
            public static DateTime Years
			{
				get { return DateTime.UtcNow.AddYears(8); }
			}

            /// <summary>
            /// 8 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearsFrom(DateTime date)
			{
				return date.AddYears(8);
			}
		}

        /// <summary>
        /// Class Nine.
        /// </summary>
        public static class Nine
		{
            /// <summary>
            /// 9 seconds from now
            /// </summary>
            /// <value>The seconds.</value>
            public static DateTime Seconds
			{
				get { return DateTime.UtcNow.AddSeconds(9); }
			}

            /// <summary>
            /// 9 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondsFrom(DateTime date)
			{
				return date.AddSeconds(9);
			}

            /// <summary>
            /// 9 minutes from now
            /// </summary>
            /// <value>The minutes.</value>
            public static DateTime Minutes
			{
				get { return DateTime.UtcNow.AddMinutes(9); }
			}

            /// <summary>
            /// 9 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinutesFrom(DateTime date)
			{
				return date.AddMinutes(9);
			}

            /// <summary>
            /// 9 hours from now
            /// </summary>
            /// <value>The hours.</value>
            public static DateTime Hours
			{
				get { return DateTime.UtcNow.AddHours(9); }
			}

            /// <summary>
            /// 9 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HoursFrom(DateTime date)
			{
				return date.AddHours(9);
			}

            /// <summary>
            /// 9 days from now
            /// </summary>
            /// <value>The days.</value>
            public static DateTime Days
			{
				get { return DateTime.UtcNow.AddDays(9); }
			}

            /// <summary>
            /// 9 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DaysFrom(DateTime date)
			{
				return date.AddDays(9);
			}

            /// <summary>
            /// 9 weeks from now
            /// </summary>
            /// <value>The weeks.</value>
            public static DateTime Weeks
			{
				get { return DateTime.UtcNow.AddDays(63); }
			}

            /// <summary>
            /// 9 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeeksFrom(DateTime date)
			{
				return date.AddDays(63);
			}

            /// <summary>
            /// 9 months from now
            /// </summary>
            /// <value>The months.</value>
            public static DateTime Months
			{
				get { return DateTime.UtcNow.AddMonths(9); }
			}

            /// <summary>
            /// 9 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthsFrom(DateTime date)
			{
				return date.AddMonths(9);
			}

            /// <summary>
            /// 9 years from now
            /// </summary>
            /// <value>The years.</value>
            public static DateTime Years
			{
				get { return DateTime.UtcNow.AddYears(9); }
			}

            /// <summary>
            /// 9 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearsFrom(DateTime date)
			{
				return date.AddYears(9);
			}
		}

        /// <summary>
        /// Class Ten.
        /// </summary>
        public static class Ten
		{
            /// <summary>
            /// 10 seconds from now
            /// </summary>
            /// <value>The seconds.</value>
            public static DateTime Seconds
			{
				get { return DateTime.UtcNow.AddSeconds(10); }
			}

            /// <summary>
            /// 10 seconds from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime SecondsFrom(DateTime date)
			{
				return date.AddSeconds(10);
			}

            /// <summary>
            /// 10 minutes from now
            /// </summary>
            /// <value>The minutes.</value>
            public static DateTime Minutes
			{
				get { return DateTime.UtcNow.AddMinutes(10); }
			}

            /// <summary>
            /// 10 minutes from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MinutesFrom(DateTime date)
			{
				return date.AddMinutes(10);
			}

            /// <summary>
            /// 10 hours from now
            /// </summary>
            /// <value>The hours.</value>
            public static DateTime Hours
			{
				get { return DateTime.UtcNow.AddHours(10); }
			}

            /// <summary>
            /// 10 hours from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime HoursFrom(DateTime date)
			{
				return date.AddHours(10);
			}

            /// <summary>
            /// 10 days from now
            /// </summary>
            /// <value>The days.</value>
            public static DateTime Days
			{
				get { return DateTime.UtcNow.AddDays(10); }
			}

            /// <summary>
            /// 10 days from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime DaysFrom(DateTime date)
			{
				return date.AddDays(10);
			}

            /// <summary>
            /// 10 weeks from now
            /// </summary>
            /// <value>The weeks.</value>
            public static DateTime Weeks
			{
				get { return DateTime.UtcNow.AddDays(70); }
			}

            /// <summary>
            /// 10 weeks from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime WeeksFrom(DateTime date)
			{
				return date.AddDays(70);
			}

            /// <summary>
            /// 10 months from now
            /// </summary>
            /// <value>The months.</value>
            public static DateTime Months
			{
				get { return DateTime.UtcNow.AddMonths(10); }
			}

            /// <summary>
            /// 10 months from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime MonthsFrom(DateTime date)
			{
				return date.AddMonths(10);
			}

            /// <summary>
            /// 10 years from now
            /// </summary>
            /// <value>The years.</value>
            public static DateTime Years
			{
				get { return DateTime.UtcNow.AddYears(10); }
			}

            /// <summary>
            /// 10 years from the provided date
            /// </summary>
            /// <param name="date">The date.</param>
            /// <returns>DateTime.</returns>
            public static DateTime YearsFrom(DateTime date)
			{
				return date.AddYears(10);
			}
		}
      }
}