// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="LinearGradientPanel.cs" company="Zeroit Dev Technologies">
//     Copyright � Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.Utilities.GraphicsExtension.Painters.Editors
{
    /// <summary>
    /// Represents a control for displaying a linear color gradient.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [ToolboxItem(false)]
    public partial class LinearGradientPanel : UserControl
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public LinearGradientPanel()
        {
            InitializeComponent();

			this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
						  ControlStyles.AllPaintingInWmPaint |
						  ControlStyles.ResizeRedraw |
						  ControlStyles.UserPaint, true);

			this.UpdateStyles();
        }

        /// <summary>
        /// The blend
        /// </summary>
        private ColorBlend blend;
        /// <summary>
        /// Gets or sets color blend.
        /// </summary>
        /// <value>Color blend.</value>
		public ColorBlend Blend
		{
			get { return blend; }
			set
			{
				blend = value;
				Redraw();
			}
		}

        /// <summary>
        /// The mode
        /// </summary>
        private LinearGradientMode mode = LinearGradientMode.Horizontal;
        /// <summary>
        /// Gets or sets linear gradient mode.
        /// </summary>
        /// <value>Linear gradient mode.</value>
		public LinearGradientMode Mode
		{
			get { return mode; }
			set
			{
				mode = value;
				Redraw();
			}
		}

        /// <summary>
        /// The br
        /// </summary>
        private LinearGradientBrush2 br = null;

        /// <summary>
        /// Redraws this instance.
        /// </summary>
        private void Redraw()
        {
            if (br != null)
            {
                br.Dispose();
                br = null;
            }
            Invalidate(true);
        }

        /// <summary>
        /// Handles the Paint event of the this control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void this_Paint(object sender, PaintEventArgs e)
        {
			if (blend != null)
			{
				if (br == null)
				{
					br = new LinearGradientBrush2(this.ClientRectangle, blend, mode);
				}
	            br.FillRectangle(e.Graphics, this.ClientRectangle, SystemBrushes.Window);
			}
        }
    }
}
