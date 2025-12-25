using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Logs;
using Clinic_Manager_Proj.People;
using CMS_BusinessLayer;
using DVLD_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Settings.PaymentMethods
{
    public partial class frmManagePaymentMethods : frmMainFormForManage
    {
        DataTable dtMethods = new DataTable();

        void _dgvData_Refresh()
        {
            dtMethods = clsPaymentMethod.GetAllPaymentMethods();
            dgvData.DataSource = dtMethods;
        }

        void _Organize_dgvData()
        {
            _dgvData_Refresh();

            if (dgvData.Rows.Count == 0 )
            {
                dgvData.Visible = false; return;
            }
            else dgvData.Visible = true;

            dgvData.Columns[0].HeaderText = "ID";
            dgvData.Columns[1].HeaderText = "Payment Method";

            dgvData.Columns[0].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns[1].Width = ((dgvData.Width * 80) / 100) + 10;
        }

        public frmManagePaymentMethods()
        {
            InitializeComponent();
        }

        private void frmManagePaymentMethods_Load(object sender, EventArgs e)
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
            frmAddUpdatePaymentMethod method = new frmAddUpdatePaymentMethod();
            method.ShowDialog();

            _Organize_dgvData();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddUpdatePaymentMethod method = new frmAddUpdatePaymentMethod(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            method.ShowDialog();

            _dgvData_Refresh();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete this method with the ID[{dgvData.CurrentRow.Cells[0].Value.ToString()}]",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPaymentMethod.DeletePaymentMethod(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The method has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.PaymentMethodes, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Delete))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The method was not deleted because it is connected to other data in the database.", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _Organize_dgvData();
        }

        private void logsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLogs logs = new frmShowLogs("PaymentMethodes", int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            logs.ShowDialog();
        }
    }
}
