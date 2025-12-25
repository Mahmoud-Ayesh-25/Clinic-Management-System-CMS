using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Settings.Notifications
{
    public partial class frmNotificationsMainScreen : frmMain
    {
        public frmNotificationsMainScreen()
        {
            InitializeComponent();

            schNotifications.Checked = clsProgramSettings.Notifications;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmManageNotifications notifications = new frmManageNotifications();
            notifications.ShowDialog();
        }

        private void schCompletedOnly_CheckedChanged(object sender, EventArgs e)
        {
            clsProgramSettings.Notifications = schNotifications.Checked;

            if (clsSettings.UpdateNotifications(schNotifications.Checked))
            {
                if (!clsMisc.MakeLog(clsMisc.enTableName.Settings, 1, clsLog.enActionType.Update))
                {
                    MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error while updating the notifications settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
