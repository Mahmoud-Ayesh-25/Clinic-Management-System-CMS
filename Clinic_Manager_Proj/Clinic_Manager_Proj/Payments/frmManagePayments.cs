using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Logs;
using Clinic_Manager_Proj.People;
using CMS_BusinessLayer;
using DVLD_Project;
using DVLD_Project.MainSettings;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Payments
{
    public partial class frmManagePayments : frmMainFormForManage
    {
        DataTable dtPayments = new DataTable();
        bool dateFilter = true;
        bool completedOnly = true;

        string filter = string.Empty;

        //{LoadData}
        void _dgv_Refresh()
        {
            filter = string.Empty;

            dtPayments = clsPayment.GetAllPayments();

            if (dtPayments.Rows.Count == 0) return;

            DataView view = dtPayments.DefaultView;

            if (dateFilter && completedOnly)
            {
                view.RowFilter = $"Date = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}' AND Status = 'Completed'";
                filter = view.RowFilter;
                dgvData.DataSource = view;
                return;
            }

            if (dateFilter)
            {
                view.RowFilter = $"Date = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}'";
                filter = view.RowFilter;
            }

            if (completedOnly)
            {
                view.RowFilter = $"Status = 'Completed'";
                filter = view.RowFilter;
            }

            dgvData.DataSource = view;
        }

        void _Organize_dgvDataColumnsWidth()
        {
            dgvData.Columns["PaymentID"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["VisitID"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["PaidAmount"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["PaymentMethodTitle"].Width = (dgvData.Width * 30) / 100;
            dgvData.Columns["Date"].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns["Status"].Width = ((dgvData.Width * 20) / 100) + 10;
        }
        void _Organize_dgvData()
        {
            _dgv_Refresh();

            if (dgvData.Rows.Count == 0)
            {
                dgvData.Visible = false;
                return;
            }
            else dgvData.Visible = true;

            dgvData.Columns["PaymentID"].HeaderText = "Payment ID";
            dgvData.Columns["VisitID"].HeaderText = "Visit ID";
            dgvData.Columns["PaidAmount"].HeaderText = "Paid Amount";
            dgvData.Columns["PaymentMethodTitle"].HeaderText = "Payment Method";
            dgvData.Columns["Date"].HeaderText = "Date";
            dgvData.Columns["Status"].HeaderText = "Status";

            _Organize_dgvDataColumnsWidth();
        }
        ////////////

        //{Filters}
        void _FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                _dgv_Refresh();
                return;
            }

            DataView view = dtPayments.DefaultView;

            view.RowFilter = $@"{dtPayments.Columns[cbxFilter.SelectedIndex - 1].ColumnName} = {tbxFilter.Content}
                            {((!string.IsNullOrEmpty(filter)? $"AND {filter}" : ""))}";

            dgvData.DataSource = view;
        }

        void _PaymentMethodFilter()
        {
            if (cbxSubFilter.SelectedIndex == 0)
            {
                _dgv_Refresh();
                return;
            }

            DataView view = dtPayments.DefaultView;

            view.RowFilter = $@"PaymentMethodTitle = '{cbxSubFilter.SelectedItem}'
                            {((!string.IsNullOrEmpty(filter) ? $"AND {filter}" : ""))}";

            dgvData.DataSource = view;
        }

        void _LoadPaymentMethods()
        {
            DataTable paymentMethods = clsPaymentMethod.GetAllPaymentMethods();

            foreach(DataRow row in paymentMethods.Rows)
            {
                cbxSubFilter.AddItem(row[1].ToString());
            }
        }
        ////////////

        public frmManagePayments()
        {
            InitializeComponent();

            cdpDate.Content = DateTime.Now;
            contextMenuStrip.Renderer = new MyMenuRenderer();
            dgvData.ContextMenuStrip = contextMenuStrip;
        }

        private void frmManagePayments_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin &&
                clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Accountant)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            _LoadPaymentMethods();
            _Organize_dgvData();
        }

        private void schDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            dateFilter = (schDateFilter.Checked);
            cdpDate.Enabled = (schDateFilter.Checked);
            _Organize_dgvData();
        }

        private void schCompletedOnly_CheckedChanged(object sender, EventArgs e)
        {
            completedOnly = (schCompletedOnly.Checked);
            _Organize_dgvData();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvData.Visible)
                _dgv_Refresh();

            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex != 3);
            cbxSubFilter.Visible = (cbxFilter.SelectedIndex == 3);
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (!dgvData.Visible) return;

            _FilterHandler();
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidation.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void cbxSubFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dgvData.Visible) return;

            _PaymentMethodFilter();
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowPaymentInfo payment = new frmShowPaymentInfo(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            payment.ShowDialog();
        }

        private void showLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowLogs logs = new frmShowLogs("Payments", int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            logs.ShowDialog();
        }
    }
}
