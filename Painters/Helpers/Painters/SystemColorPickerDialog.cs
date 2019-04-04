// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SystemColorPickerDialog.cs" company="Zeroit Dev Technologies">
//     Copyright � Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.Utilities.GraphicsExtension.Painters.Editors
{
    /// <summary>
    /// Represents a dialog that enables the user to select a system color.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SystemColorPickerDialog : System.Windows.Forms.Form
    {
        /// <summary>
        /// Constructor with no starting color and default window position.
        /// </summary>
        public SystemColorPickerDialog() : this(Color.Empty)
        {
		}

        /// <summary>
        /// Constructor with starting color and default window position.
        /// </summary>
        /// <param name="color">Starting color.</param>
        public SystemColorPickerDialog(Color color)
        {
            InitializeComponent();
			systemColorPicker.SetColor(color);
        }

        /// <summary>
        /// Constructor with no starting color and starting position beneath specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
		public SystemColorPickerDialog(Control c) : this(Color.Empty, c)
		{
		}

        /// <summary>
        /// Constructor with starting color and starting position beneath specified control.
        /// </summary>
        /// <param name="color">Starting color.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
		public SystemColorPickerDialog(Color color, Control c)
		{
            InitializeComponent();
			Utils.SetStartPositionBelowControl(this, c);
			systemColorPicker.SetColor(color);
		}

        /// <summary>
        /// Consructor with no starting color and starting position.
        /// </summary>
        /// <param name="p">Starting position.</param>
		public SystemColorPickerDialog(Point p) : this(Color.Empty, p)
		{
		}

        /// <summary>
        /// Constructor with starting color and starting position.
        /// </summary>
        /// <param name="color">Starting color.</param>
        /// <param name="p">Starting position.</param>
		public SystemColorPickerDialog(Color color, Point p)
		{
            InitializeComponent();
			Utils.SetStartPosition(this, p);
			systemColorPicker.SetColor(color);
		}

        /// <summary>
        /// The color
        /// </summary>
        private Color color;
        /// <summary>
        /// Gets or sets selected color.
        /// </summary>
        /// <value>Selected color.</value>
        public Color Color
		{
			get { return color; }
			set	{ systemColorPicker.SetColor(value); }
		}

        /// <summary>
        /// The color name
        /// </summary>
        private string colorName;
        /// <summary>
        /// Gets name of selected color.
        /// </summary>
        /// <value>Name of selected color.</value>
        public string ColorName
		{
			get { return colorName; }
		}

        /// <summary>
        /// Override to capture Esc key.
        /// </summary>
        /// <param name="keyCode">Key.</param>
        /// <returns><c>True</c> if key handled, <c>false</c> otherwise.</returns>
		protected override bool ProcessDialogKey(Keys keyCode)
		{
			if (keyCode == Keys.Escape)
			{
				DialogResult = DialogResult.Cancel;
                return true;
			}
            return false;
		}

        /// <summary>
        /// Handles the ColorSelected event of the systemColorPicker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="Zeroit.Framework.Utilities.GraphicsExtension.Painters.Editors.ColorSelectedEventArgs"/> instance containing the event data.</param>
        private void systemColorPicker_ColorSelected(object sender, Zeroit.Framework.Utilities.GraphicsExtension.Painters.Editors.ColorSelectedEventArgs args)
        {
            color = args.Color;
			colorName = args.ColorName;
            DialogResult = DialogResult.OK;
        }
    }
}
