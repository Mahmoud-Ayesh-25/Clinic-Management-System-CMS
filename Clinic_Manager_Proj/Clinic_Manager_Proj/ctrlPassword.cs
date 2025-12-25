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
    public partial class ctrlPassword : UserControl
    {
        bool show = false;

        public string PlaceHolderText
        {
            get { return tbxPassword.PlaceholderText; }
            set { tbxPassword.PlaceholderText = value; }
        }

        public Color PlaceHolderColor
        {
            get { return tbxPassword.PlaceholderColor; }
            set { tbxPassword.PlaceholderColor = value; }
        }

        public Color OutLineColor
        {
            get { return tbxPassword.OutlineColor; }
            set { tbxPassword.OutlineColor = value; }
        }

        public string Content
        {
            get { return tbxPassword.Content; }
            set
            { tbxPassword.Content = value; }
        }

        public ctrlPassword()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (show)
            {
                btnShow.Image = imageList.Images[0];
                tbxPassword.PasswordChar = true;
                show = false;
            }
            else
            {
                btnShow.Image = imageList.Images[1];
                tbxPassword.PasswordChar = false;
                show = true;
            }
        }

        private void ctrlPassword_SizeChanged(object sender, EventArgs e)
        {
            btnShow.Width = this.Height;
            btnShow.Height = this.Height;
            tbxPassword.Height = this.Height;
            tbxPassword.Width = this.Width - this.Height;

            btnShow.Location = new Point(this.Width - btnShow.Width, 0);

            btnShow.Rounding = new Padding((btnShow.Height / 2));
            tbxPassword.Rounding = new Padding((tbxPassword.Height / 2));
        }
    }
}
