using System.Drawing;
using System.Windows.Forms;

namespace NoteTakingApp.Resources
{
	public class MyToolRenderer : ToolStripProfessionalRenderer
	{
		public MyToolRenderer() : base(new Colours())
		{
			this.RoundedEdges = true;
			
		}
	}
	
}
