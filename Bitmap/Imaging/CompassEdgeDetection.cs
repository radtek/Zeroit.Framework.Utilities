﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CompassEdgeDetection.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/

using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.Utilities.BitmapUtils.Imaging
{
    /// <summary>
    /// A class collection for compass edge detection
    /// </summary>
    public static class CompassEdgeDetection
    {
        /// <summary>
        /// Copy to canvas
        /// </summary>
        /// <param name="sourceBitmap">Set source Bitmap</param>
        /// <param name="canvasWidthLenght">Set canvas Width and Length</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap CopyToSquareCanvas(this System.Drawing.Bitmap sourceBitmap, int canvasWidthLenght)
        {
            float ratio = 1.0f;
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ?
                          sourceBitmap.Width : sourceBitmap.Height;

            ratio = (float)maxSide / (float)canvasWidthLenght;

            System.Drawing.Bitmap bitmapResult = (sourceBitmap.Width > sourceBitmap.Height ?
                                    new System.Drawing.Bitmap(canvasWidthLenght, (int)(sourceBitmap.Height / ratio))
                                    : new System.Drawing.Bitmap((int)(sourceBitmap.Width / ratio), canvasWidthLenght));

            using (System.Drawing.Graphics graphicsResult = System.Drawing.Graphics.FromImage(bitmapResult))
            {
                graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
                graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

                graphicsResult.DrawImage(sourceBitmap,
                                        new Rectangle(0, 0,
                                            bitmapResult.Width, bitmapResult.Height),
                                        new Rectangle(0, 0,
                                            sourceBitmap.Width, sourceBitmap.Height),
                                            GraphicsUnit.Pixel);
                graphicsResult.Flush();
            }

            return bitmapResult;
        }

        /// <summary>
        /// Compass Edge Detection Filter
        /// </summary>
        /// <param name="sourceBitmap">Set source Bitmap</param>
        /// <param name="compassType">Set type</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap CompassEdgeDetectionFilter(this System.Drawing.Bitmap sourceBitmap, 
                                            CompassEdgeDetectionType compassType)
        {
            System.Drawing.Bitmap resultBitmap = null;

            switch (compassType)
            {
                case CompassEdgeDetectionType.Sobel3x3x4:
                    {
                        resultBitmap = 
                        sourceBitmap.ConvolutionFilter(Matrix.Sobel3x3x4, 1.0 / 4.0);
                    } break;
                case CompassEdgeDetectionType.Sobel3x3x8:
                    {
                        resultBitmap = 
                        sourceBitmap.ConvolutionFilter(Matrix.Sobel3x3x8, 1.0/ 4.0);
                    } break;
                case CompassEdgeDetectionType.Sobel5x5x4:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Sobel5x5x4, 1.0/ 84.0);
                    } break;
                case CompassEdgeDetectionType.Prewitt3x3x4:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Prewitt3x3x4, 1.0 / 3.0);
                    } break;
                case CompassEdgeDetectionType.Prewitt3x3x8:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Prewitt3x3x8, 1.0/ 3.0);
                    } break;
                case CompassEdgeDetectionType.Prewitt5x5x4:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Prewitt5x5x4, 1.0 / 15.0);
                    } break;
                case CompassEdgeDetectionType.Scharr3x3x4:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Scharr3x3x4, 1.0 / 4.0);
                    } break;
                case CompassEdgeDetectionType.Scharr3x3x8:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Scharr3x3x8, 1.0 / 4.0);
                    } break;
                case CompassEdgeDetectionType.Scharr5x5x4:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Scharr5x5x4, 1.0 / 21.0);
                    } break;
                case CompassEdgeDetectionType.Kirsch3x3x4:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Kirsch3x3x4, 1.0 / 15.0);
                    } break;
                case CompassEdgeDetectionType.Kirsch3x3x8:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Kirsch3x3x8, 1.0 / 15.0);
                    } break;
                case CompassEdgeDetectionType.Isotropic3x3x4:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Isotropic3x3x4, 1.0 / 3.4);
                    } break;
                case CompassEdgeDetectionType.Isotropic3x3x8:
                    {
                        resultBitmap =
                        sourceBitmap.ConvolutionFilter(Matrix.Isotropic3x3x8, 1.0 / 3.4);
                    } break;
            }

            return resultBitmap;
        }
            
        /// <summary>
        /// Convolution Filter
        /// </summary>
        /// <param name="sourceBitmap">Set source Bitmap</param>
        /// <param name="filterMatrix">Set Filter Matrix</param>
        /// <param name="factor">Set factor</param>
        /// <param name="bias">Set bias</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap ConvolutionFilter(this System.Drawing.Bitmap sourceBitmap, 
                                             double[,,] filterMatrix, 
                                                  double factor = 1, 
                                                       int bias = 0) 
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                                       ImageLockMode.ReadOnly, 
                                                 PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            double blueCompass = 0.0;
            double greenCompass = 0.0;
            double redCompass = 0.0;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);

            int filterOffset = (filterWidth-1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY < 
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < 
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = offsetY * 
                                 sourceData.Stride + 
                                 offsetX * 4;

                    for (int compass = 0; compass < 
                         filterMatrix.GetLength(0); compass++)
                    {

                        blueCompass = 0.0;
                        greenCompass = 0.0;
                        redCompass = 0.0;

                        for (int filterY = -filterOffset;
                            filterY <= filterOffset; filterY++)
                        {
                            for (int filterX = -filterOffset;
                                filterX <= filterOffset; filterX++)
                            {
                               

                                calcOffset = byteOffset +
                                             (filterX * 4) +
                                             (filterY * sourceData.Stride);


                                blueCompass += (double)(pixelBuffer[calcOffset]) *
                                                filterMatrix[compass,
                                                filterY + filterOffset,
                                                filterX + filterOffset];

                                greenCompass += (double)(pixelBuffer[calcOffset + 1]) *
                                                filterMatrix[compass,
                                                filterY + filterOffset,
                                                filterX + filterOffset];

                                redCompass += (double)(pixelBuffer[calcOffset + 2]) *
                                                filterMatrix[compass,
                                                filterY + filterOffset,
                                                filterX + filterOffset];
                            }
                        }

                        blue = (blueCompass > blue ? blueCompass : blue);
                        green = (greenCompass > green ? greenCompass : green);
                        red = (redCompass > red ? redCompass : red);
                    }

                    blue = factor * blue + bias;
                    green = factor * green + bias;
                    red = factor * red + bias;

                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }

                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }

                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }

                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            System.Drawing.Bitmap resultBitmap = new System.Drawing.Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                                      ImageLockMode.WriteOnly,
                                                 PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        /// <summary>
        /// Compass Edge Detection Type
        /// </summary>
        public enum CompassEdgeDetectionType
        {
            None,
            Sobel3x3x4,
            Sobel3x3x8,
            Sobel5x5x4,
            Prewitt3x3x4,
            Prewitt3x3x8,
            Prewitt5x5x4,
            Scharr3x3x4,
            Scharr3x3x8,
            Scharr5x5x4,
            Kirsch3x3x4,
            Kirsch3x3x8,
            Isotropic3x3x4,
            Isotropic3x3x8,
        }
    }  
}
