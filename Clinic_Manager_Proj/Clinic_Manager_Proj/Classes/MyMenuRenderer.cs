using System.Drawing;
using System.Windows.Forms;

namespace DVLD_Project
{
    public class MyMenuRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
                e.Graphics.FillRectangle(Brushes.LightGray, e.Item.ContentRectangle);
            else
                e.Graphics.FillRectangle(Brushes.White, e.Item.ContentRectangle);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.Item.ContentRectangle);
        }
    }
}
