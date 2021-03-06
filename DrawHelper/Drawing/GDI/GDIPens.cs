// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-23-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-23-2018
// ***********************************************************************
// <copyright file="GDIPens.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using Zeroit.Framework.Utilities.Win32;

namespace Zeroit.Framework.Utilities.GraphicsExtension.Drawing.GDI
{
    /// <summary>
    /// Class GDIPen.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Utilities.GraphicsExtension.Drawing.GDI.GDIObject" />
    public class GDIPen : GDIObject
	{
        /// <summary>
        /// The h pen
        /// </summary>
        public IntPtr hPen;

        /// <summary>
        /// Initializes a new instance of the <see cref="GDIPen"/> class.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="width">The width.</param>
        public GDIPen(Color color, int width)
		{
            hPen = NativeGdi32Api.CreatePen(0, width, NativeUser32Api.ColorToInt(color));
			Create();
		}

        /// <summary>
        /// Destroys this instance.
        /// </summary>
        protected override void Destroy()
		{
			if (hPen != (IntPtr) 0)
                NativeGdi32Api.DeleteObject(hPen);
			base.Destroy();
			hPen = (IntPtr) 0;
		}

        /// <summary>
        /// Creates this instance.
        /// </summary>
        protected override void Create()
		{
			base.Create();
		}
	}
}