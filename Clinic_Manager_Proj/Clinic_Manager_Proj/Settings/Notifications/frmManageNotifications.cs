using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.People;
using CMS_BusinessLayer;
using DVLD_Project;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Settings.Notifications
{
    public partial class frmManageNotifications : frmMainFormForManage
    {
        DataTable dtNotifications = new DataTable();

        //{Load Data}
        void _dgvData_Refresh()
        {
            dtNotifications = clsNotification.GetAllNotifications();

            if (dtNotifications.Rows.Count == 0) return;

            DataView view = dtNotifications.DefaultView;

            if (schDateFilter.Checked)
            {
                view.RowFilter = $"NotificationsDate = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}'";
            }

            dgvData.DataSource = view;
        }
        
        void _Organize_dgvData_ColumnsWidth()
        {
            dgvData.Columns["NotificationID"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["NotificationMessage"].Width = (dgvData.Width * 35) / 100;
            dgvData.Columns["Username"].Width = (dgvData.Width * 15) / 100;
            dgvData.Columns["NotificationTime"].Width = (dgvData.Width * 15) / 100;
            dgvData.Columns["NotificationsDate"].Width = (dgvData.Width * 15) / 100;
            dgvData.Columns["IsRead"].Width = ((dgvData.Width * 10) / 100) + 10;
        }
        void _Organize_dgvData()
        {
            _dgvData_Refresh();

            if (dgvData.Rows.Count == 0)
            {
                dgvData.Visible = false; return;
            }else dgvData.Visible = true;

            dgvData.Columns["NotificationID"].HeaderText = "ID";
            dgvData.Columns["NotificationMessage"].HeaderText = "Message";
            dgvData.Columns["Username"].HeaderText = "Username";
            dgvData.Columns["NotificationTime"].HeaderText = "Time";
            dgvData.Columns["NotificationsDate"].HeaderText = "Date";
            dgvData.Columns["IsRead"].HeaderText = "IsRead";

            _Organize_dgvData_ColumnsWidth();
        }
        ////////////

        public frmManageNotifications()
        {
            InitializeComponent();
        }

        private void frmManageNotifications_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            contextMenuStrip.Renderer = new MyMenuRenderer();
            dgvData.ContextMenuStrip = contextMenuStrip;

            cdpDate.Content = DateTime.Now;
            _Organize_dgvData();
        }

        private void frmManageNotifications_SizeChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
                _Organize_dgvData_ColumnsWidth();
        }

        private void schDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            cdpDate.Enabled = (schDateFilter.Checked);
            _Organize_dgvData();
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowNotificationInfo notification = new frmShowNotificationInfo(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            notification.ShowDialog();
        }
    }
}
