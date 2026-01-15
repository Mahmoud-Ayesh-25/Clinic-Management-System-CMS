using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Settings.Notifications;
using Clinic_Manager_Proj.Settings.PaymentMethods;
using Clinic_Manager_Proj.Users;
using System;
using System.Windows.Forms;
using CMS_BusinessLayer;

namespace Clinic_Manager_Proj.Settings
{
    public partial class frmMainSettings : frmMain
    {
        public frmMainSettings()
        {
            InitializeComponent();
        }

        private void frmMainSettings_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }
        }

        private void btnEditCurrentUser_Click(object sender, EventArgs e)
        {
            frmEditUser user = new frmEditUser(clsProgramSettings.CurrentUser.UserID);
            user.ShowDialog();
        }

        private void btnPaymentMethods_Click(object sender, EventArgs e)
        {
            frmManagePaymentMethods methods = new frmManagePaymentMethods();
            methods.ShowDialog();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            frmNotificationsMainScreen notifications = new frmNotificationsMainScreen();
            notifications.ShowDialog();
        }
    }
}
