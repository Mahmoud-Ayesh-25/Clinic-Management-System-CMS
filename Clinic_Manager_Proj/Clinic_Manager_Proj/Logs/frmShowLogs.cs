using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using DVLD_Project.MainSettings;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Logs
{
    public partial class frmShowLogs : frmMain
    {
        enum enMode { User, TableAndRecord}
        enMode Mode;

        int UserID;

        string TableName;
        int RecordID;

        DataTable dtLogs = new DataTable();

        //{Load Data}
        void _dgv_Refresh_User()
        {
            dtLogs = clsLog.GetAllLogsByUserID(UserID);
            dgvData.DataSource = dtLogs;
        }

        void _dgv_Refresh_TableAndRecord()
        {
            dtLogs = clsLog.GetAllLogsByTableNameAndRecordID(TableName, RecordID);
            dgvData.DataSource = dtLogs;
        }

        void _Organize_dgvDataColumnsWidth()
        {
            dgvData.Columns["LogID"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["Username"].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns["TableName"].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns["RecordID"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["ActionType"].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns["DateTime"].Width = ((dgvData.Width * 20) / 100) + 5;
        }
        void _Organize_dgvData()
        {
            if (Mode == enMode.TableAndRecord)
                _dgv_Refresh_TableAndRecord();
            else _dgv_Refresh_User();

            if (dgvData.Rows.Count == 0)
            {
                dgvData.Visible = false;
                return;
            }else dgvData.Visible = true;

            dgvData.Columns["LogID"].HeaderText = "Log ID";
            dgvData.Columns["Username"].HeaderText = "Username";
            dgvData.Columns["TableName"].HeaderText = "Table Name";
            dgvData.Columns["RecordID"].HeaderText = "Record ID";
            dgvData.Columns["ActionType"].HeaderText = "Action Type";
            dgvData.Columns["DateTime"].HeaderText = "Date Time";

            _Organize_dgvDataColumnsWidth();

            ctrlLogCard1.LoadData(int.Parse(dgvData.Rows[0].Cells[0].Value.ToString()));
        }
        ////////////

        void _FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                if (Mode == enMode.TableAndRecord)
                    _dgv_Refresh_TableAndRecord();
                else _dgv_Refresh_User();

                return;
            }

            DataView view = dtLogs.DefaultView;

            if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 4)
            {
                view.RowFilter = $"{dtLogs.Columns[cbxFilter.SelectedIndex - 1].ColumnName} = {tbxFilter.Content}";
            }
            else
            {
                view.RowFilter = $"{dtLogs.Columns[cbxFilter.SelectedIndex - 1].ColumnName} LIKE '{tbxFilter.Content}%'";
            }

            dgvData.DataSource = view;
        }

        void _ActionTypeFilterHandler()
        {
            if (cbxSubFilter.SelectedIndex == 0)
            {
                if (Mode == enMode.TableAndRecord)
                    _dgv_Refresh_TableAndRecord();
                else _dgv_Refresh_User();

                return;
            }

            DataView view = dtLogs.DefaultView;
            view.RowFilter = $"ActionType = '{cbxSubFilter.SelectedItem}'";

            dgvData.DataSource = view;
        }

        public frmShowLogs(int UserID)
        {
            InitializeComponent();
            Mode = enMode.User;
            this.UserID = UserID;
        }

        public frmShowLogs(string TableName, int RecordID)
        {
            InitializeComponent();
            Mode = enMode.TableAndRecord;
            this.TableName = TableName;
            this.RecordID = RecordID;
        }

        private void frmShowLogs_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            _Organize_dgvData();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mode == enMode.TableAndRecord)
                _dgv_Refresh_TableAndRecord();
            else _dgv_Refresh_User();

            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex != 5);
            cbxSubFilter.Visible = (cbxFilter.SelectedIndex == 5);
        }

        private void dgvData_Click(object sender, EventArgs e)
        {
            ctrlLogCard1.LoadData(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 4)
            {
                if (!clsValidation.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            _FilterHandler();
        }

        private void cbxSubFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ActionTypeFilterHandler();
        }

        private void dgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblRecordes.Content = $"Records : {dgvData.Rows.Count}";
        }
    }
}