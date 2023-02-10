using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
	public class Colours : ProfessionalColorTable
	{
		public override Color MenuItemSelected
		{
			get { return Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39))))); ; }
		}

		public override Color MenuItemSelectedGradientBegin
		{
			get { return Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39))))); }
		}

		public override Color MenuItemSelectedGradientEnd
		{
			get { return Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39))))); }
		}

		public override Color MenuItemBorder
		{
			get { return Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39))))); }
		}
		public override Color MenuBorder
		{
			get { return Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39))))); }
		}

		public override Color MenuItemPressedGradientBegin
		{
			get { return Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39))))); }
		}
		public override Color MenuItemPressedGradientEnd
		{
			get { return Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39))))); }
		}
		public override Color ToolStripDropDownBackground
		{
			get { return Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))); }
		}

		public override Color ImageMarginGradientBegin
		{
			get { return Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))); }
		}
		public override Color ImageMarginGradientMiddle
		{
			get { return Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))); }
		}
		public override Color ImageMarginGradientEnd
		{
			get { return Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))); }
		}
	}

}
