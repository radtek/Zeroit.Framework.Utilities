﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BitmapFiltersColorMatrix.cs" company="Zeroit Dev Technologies">
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
/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Zeroit.Framework.Utilities.BitmapUtils.Imaging
{
    /// <summary>
    /// A class for Bitmap Filters
    /// </summary>
    public static class BitmapFiltersColorMatrix
    {
        /// <summary>
        /// Get ARGB
        /// </summary>
        /// <param name="sourceImage">Set source bitmap</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap GetArgbCopy(Image sourceImage)
        {
            System.Drawing.Bitmap bmpNew = new System.Drawing.Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format32bppArgb);

            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bmpNew))
            {
                graphics.DrawImage(sourceImage, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }

            return bmpNew;
        }

        /// <summary>
        /// Apply Color Matrix
        /// </summary>
        /// <param name="sourceImage">Set source bitmap</param>
        /// <param name="colorMatrix">Set Color Matrix</param>
        /// <returns>Bitmap</returns>
        public static System.Drawing.Bitmap ApplyColorMatrix(Image sourceImage, ColorMatrix colorMatrix)
        {
            System.Drawing.Bitmap bmp32BppSource = GetArgbCopy(sourceImage);
            System.Drawing.Bitmap bmp32BppDest = new System.Drawing.Bitmap(bmp32BppSource.Width, bmp32BppSource.Height, PixelFormat.Format32bppArgb);

            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bmp32BppDest))
            {
                ImageAttributes bmpAttributes = new ImageAttributes();
                bmpAttributes.SetColorMatrix(colorMatrix);

                graphics.DrawImage(bmp32BppSource, new Rectangle(0, 0, bmp32BppSource.Width, bmp32BppSource.Height),
                                 0, 0, bmp32BppSource.Width, bmp32BppSource.Height, GraphicsUnit.Pixel, bmpAttributes);

            }

            bmp32BppSource.Dispose();

            return bmp32BppDest;
        }

        /// <summary>
        /// Copy With Transparency
        /// </summary>
        /// <param name="sourceImage">Set source Image</param>
        /// <param name="alphaComponent">Set Alpha</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap CopyWithTransparency(this Image sourceImage, byte alphaComponent = 100)
        {
            System.Drawing.Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            for (int k = 3; k < byteBuffer.Length; k += 4)
            {
                byteBuffer[k] = alphaComponent;
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }

        /// <summary>
        /// Draw With Transparency
        /// </summary>
        /// <param name="sourceImage">Set source Bitmap</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap DrawWithTransparency(this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] 
                                                {
                                                    new float[] {1, 0, 0, 0, 0},
                                                    new float[] {0, 1, 0, 0, 0},
                                                    new float[] {0, 0, 1, 0, 0},
                                                    new float[] {0, 0, 0, 0.3f, 0},
                                                    new float[] {0, 0, 0, 0, 1}
                                                });
            
            return ApplyColorMatrix(sourceImage, colorMatrix);
        }

        /// <summary>
        /// Copy as Negative
        /// </summary>
        /// <param name="sourceImage">Set source Bitmap</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap CopyAsNegative(this Image sourceImage)
        {
            System.Drawing.Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);
            byte[] pixelBuffer = null;

            int pixel = 0;

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                pixel = ~BitConverter.ToInt32(byteBuffer, k);
                pixelBuffer = BitConverter.GetBytes(pixel);

                byteBuffer[k] = pixelBuffer[0];
                byteBuffer[k + 1] = pixelBuffer[1];
                byteBuffer[k + 2] = pixelBuffer[2];
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }

        /// <summary>
        /// Draw as Negative
        /// </summary>
        /// <param name="sourceImage">Set source Bitmap</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap DrawAsNegative(this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] 
                                                {
                                                    new float[] {-1, 0, 0, 0, 0},
                                                    new float[] {0, -1, 0, 0, 0},
                                                    new float[] {0, 0, -1, 0, 0},
                                                    new float[] {0, 0, 0, 1, 0},
                                                    new float[] {1, 1, 1, 1, 1}
                                                });

            return ApplyColorMatrix(sourceImage, colorMatrix);
        }

        /// <summary>
        /// Copy as Grayscale
        /// </summary>
        /// <param name="sourceImage">Set source Bitmap</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap CopyAsGrayscale(this Image sourceImage)
        {
            System.Drawing.Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            System.Runtime.InteropServices.Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            float rgb = 0;

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                rgb = byteBuffer[k] * 0.11f;
                rgb += byteBuffer[k+1] * 0.59f;
                rgb += byteBuffer[k+2] * 0.3f;

                byteBuffer[k] = (byte)rgb;
                byteBuffer[k + 1] = byteBuffer[k];
                byteBuffer[k + 2] = byteBuffer[k];

                byteBuffer[k + 3] = 255;
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }

        /// <summary>
        /// Draw as Grayscale
        /// </summary>
        /// <param name="sourceImage">Set source Bitmap</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap DrawAsGrayscale(this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] 
                                                {
                                                    new float[] {.3f, .3f, .3f, 0, 0},
                                                    new float[] {.59f, .59f, .59f, 0, 0},
                                                    new float[] {.11f, .11f, .11f, 0, 0},
                                                    new float[] {0, 0, 0, 1, 0},
                                                    new float[] {0, 0, 0, 0, 1}
                                                });

            return ApplyColorMatrix(sourceImage, colorMatrix);
        }

        /// <summary>
        /// Copy as Sepia Tone
        /// </summary>
        /// <param name="sourceImage">Set source Bitmap</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap CopyAsSepiaTone(this Image sourceImage)
        {
            System.Drawing.Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            byte maxValue = 255;
            float r = 0;
            float g = 0;
            float b = 0;

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                r = byteBuffer[k] * 0.189f + byteBuffer[k + 1] * 0.769f + byteBuffer[k + 2] * 0.393f;
                g = byteBuffer[k] * 0.168f + byteBuffer[k + 1] * 0.686f + byteBuffer[k + 2] * 0.349f;
                b = byteBuffer[k] * 0.131f + byteBuffer[k + 1] * 0.534f + byteBuffer[k + 2] * 0.272f;

                byteBuffer[k+2] = (r > maxValue ? maxValue : (byte)r);
                byteBuffer[k + 1] = (g > maxValue ? maxValue : (byte)g);
                byteBuffer[k] = (b > maxValue ? maxValue : (byte)b);
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }

        /// <summary>
        /// Draw as Grayscale
        /// </summary>
        /// <param name="sourceImage">Set source Bitmap</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap DrawAsSepiaTone(this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] 
                                                {
                                                    new float[] {.393f, .349f, .272f, 0, 0},
                                                    new float[] {.769f, .686f, .534f, 0, 0},
                                                    new float[] {.189f, .168f, .131f, 0, 0},
                                                    new float[] {0, 0, 0, 1, 0},
                                                    new float[] {0, 0, 0, 0, 1}
                                                });

            return ApplyColorMatrix(sourceImage, colorMatrix);
        }
    }
}
