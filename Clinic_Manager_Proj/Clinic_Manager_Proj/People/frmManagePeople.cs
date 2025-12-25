using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Logs;
using CMS_BusinessLayer;
using DVLD_Project;
using DVLD_Project.MainSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.People
{
    public partial class frmManagePeople : frmMainFormForManage
    {
        DataTable dtPeople = new DataTable();

        // {Load Data}
        void _dgvData_Refresh()
        {
            dtPeople = clsPerson.GetAllPeople();
            dgvData.DataSource = dtPeople;
        }

        void _Organize_dgvDataColumnsWidth()
        {
            dgvData.Columns["PersonID"].Width = (dgvData.Width * 7) / 100;
            dgvData.Columns["NationalNo"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["Name"].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns["DateOfBirth"].Width = (dgvData.Width * 13) / 100;
            dgvData.Columns["Age"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["Gender"].Width = (dgvData.Width * 7) / 100;
            dgvData.Columns["Phone"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["Email"].Width = (dgvData.Width * 14) / 100;
            dgvData.Columns["Address"].Width = (dgvData.Width * 14) / 100 + 5;
        }
        void _Organize_dgvData()
        {
            _dgvData_Refresh();

            if (dgvData.Rows.Count == 0)
            {
                dgvData.Visible = false;
                return;
            }
            else dgvData.Visible = true;

            dgvData.Columns["PersonID"].HeaderText = "ID";
            dgvData.Columns["NationalNo"].HeaderText = "National No";
            dgvData.Columns["Name"].HeaderText = "Name";
            dgvData.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
            dgvData.Columns["Age"].HeaderText = "Age";
            dgvData.Columns["Gender"].HeaderText = "Gender";
            dgvData.Columns["Phone"].HeaderText = "Phone";
            dgvData.Columns["Email"].HeaderText = "Email";
            dgvData.Columns["Address"].HeaderText = "Address";

            _Organize_dgvDataColumnsWidth();
        }
        /////////////

        void _FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                _dgvData_Refresh();
                return;
            }

            DataView view = dtPeople.DefaultView;

            if (cbxFilter.SelectedIndex == 1)
            {
                view.RowFilter = $"PersonID = {tbxFilter.Content}";
            }
            else
            {
                view.RowFilter = $"{dtPeople.Columns[cbxFilter.SelectedIndex - 1].ColumnName} LIKE '{tbxFilter.Content}%'";
            }

            dgvData.DataSource = view;
        }

        void _GenderFilterHandler()
        {
            if (cbxSubFilter.SelectedIndex == 0)
            {
                _dgvData_Refresh();
                return;
            }

            DataView view = dtPeople.DefaultView;
            view.RowFilter = $"Gender = '{cbxSubFilter.SelectedItem}'";
            dgvData.DataSource = view;
        }

        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            _Organize_dgvData();
            dgvData.ContextMenuStrip = contextMenuStrip;
            contextMenuStrip.Renderer = new MyMenuRenderer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0) return;

            frmAddUpdatePerson frmAdd = new frmAddUpdatePerson();
            frmAdd.ShowDialog();

            _Organize_dgvData();
        }

        private void frmManagePeople_SizeChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count == 0) return;
            _Organize_dgvDataColumnsWidth();
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowPersonInfo person = new frmShowPersonInfo(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            person.ShowDialog();

            _dgvData_Refresh();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmAddUpdatePerson person = new frmAddUpdatePerson(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            person.ShowDialog();

            _dgvData_Refresh();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to delete this person with the ID[{dgvData.CurrentRow.Cells[0].Value.ToString()}]", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPerson.DeletePerson(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The person has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.People, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Delete))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The person was not deleted because it is connected to other data in the database.", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _Organize_dgvData();
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

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
                _dgvData_Refresh();

            cbxSubFilter.Visible = (cbxFilter.SelectedIndex == 4);
            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex != 4);
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            _FilterHandler();
        }

        private void cbxSubFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GenderFilterHandler();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowLogs logs = new frmShowLogs("People", int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            logs.ShowDialog();
        }
    }
}
