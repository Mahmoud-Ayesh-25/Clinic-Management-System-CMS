using CMS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Settings.Notifications
{
    public partial class frmShowNotificationInfo : frmMain
    {
        int NotificationID = -1;
        clsNotification notification = new clsNotification();

        bool _LoadData()
        {
            notification = clsNotification.Find(NotificationID);

            if (notification == null) return false;

            lblNotifyID.Content = $"Notification ID: {notification.NotificationID}";
            lblUsername.Content = $"Username: {notification.UserName}";
            lblDate.Content = $"Date: {notification.Date.ToShortDateString()}";
            lblTime.Content = $"Time: {notification.Time.ToShortTimeString()}";
            lblMessage.Content = $"Message: {notification.NotificationMessage}";

            return true;
        }

        void _SetReadable()
        {
            notification.IsRead = true;
            notification.Save();
        }

        public frmShowNotificationInfo(int NotificationID)
        {
            InitializeComponent();

            this.NotificationID = NotificationID;
        }

        private void frmShowNotificationInfo_Load(object sender, EventArgs e)
        {
            if (!_LoadData())
            {
                MessageBox.Show("Error while retrieving notification data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            _SetReadable();
        }
    }
}
