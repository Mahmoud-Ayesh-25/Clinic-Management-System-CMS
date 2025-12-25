using Clinic_Manager_Proj.Properties;
using CuoreUI.Controls;
using CuoreUI.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj
{
    public partial class frmMain : Form
    {
        void OnSizeChanged()
        {
            pnlTopContainer.Size = new Size(Width - 24, 58);
            cuiResizeGrip.Size = new Size(12, Height);

            if (WindowState == FormWindowState.Maximized)
            {
                btnMaximized.Image = Resources.minimize;
                cuiResizeGrip.Visible = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                btnMaximized.Image = Resources.expand;
                cuiResizeGrip.Visible = true;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        protected virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ImageTint = Color.White;
            pnlTopContainer.PanelColor = Color.FromArgb(40,20,20);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ImageTint = Color.FromArgb(150, 0, 0);
            pnlTopContainer.PanelColor = Color.FromArgb(40, 40, 40);
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmDashboard_SizeChanged(object sender, EventArgs e)
        {
            OnSizeChanged();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
