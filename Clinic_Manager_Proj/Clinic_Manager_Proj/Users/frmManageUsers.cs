using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Logs;
using Clinic_Manager_Proj.People;
using CMS_BusinessLayer;
using DVLD_Project;
using DVLD_Project.MainSettings;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Users
{
    public partial class frmManageUsers : frmMainFormForManage
    {
        DataTable dtUsers = new DataTable();

        void _dgv_Refresh()
        {
            dtUsers = clsUser.GetAllUsers();
            dgvData.DataSource = dtUsers;
        }

        // {Organize dgv Columns}
        void _Organize_dgvColumnsWidth()
        {
            dgvData.Columns["UserID"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["PersonName"].Width = (dgvData.Width * 40) / 100;
            dgvData.Columns["Username"].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns["PermissionsTypeTitle"].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns["IsActive"].Width = (dgvData.Width * 10) / 100;
        }
        void _Organize_dgv()
        {
            _dgv_Refresh();

            if (dgvData.Rows.Count == 0)
            {
                dgvData.Visible = false;
                return;
            }
            else dgvData.Visible = true;

            dgvData.Columns["UserID"].HeaderText = "ID";
            dgvData.Columns["PersonName"].HeaderText = "Person Name";
            dgvData.Columns["Username"].HeaderText = "Username";
            dgvData.Columns["PermissionsTypeTitle"].HeaderText = "Permissions";
            dgvData.Columns["IsActive"].HeaderText = "Is Active";

            _Organize_dgvColumnsWidth();
        }
        ////////////////////////

        void _FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                _dgv_Refresh();
                return;
            }

            DataView view = dtUsers.DefaultView;

            if (cbxFilter.SelectedIndex == 1)
            {
                view.RowFilter = $"UserID = {tbxFilter.Content}";
            }
            else
            {
                view.RowFilter = $"{dtUsers.Columns[cbxFilter.SelectedIndex - 1].ColumnName} LIKE '{tbxFilter.Content}%'";
            }

            dgvData.DataSource = view;
        }

        void _IsActiveFilterHandler()
        {
            if (cbxSubFilter.SelectedIndex == 0)
            {
                _dgv_Refresh();
                return;
            }

            DataView view = dtUsers.DefaultView;
            view.RowFilter = $"IsActive = {cbxSubFilter.SelectedIndex - 1}";
            dgvData.DataSource = view;
        }

        public frmManageUsers()
        {
            InitializeComponent();

            contextMenuStrip.Renderer = new MyMenuRenderer();
            dgvData.ContextMenuStrip = contextMenuStrip;
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            _Organize_dgv();
        }

        private void frmManageUsers_SizeChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
                _Organize_dgvColumnsWidth();
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
                _FilterHandler();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
                _dgv_Refresh();

            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex != 5);
            cbxSubFilter.Visible = (cbxFilter.SelectedIndex == 5);
        }

        private void cbxSubFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
                _IsActiveFilterHandler();
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter.SelectedIndex == 1)
            {
                if (!clsValidation.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewUser newUser = new frmAddNewUser();
            newUser.ShowDialog();

            _Organize_dgv();
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowUserInfo user = new frmShowUserInfo(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            user.ShowDialog();

            _dgv_Refresh();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmEditUser user = new frmEditUser(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            user.ShowDialog();

            _dgv_Refresh();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to delete this user with the ID[{dgvData.CurrentRow.Cells[0].Value.ToString()}]",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The user has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Users, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Delete))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The user was not deleted because it is connected to other data in the database.", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _Organize_dgv();
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to activate the user with the ID[{int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())}]?"
                , "Confirm Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.ActivateUser(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The user has been successfully activated.", "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Users, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error while activate the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _dgv_Refresh();
        }

        private void deactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to deactivate the user with the ID[{int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())}]?"
                , "Confirm Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.DeactivateUser(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The user has been successfully deactivated.", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Users, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error while deactivate the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _dgv_Refresh();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            bool active = (bool)dgvData.CurrentRow.Cells[4].Value;

            if (active)
            {
                contextMenuStrip.Items[4].Enabled = false;
                contextMenuStrip.Items[5].Enabled = true;
            }
            else
            {
                contextMenuStrip.Items[4].Enabled = true;
                contextMenuStrip.Items[5].Enabled = false;
            }
        }

        private void logsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowLogs logs = new frmShowLogs("Users", int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            logs.ShowDialog();
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowLogs logs = new frmShowLogs(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            logs.ShowDialog();
        }
    }
}