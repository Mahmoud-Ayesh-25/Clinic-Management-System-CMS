using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Clinic_Manager_Proj
{
    public partial class frmLogin : frmMain
    {
        string _RememberMeHashedPass = string.Empty;
        bool _IsFirstTime = false;

        // This move the database to appdata file to access it without permissions problems.
        void _MoveTheDB()
        {
            string mdf_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Clinic Management System", "Clinic_Manager_DB.mdf");
            string log_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Clinic Management System", "Clinic_Manager_DB_log.ldf");

            if (File.Exists(mdf_path) && File.Exists(log_path)) return;

            if (File.Exists(@"DB\Clinic_Manager_DB.mdf") && File.Exists(@"DB\Clinic_Manager_DB_log.ldf"))
            {
                string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Clinic Management System");

                try
                {
                    Directory.CreateDirectory(dir);
                    File.Move(@"DB\Clinic_Manager_DB.mdf", mdf_path);
                    File.Move(@"DB\Clinic_Manager_DB_log.ldf", log_path);
                    Directory.Delete("DB");
                }
                catch (Exception ex) 
                {
                    clsMisc.CreateEventLog(ex.Message);
                    MessageBox.Show($"{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(@"The database files were not found. Please make sure the database files exist in \Program File\DB\.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        //This set the username and the password at the registry if cbxRememberMe is checked and remove them if it's not checked.
        void _SetRememberMe(string HashedPass)
        {
            string regDir = @"HKEY_CURRENT_USER\SOFTWARE\ClinicManagementSystem(CMS)";

            string usernameName = "Username";
            string passwordName = "Password";

            if (cbxRememberMe.Checked)
            {
                try
                {
                    Registry.SetValue(regDir, usernameName, tbxUsername.Content, RegistryValueKind.String);
                    Registry.SetValue(regDir, passwordName, HashedPass, RegistryValueKind.String);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsMisc.CreateEventLog(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        string dir = @"SOFTWARE\ClinicManagementSystem(CMS)";

                        baseKey.DeleteSubKey(dir, true);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show($"UnauthorizedAccessException: Run the program as administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsMisc.CreateEventLog("UnauthorizedAccessException: Run the program as administrator.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsMisc.CreateEventLog(ex.Message);
                }
            }
        }

        // This get the username and the password from registry.
        void _GetRememberMe()
        {
            string regDir = @"HKEY_CURRENT_USER\SOFTWARE\ClinicManagementSystem(CMS)";

            string usernameName = "Username";
            string passwordName = "Password";

            try
            {
                string username = Registry.GetValue(regDir, usernameName, null) as string;
                string password = Registry.GetValue(regDir, passwordName, null) as string;

                if (username != null && password != null)
                {
                    tbxUsername.Content = username;
                    _RememberMeHashedPass = password;

                    cbxRememberMe.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clsMisc.CreateEventLog(ex.Message);
            }
        }

        // if first time open the app
        void _FirstTime()
        {
            if (File.Exists("FirstTime.txt"))
            {
                string[] usernameAndPass = File.ReadAllText("FirstTime.txt").Split('|');

                if (usernameAndPass.Length == 2)
                {
                    tbxUsername.Content = usernameAndPass[0];
                    ctrlPassword1.Content = usernameAndPass[1];

                    cbxRememberMe.Checked = true;
                    _IsFirstTime = true;
                }

                try
                {
                    File.Delete("FirstTime.txt");
                }
                catch (Exception ex) { clsMisc.CreateEventLog(ex.Message); }
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _MoveTheDB();

            _FirstTime();

            if (!_IsFirstTime)
                _GetRememberMe();
        }

        void _Login()
        {
            if (string.IsNullOrEmpty(tbxUsername.Content) || (string.IsNullOrEmpty(ctrlPassword1.Content) && _RememberMeHashedPass == string.Empty))
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


            // Handle The Password
            string HashedPass = _RememberMeHashedPass;

            if (!string.IsNullOrEmpty(_RememberMeHashedPass) && string.IsNullOrEmpty(ctrlPassword1.Content))
            {
                if (_RememberMeHashedPass != user.Password)
                {
                    MessageBox.Show("The remember me password is incorrect, please write the password by yourself.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _RememberMeHashedPass = string.Empty;

                    return;
                }
            }
            else
            {
                HashedPass = clsMisc.HashPassword(ctrlPassword1.Content, user.Salt);

                if (HashedPass != user.Password)
                {
                    MessageBox.Show($"The password is incorrect.{((string.IsNullOrEmpty(_RememberMeHashedPass)) ? "" : "\nThe password is already saved by remember me, remove the written password and the system will login if the username is correct.")}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //////////////////////

            _SetRememberMe(HashedPass);

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
