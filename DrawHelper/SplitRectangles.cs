﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-25-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SplitRectangles.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace Zeroit.Framework.Utilities.GraphicsExtension.Drawing
{
    /// <summary>
    /// Description of Rectangle.
    /// </summary>
    public static partial class DrawRenderer
    {
        /// <summary>
        /// Percents the specified range.
        /// </summary>
        /// <param name="Range">The range.</param>
        /// <param name="Percent">The percent.</param>
        /// <returns>System.Double.</returns>
        private static double Percent(float Range, float Percent)
        {
            return System.Math.Ceiling(Range * Percent / 100);
        }
        /// <summary>
        /// Percents the specified range.
        /// </summary>
        /// <param name="Range">The range.</param>
        /// <param name="Percent">The percent.</param>
        /// <returns>System.Int32.</returns>
        private static int Percent(int Range, int Percent)
        {
            return (int)DrawRenderer.Percent((float)Range, (float)Percent);
        }
        /// <summary>
        /// Middles the point.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <returns>Point.</returns>
        public static Point MiddlePoint(Rectangle xRec)
		{
            return new Point(xRec.Left + (int)((float)xRec.Width / 2), xRec.Top + (int)((float)xRec.Height / 2));
		}

        /// <summary>
        /// Enum SplitType
        /// </summary>
        public enum SplitType{Horizontal,Vertical};

        /// <summary>
        /// Splits the horizontal by percent.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <param name="Percents">The percents.</param>
        /// <returns>Rectangle[].</returns>
        private static Rectangle[] SplitHorizontalByPercent(Rectangle xRec, int[] Percents)
        {
            if(Percents.Length<1)
                return new Rectangle[] { xRec };
            Rectangle[] xOut = new Rectangle[Percents.Length];
            xOut[0].X = xRec.X;
            xOut[0].Y = xRec.Y;
            xOut[0].Width = Percent(xRec.Width, Percents[0]);
            xOut[0].Height = xRec.Height;
            for (int i = 1; i < xOut.Length; i++)
            {
                xOut[i].X = xOut[i-1].Right;
                xOut[i].Y = xRec.Y;
                xOut[i].Width = Percent(xRec.Width, Percents[i]);
                xOut[i].Height = xRec.Height;
            }
            return xOut;
        }
        /// <summary>
        /// Splits the horizontal by pixels.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <param name="Pixels">The pixels.</param>
        /// <returns>Rectangle[].</returns>
        private static Rectangle[] SplitHorizontalByPixels(Rectangle xRec, int[] Pixels)
        {
            if (Pixels.Length < 1)
                return new Rectangle[] { xRec };
            Rectangle[] xOut = new Rectangle[Pixels.Length];
            xOut[0].X = xRec.X;
            xOut[0].Y = xRec.Y;
            xOut[0].Width = Pixels[0];
            xOut[0].Height = xRec.Height;
            for (int i = 1; i < xOut.Length; i++)
            {
                xOut[i].X = xOut[i - 1].Right;
                xOut[i].Y = xRec.Y;
                xOut[i].Width = Pixels[i];
                xOut[i].Height = xRec.Height;
            }
            return xOut;
        }
        /// <summary>
        /// Splits the horizontal in parts.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <param name="Parts">The parts.</param>
        /// <returns>Rectangle[].</returns>
        private static Rectangle[] SplitHorizontalInParts(Rectangle xRec, int Parts)
        {
            if (Parts<2)
                return new Rectangle[] { xRec };
            Rectangle[] xOut = new Rectangle[Parts];
            int PartWidth =(int)System.Math.Ceiling((float)xRec.Width / Parts);
            xOut[0].X = xRec.X;
            xOut[0].Y = xRec.Y;
            xOut[0].Width = PartWidth;
            xOut[0].Height = xRec.Height;
            for (int i = 1; i < Parts; i++)
            {
                xOut[i].X = xOut[i - 1].Right;
                xOut[i].Y = xRec.Y;
                xOut[i].Width = PartWidth;
                xOut[i].Height = xRec.Height;
            }
            if (xOut[Parts - 1].Right != xRec.Right)
                xOut[Parts - 1].Width = xRec.Right - xOut[Parts - 1].X;
            return xOut;
        }

        /// <summary>
        /// Splits the by percent.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <param name="Percents">The percents.</param>
        /// <param name="xSplitType">Type of the x split.</param>
        /// <returns>Rectangle[].</returns>
        public static Rectangle[] SplitByPercent(Rectangle xRec, int[] Percents, SplitType xSplitType)
        {
            Rectangle[] xOutput = null;
            switch (xSplitType)
            {
                case SplitType.Horizontal:
                    xOutput = SplitHorizontalByPercent(xRec, Percents);
                    break;
                case SplitType.Vertical:
                    break;
            }
            return xOutput;
        }
        /// <summary>
        /// Splits the by pixels.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <param name="Pixels">The pixels.</param>
        /// <param name="xSplitType">Type of the x split.</param>
        /// <returns>Rectangle[].</returns>
        public static Rectangle[] SplitByPixels(Rectangle xRec, int[] Pixels, SplitType xSplitType)
        {
            Rectangle[] xOutput = null;
            switch (xSplitType)
            {
                case SplitType.Horizontal:
                    xOutput = SplitHorizontalByPixels(xRec, Pixels);
                    break;
                case SplitType.Vertical:
                    break;
            }
            return xOutput;
        }
        /// <summary>
        /// Splits the in parts.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <param name="Parts">The parts.</param>
        /// <param name="xSplitType">Type of the x split.</param>
        /// <returns>Rectangle[].</returns>
        public static Rectangle[] SplitInParts(Rectangle xRec, int Parts, SplitType xSplitType)
        {
            Rectangle[] xOutput = null;
            switch (xSplitType)
            {
                case SplitType.Horizontal:
                    xOutput = SplitHorizontalInParts(xRec, Parts);
                    break;
                case SplitType.Vertical:
                    break;
            }
            return xOutput;
        }

        /// <summary>
        /// Pathes the around.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <returns>Point[].</returns>
        public static Point[] PathAround(Rectangle xRec)
        {
            Point[] xPath = new Point[5];
            xPath[0] = new Point(xRec.Left, xRec.Top);
            xPath[1] = new Point(xRec.Right-1, xRec.Top);
            xPath[2] = new Point(xRec.Right-1, xRec.Bottom-1);
            xPath[3] = new Point(xRec.Left, xRec.Bottom-1);
            xPath[4] = new Point(xRec.Left, xRec.Top);
            return xPath;
        }

        /// <summary>
        /// Moves the specified x record.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <param name="Horizontal">The horizontal.</param>
        /// <param name="Vertical">The vertical.</param>
        /// <returns>Rectangle.</returns>
        public static Rectangle Move(Rectangle xRec, int Horizontal, int Vertical)
        {
            xRec.Width += Horizontal;
            xRec.Height += Vertical;
            return xRec;
        }

        /// <summary>
        /// Resizes the specified x record.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <param name="DifferenceW">The difference w.</param>
        /// <param name="DifferenceH">The difference h.</param>
        /// <returns>Rectangle.</returns>
        public static Rectangle Resize(Rectangle xRec, int DifferenceW, int DifferenceH)
        {
            Rectangle xNew = xRec;
            xNew.X -= DifferenceW;
            xNew.Y -= DifferenceH;
            xNew.Width += DifferenceW * 2;
            xNew.Height += DifferenceH * 2;
            return xNew;
        }
        /// <summary>
        /// Resizes the specified x record.
        /// </summary>
        /// <param name="xRec">The x record.</param>
        /// <param name="Difference">The difference.</param>
        /// <returns>Rectangle.</returns>
        public static Rectangle Resize(Rectangle xRec, int Difference)
        {
            return Resize(xRec, Difference, Difference);
        }

        /// <summary>
        /// Joins the specified x rec1.
        /// </summary>
        /// <param name="xRec1">The x rec1.</param>
        /// <param name="xRec2">The x rec2.</param>
        /// <returns>Rectangle.</returns>
        public static Rectangle Join(Rectangle xRec1, Rectangle xRec2)
        {
            Rectangle xOut=new Rectangle();
            xOut.X=xRec1.X<xRec2.X?xRec1.X:xRec2.X;
            xOut.Y = xRec1.Y < xRec2.Y ? xRec1.Y : xRec2.Y;
            int Right=xRec1.Right>xRec2.Right?xRec1.Right:xRec2.Right;
            int Bottom=xRec1.Bottom>xRec2.Bottom?xRec1.Bottom:xRec2.Bottom;
            xOut.Width = Right - xOut.X;
            xOut.Height = Bottom - xOut.Y;

            return xOut;
        }


	}
}