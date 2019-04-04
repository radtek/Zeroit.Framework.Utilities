﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CBitOps.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Imaging;

namespace Zeroit.Framework.Utilities.BitmapUtils
{
    /// <summary>
    /// Class for Bitmap operations
    /// </summary>
    public class CBitmapOps
    {
        /// <summary>
        /// Execute bit operations for Bitmap
        /// </summary>
        /// <param name="m1">First bitmap to use</param>
        /// <param name="m2">Second bitmap to use</param>
        /// <param name="ops">String operations</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap DoBitOpsForBitmap(System.Drawing.Bitmap m1, System.Drawing.Bitmap m2, string ops)
        {
            //assuming m1 and m2 are same width and height
            //direct bit manipulation

            //get the max size, fill default white
            int m3h, m3w;
            m3h = (m1.Height > m2.Height ? m1.Height : m2.Height);
            m3w = (m1.Width > m2.Width ? m1.Width : m2.Width);

            System.Drawing.Bitmap m3 = new System.Drawing.Bitmap(m3w, m3h, m1.PixelFormat);
            System.Drawing.Graphics.FromImage(m3).FillRectangle(new SolidBrush(Color.White), 0, 0, m3w, m3h);

            Rectangle rect1 = new Rectangle(0, 0, m1.Width, m1.Height);
            Rectangle rect2 = new Rectangle(0, 0, m2.Width, m2.Height);
            Rectangle rect3 = new Rectangle(0, 0, m3.Width, m3.Height);

            BitmapData bmpData1 =
                     m1.LockBits(rect1, ImageLockMode.ReadOnly,
                     m1.PixelFormat);
            BitmapData bmpData2 =
                     m2.LockBits(rect2, ImageLockMode.ReadOnly,
                     m2.PixelFormat);
            BitmapData bmpData3 =
                     m3.LockBits(rect3, ImageLockMode.ReadWrite,
                     m3.PixelFormat);
            IntPtr ptr1 = bmpData1.Scan0;
            IntPtr ptr2 = bmpData2.Scan0;
            IntPtr ptr3 = bmpData3.Scan0;

            int bytes1 = m1.Width * m1.Height * 4;
            int bytes2 = m2.Width * m2.Height * 4;
            int bytes3 = m3.Width * m3.Height * 4;

            byte[] rgbValues1 = new byte[bytes1];
            byte[] rgbValues2 = new byte[bytes2];
            byte[] rgbValues3 = new byte[bytes3];



            //byte r = 0, g = 0, b = 0;
            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr1, rgbValues1, 0, bytes1);
            System.Runtime.InteropServices.Marshal.Copy(ptr2, rgbValues2, 0, bytes2);
            System.Runtime.InteropServices.Marshal.Copy(ptr3, rgbValues3, 0, bytes3);
            /*
            if(ops.Equals("xor"))
            for (int j = 0; j < m1.Height; j++)
                for (int i = 0; i < m1.Width; i++)
                {

                    int index = CoordsToIndex(i, j, bmpData1.Stride);
                    rgbValues3[index] = (byte)((int)rgbValues1[index] ^ (int)rgbValues2[index]);
                    rgbValues3[index + 1] = (byte)((int)rgbValues1[index+1] ^ (int)rgbValues2[index+1]); 
                    rgbValues3[index + 2] = (byte)((int)rgbValues1[index+2] ^ (int)rgbValues2[index+2]);
                    rgbValues3[index + 3] = (byte)((int)rgbValues1[index + 3]) ; 
                }
            */
            //  if (ops.Equals("AND"))
            //  {
            for (int j = 0; j < m1.Height; j++)
                for (int i = 0; i < m1.Width; i++)
                {

                    int index = CoordsToIndex(i, j, bmpData1.Stride);
                    int index3 = CoordsToIndex(i, j, bmpData3.Stride);

                    rgbValues3[index3] = rgbValues1[index];
                    rgbValues3[index3 + 1] = rgbValues1[index + 1];
                    rgbValues3[index3 + 2] = rgbValues1[index + 2];
                    rgbValues3[index3 + 3] = rgbValues1[index + 3];
                }

            for (int j = 0; j < m2.Height; j++)
                for (int i = 0; i < m2.Width; i++)
                {

                    int index = CoordsToIndex(i, j, bmpData2.Stride);
                    int index3 = CoordsToIndex(i, j, bmpData3.Stride);

                    switch (ops)
                    {
                        case "AND":
                            rgbValues3[index3] = (byte)((int)rgbValues3[index3] & (int)rgbValues2[index]);
                            rgbValues3[index3 + 1] = (byte)((int)rgbValues3[index3 + 1] & (int)rgbValues2[index + 1]);
                            rgbValues3[index3 + 2] = (byte)((int)rgbValues3[index3 + 2] & (int)rgbValues2[index + 2]);
                            rgbValues3[index3 + 3] = (byte)((int)rgbValues2[index + 3]);
                            break;
                        case "OR":
                            rgbValues3[index3] = (byte)((int)rgbValues3[index3] | (int)rgbValues2[index]);
                            rgbValues3[index3 + 1] = (byte)((int)rgbValues3[index3 + 1] | (int)rgbValues2[index + 1]);
                            rgbValues3[index3 + 2] = (byte)((int)rgbValues3[index3 + 2] | (int)rgbValues2[index + 2]);
                            rgbValues3[index3 + 3] = (byte)((int)rgbValues2[index + 3]);
                            break;


                    }
                }


            // }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues3, 0, ptr3, bytes3);
            // Unlock the bits.
            m1.UnlockBits(bmpData1);
            m2.UnlockBits(bmpData2);
            m3.UnlockBits(bmpData3);
            return m3;
        }

        //for argb color pixel format
        private static int CoordsToIndex(int x, int y, int stride)
        {
            return (stride * y) + (x * 4);
        }

        /// <summary>
        /// Invert Bitmap
        /// </summary>
        /// <param name="bm">Bitmap to use</param>
        public static void DoInvertBitmap(System.Drawing.Bitmap bm)
        {
            //direct bit manipulation
            Rectangle rect = new Rectangle(0, 0, bm.Width, bm.Height);
            BitmapData bmpData =
                     bm.LockBits(rect, ImageLockMode.ReadWrite,
                     bm.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int bytes = bm.Width * bm.Height * 4;
            byte[] rgbValues = new byte[bytes];
            //byte r = 0, g = 0, b = 0;
            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);


            for (int j = 0; j < bm.Height; j++)
                for (int i = 0; i < bm.Width; i++)
                {

                    int index = CoordsToIndex(i, j, bmpData.Stride);
                    rgbValues[index] = (byte)(255 - rgbValues[index]);
                    rgbValues[index + 1] = (byte)(255 - rgbValues[index + 1]);
                    rgbValues[index + 2] = (byte)(255 - rgbValues[index + 2]);


                }
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            // Unlock the bits.
            bm.UnlockBits(bmpData);

        }

    }
}
