// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-23-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PixelBufferManagedRenderer.cs" company="Zeroit Dev Technologies">
//     Copyright � Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Drawing;

namespace Zeroit.Framework.Utilities.GraphicsExtension.Drawing.Drawing2D
{
    /// <summary>
    /// Class PixelBufferManagedRenderer.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Utilities.GraphicsExtension.Drawing.Drawing2D.PixelBufferRenderer" />
    public class PixelBufferManagedRenderer:PixelBufferRenderer
    {
        /// <summary>
        /// Occurs when [render begin].
        /// </summary>
        public override event PixelBufferRenderDelegate RenderBegin;
        /// <summary>
        /// Occurs when [render complete].
        /// </summary>
        public override event PixelBufferRenderDelegate RenderComplete;

        /// <summary>
        /// The back color brush
        /// </summary>
        private SolidBrush backColorBrush;

        /// <summary>
        /// Initializes a new instance of the <see cref="PixelBufferManagedRenderer"/> class.
        /// </summary>
        /// <param name="pixelBuffer">The pixel buffer.</param>
        public PixelBufferManagedRenderer(PixelBuffer pixelBuffer)
            : base(pixelBuffer)
        {
            this.UseTransparentBackground = true;
            this.backColorBrush = new SolidBrush(Color.Black);
        }

        /// <summary>
        /// Raises the render begin event.
        /// </summary>
        /// <param name="renderInfo">The render information.</param>
        private void RaiseRenderBeginEvent(PixelBufferRenderInfo renderInfo)
        {
            if (this.RenderBegin != null)
            {
                this.RenderBegin(renderInfo);
            }
        }
        /// <summary>
        /// Raises the render complete event.
        /// </summary>
        /// <param name="renderInfo">The render information.</param>
        private void RaiseRenderCompleteEvent(PixelBufferRenderInfo renderInfo)
        {
            if (this.RenderComplete != null)
            {
                this.RenderComplete(renderInfo);
            }
        }

        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>The color of the background.</value>
        public override Color BackgroundColor
        {
            get
            {
                return backColorBrush.Color;
            }
            set
            {
                backColorBrush = new SolidBrush(value);
            }
        }

        /// <summary>
        /// Renders the specified render information.
        /// </summary>
        /// <param name="renderInfo">The render information.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public override void Render(PixelBufferRenderInfo renderInfo, int x, int y)
        {
            this.Render(renderInfo, x, y, pixelBuffer.Width, pixelBuffer.Height);
        }
        /// <summary>
        /// Renders the specified render information.
        /// </summary>
        /// <param name="renderInfo">The render information.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public override void Render(PixelBufferRenderInfo renderInfo, int x, int y, int width, int height)
        {
            RaiseRenderBeginEvent(renderInfo);

            if (!this.UseTransparentBackground)
            {
                renderInfo.Graphics.FillRectangle(backColorBrush, x, y, width, height);
            }
            using (System.Drawing.Bitmap bmp = pixelBuffer.ToBitmap())
            {
                renderInfo.Graphics.DrawImage(bmp, x, y, width, height);
            }

            RaiseRenderCompleteEvent(renderInfo);
        }
        /// <summary>
        /// Renders the specified render information.
        /// </summary>
        /// <param name="renderInfo">The render information.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public override void Render(PixelBufferRenderInfo renderInfo, float x, float y)
        {
            this.Render(renderInfo, x, y, pixelBuffer.Width, pixelBuffer.Height);
        }
        /// <summary>
        /// Renders the specified render information.
        /// </summary>
        /// <param name="renderInfo">The render information.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public override void Render(PixelBufferRenderInfo renderInfo, float x, float y, float width, float height)
        {
            RaiseRenderBeginEvent(renderInfo);

            if (!this.UseTransparentBackground)
            {
                renderInfo.Graphics.FillRectangle(backColorBrush, x, y, width, height);
            }
            using (System.Drawing.Bitmap bmp = pixelBuffer.ToBitmap())
            {
                renderInfo.Graphics.DrawImage(bmp, x, y, width, height);
            }

            RaiseRenderCompleteEvent(renderInfo);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return "{ PixelBufferManagedRenderer }";
        }

    }
}
