using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj
{
    public partial class frmLogin : frmMain
    {
        void MoveTheDB()
        {
            string mdf_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Clinic Management System", "Clinic_Manager_DB.mdf");
            string log_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Clinic Management System", "Clinic_Manager_DB_log.ldf");

            if (File.Exists(mdf_path) && File.Exists(log_path)) return;

            if (File.Exists(@"DB\Clinic_Manager_DB.mdf") && File.Exists(@"DB\Clinic_Manager_DB_log.ldf"))
            {
                string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Clinic Management System");

                Directory.CreateDirectory(dir);
                File.Move(@"DB\Clinic_Manager_DB.mdf", mdf_path);
                File.Move(@"DB\Clinic_Manager_DB_log.ldf", log_path);
                Directory.Delete("DB");
            }
            else
            {
                MessageBox.Show(@"The database files were not found. Please make sure the database files exist in \Program File\DB\.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        void _FirstTimeLogin()
        {
            if (File.Exists("FirstTimeLogin.txt"))
            {
                string fileText = File.ReadAllText("FirstTimeLogin.txt");

                string[] loginData = fileText.Split('|');

                if (loginData.Length == 2)
                {
                    tbxUsername.Content = loginData[0];
                    ctrlPassword1.Content = loginData[1];

                    lblWarning.Visible = true;
                }

                File.Delete("FirstTimeLogin.txt");
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MoveTheDB();
            _FirstTimeLogin();
        }

        void _Login()
        {
            if (string.IsNullOrEmpty(tbxUsername.Content) || string.IsNullOrEmpty(ctrlPassword1.Content))
            {
                MessageBox.Show("Make sure to fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUser user = clsUser.FindByUsername(tbxUsername.Content);

            if (user == null)
            {
                MessageBox.Show("The username is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsMisc.HashPassword(ctrlPassword1.Content, user.Salt) != user.Password)
            {
                MessageBox.Show("The password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsProgramSettings.CurrentUser = user;

            frmDashboard dashboard = new frmDashboard(this);
            this.Hide();
            dashboard.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _Login();
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ctrlPassword1.Focus();
            }
        }
    }
}
