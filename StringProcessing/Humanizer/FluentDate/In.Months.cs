﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 06-14-2018
// ***********************************************************************
// <copyright file="In.Months.cs" company="Zeroit Dev Technologies">
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
        /// Returns 1st of January of the current year
        /// </summary>
        /// <value>The january.</value>
        public static DateTime January
		{
			get { return new DateTime(DateTime.UtcNow.Year, 1, 1); }
		}

        /// <summary>
        /// Returns 1st of January of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime JanuaryOf(int year)
		{
			return new DateTime(year, 1, 1);
		}

        /// <summary>
        /// Returns 1st of February of the current year
        /// </summary>
        /// <value>The february.</value>
        public static DateTime February
		{
			get { return new DateTime(DateTime.UtcNow.Year, 2, 1); }
		}

        /// <summary>
        /// Returns 1st of February of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime FebruaryOf(int year)
		{
			return new DateTime(year, 2, 1);
		}

        /// <summary>
        /// Returns 1st of March of the current year
        /// </summary>
        /// <value>The march.</value>
        public static DateTime March
		{
			get { return new DateTime(DateTime.UtcNow.Year, 3, 1); }
		}

        /// <summary>
        /// Returns 1st of March of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime MarchOf(int year)
		{
			return new DateTime(year, 3, 1);
		}

        /// <summary>
        /// Returns 1st of April of the current year
        /// </summary>
        /// <value>The april.</value>
        public static DateTime April
		{
			get { return new DateTime(DateTime.UtcNow.Year, 4, 1); }
		}

        /// <summary>
        /// Returns 1st of April of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime AprilOf(int year)
		{
			return new DateTime(year, 4, 1);
		}

        /// <summary>
        /// Returns 1st of May of the current year
        /// </summary>
        /// <value>The may.</value>
        public static DateTime May
		{
			get { return new DateTime(DateTime.UtcNow.Year, 5, 1); }
		}

        /// <summary>
        /// Returns 1st of May of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime MayOf(int year)
		{
			return new DateTime(year, 5, 1);
		}

        /// <summary>
        /// Returns 1st of June of the current year
        /// </summary>
        /// <value>The june.</value>
        public static DateTime June
		{
			get { return new DateTime(DateTime.UtcNow.Year, 6, 1); }
		}

        /// <summary>
        /// Returns 1st of June of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime JuneOf(int year)
		{
			return new DateTime(year, 6, 1);
		}

        /// <summary>
        /// Returns 1st of July of the current year
        /// </summary>
        /// <value>The july.</value>
        public static DateTime July
		{
			get { return new DateTime(DateTime.UtcNow.Year, 7, 1); }
		}

        /// <summary>
        /// Returns 1st of July of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime JulyOf(int year)
		{
			return new DateTime(year, 7, 1);
		}

        /// <summary>
        /// Returns 1st of August of the current year
        /// </summary>
        /// <value>The august.</value>
        public static DateTime August
		{
			get { return new DateTime(DateTime.UtcNow.Year, 8, 1); }
		}

        /// <summary>
        /// Returns 1st of August of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime AugustOf(int year)
		{
			return new DateTime(year, 8, 1);
		}

        /// <summary>
        /// Returns 1st of September of the current year
        /// </summary>
        /// <value>The september.</value>
        public static DateTime September
		{
			get { return new DateTime(DateTime.UtcNow.Year, 9, 1); }
		}

        /// <summary>
        /// Returns 1st of September of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime SeptemberOf(int year)
		{
			return new DateTime(year, 9, 1);
		}

        /// <summary>
        /// Returns 1st of October of the current year
        /// </summary>
        /// <value>The october.</value>
        public static DateTime October
		{
			get { return new DateTime(DateTime.UtcNow.Year, 10, 1); }
		}

        /// <summary>
        /// Returns 1st of October of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime OctoberOf(int year)
		{
			return new DateTime(year, 10, 1);
		}

        /// <summary>
        /// Returns 1st of November of the current year
        /// </summary>
        /// <value>The november.</value>
        public static DateTime November
		{
			get { return new DateTime(DateTime.UtcNow.Year, 11, 1); }
		}

        /// <summary>
        /// Returns 1st of November of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime NovemberOf(int year)
		{
			return new DateTime(year, 11, 1);
		}

        /// <summary>
        /// Returns 1st of December of the current year
        /// </summary>
        /// <value>The december.</value>
        public static DateTime December
		{
			get { return new DateTime(DateTime.UtcNow.Year, 12, 1); }
		}

        /// <summary>
        /// Returns 1st of December of the year passed in
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>DateTime.</returns>
        public static DateTime DecemberOf(int year)
		{
			return new DateTime(year, 12, 1);
		}
      }
}