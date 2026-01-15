using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Logs;
using Clinic_Manager_Proj.Payments;
using Clinic_Manager_Proj.People;
using CMS_BusinessLayer;
using DVLD_Project;
using DVLD_Project.MainSettings;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Visits
{
    public partial class frmManageVisits : frmMainFormForManage
    {
        enum enMode { Admin, Doctor }
        enMode Mode;

        DataTable dtVisits = new DataTable();

        string filter = string.Empty;

        // {LoadData}
        void _dgv_Refresh()
        {
            filter = string.Empty;

            if (Mode == enMode.Admin)
            {
                dtVisits = clsVisit.GetAllVisits();
            }
            else if (Mode == enMode.Doctor)
            {
                clsDoctor doctor = clsDoctor.FindByPersonID(clsProgramSettings.CurrentUser.PersonID);

                dtVisits = clsVisit.GetVisitsByDoctorID(doctor.DoctorID);
            }

            if (dtVisits.Rows.Count == 0) return;

            DataView view = dtVisits.DefaultView;

            if (schDateFilter.Checked)
            {
                view.RowFilter = $"VisitDate = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}'";
                filter = view.RowFilter;
            }

            dgvData.DataSource = view;
        }

        void _Organize_dgvDataColumnWidth()
        {
            dgvData.Columns["VisitID"].Width = (dgvData.Width * 7) / 100;
            dgvData.Columns["AppointmentID"].Width = (dgvData.Width * 7) / 100;
            dgvData.Columns["PatientName"].Width = (dgvData.Width * 14) / 100;
            dgvData.Columns["DoctorName"].Width = (dgvData.Width * 14) / 100;
            dgvData.Columns["VisitDate"].Width = (dgvData.Width * 9) / 100;
            dgvData.Columns["VisitTime"].Width = (dgvData.Width * 9) / 100;
            dgvData.Columns["VisitStatus"].Width = (dgvData.Width * 7) / 100;
            dgvData.Columns["EmergencyIncome"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["VisitReason"].Width = (dgvData.Width * 8) / 100;
            dgvData.Columns["PaymentAmount"].Width = (dgvData.Width * 7) / 100;
            dgvData.Columns["PaidAmount"].Width = (dgvData.Width * 7) / 100;
            dgvData.Columns["PaymentStatus"].Width = ((dgvData.Width * 7) / 100) + 10;
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

            dgvData.Columns["VisitID"].HeaderText = "V. ID";
            dgvData.Columns["AppointmentID"].HeaderText = "A. ID";
            dgvData.Columns["PatientName"].HeaderText = "Patient Name";
            dgvData.Columns["DoctorName"].HeaderText = "Doctor Name";
            dgvData.Columns["VisitDate"].HeaderText = "Date";
            dgvData.Columns["VisitTime"].HeaderText = "Time";
            dgvData.Columns["VisitStatus"].HeaderText = "V. Status";
            dgvData.Columns["EmergencyIncome"].HeaderText = "EMERG";
            dgvData.Columns["VisitReason"].HeaderText = "V. Reason";
            dgvData.Columns["PaymentAmount"].HeaderText = "Payment";
            dgvData.Columns["PaidAmount"].HeaderText = "Paid";
            dgvData.Columns["PaymentStatus"].HeaderText = "P. Status";

            _Organize_dgvDataColumnWidth();
        }
        ///////////////

        // {Filters}
        void _FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                _dgv_Refresh();
                return;
            }

            DataView view = dtVisits.DefaultView;

            if (cbxFilter.SelectedIndex == 1)
            {
                view.RowFilter = $"VisitID = {tbxFilter.Content} {((!string.IsNullOrEmpty(filter))? $"AND {filter}" : "")}";
            }
            else
            {
                view.RowFilter = $"{dtVisits.Columns[cbxFilter.SelectedIndex].ColumnName} LIKE '{tbxFilter.Content}%' {((!string.IsNullOrEmpty(filter)) ? $"AND {filter}" : "")}";
            }

            dgvData.DataSource = view;
        }

        void _StatusFilterHandler()
        {
            if (cbxSubFilter.SelectedIndex == 0)
            {
                _dgv_Refresh();
                return;
            }

            DataView view = dtVisits.DefaultView;
            view.RowFilter = $"VisitStatus = '{cbxSubFilter.SelectedItem}' {((!string.IsNullOrEmpty(filter)) ? $"AND {filter}" : "")}";
            dgvData.DataSource = view;
        }
        /////////////

        public frmManageVisits()
        {
            InitializeComponent();

            contextMenuStrip.Renderer = new MyMenuRenderer();
            dgvData.ContextMenuStrip = contextMenuStrip;

            Mode = enMode.Admin;
        }

        private void frmManageVisits_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin &&
                clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Doctor &&
                clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Receptionist)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            if (clsProgramSettings.CurrentUser.PermissionTypeEnum == clsUser.enPermissionType.Doctor)
            {
                Mode = enMode.Doctor;
            }

            cdpDate.Content = DateTime.Now;

            _Organize_dgvData();
        }

        private void schDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            cdpDate.Enabled = schDateFilter.Checked;

            _Organize_dgvData();
        }

        private void frmManageVisits_SizeChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
                _Organize_dgvDataColumnWidth();
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (dgvData.Visible)
                _FilterHandler();
        }

        private void cbxSubFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvData.Visible)
                _StatusFilterHandler();
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter.SelectedIndex == 1)
            {
                if (!clsValidation.IsDigit(e.KeyChar)) e.Handled = true;
            }
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex != 4);
            cbxSubFilter.Visible = (cbxFilter.SelectedIndex == 4);

            if (dgvData.Visible)
                _dgv_Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddVisit visit = new frmAddVisit();
            visit.ShowDialog();

            _Organize_dgvData();
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowVisitInfo visit = new frmShowVisitInfo(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            visit.ShowDialog();

            _dgv_Refresh();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmEditVisit visit = new frmEditVisit(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            visit.ShowDialog();

            _dgv_Refresh();
        }

        private void logsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowLogs logs = new frmShowLogs("Visits", int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            logs.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to delete this visit with the ID[{dgvData.CurrentRow.Cells[0].Value.ToString()}], this also means deleting the related data such as payments and examinations.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsVisit.DeleteVisit(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The visit has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Delete))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The visit was not deleted because it is connected to other data in the database.", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _Organize_dgvData();
        }

        private void setInProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show("Are you sure you want to change this visit to In Progress?", "Change Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsVisit.SetVisitStatus(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()),
                    clsVisit.enVisitStatus.InProgress))
                {
                    MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                _dgv_Refresh();
            }
        }

        private void completeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmEditVisit visit = new frmEditVisit(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            visit.ShowDialog();

            _dgv_Refresh();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show("Are you sure you want to cancel this visit?", "Cancel Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsVisit.SetVisitStatus(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()),
                    clsVisit.enVisitStatus.Cancelled))
                {
                    MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DataTable dtPayments = clsPayment.GetAllPaymentsByVisitID(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));

                    if (dtPayments.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtPayments.Rows)
                        {
                            if (dr["Status"].ToString() != "Cancelled")
                            {
                                clsPayment payment = clsPayment.Find(int.Parse(dr["PaymentID"].ToString()));
                                payment.Status = 2;

                                if (payment.Save())
                                {
                                    if (!clsMisc.MakeLog(clsMisc.enTableName.Payments, payment.PaymentID, clsLog.enActionType.Update))
                                    {
                                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error while updating payment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                _dgv_Refresh();
            }
        }

        private void sendToEmergencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show("Are you sure you want to send this visit to Emergency?", "Change Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsVisit.SetEmergencyTrue(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Error while updating the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()),
                        clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                _dgv_Refresh();
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            contextMenuStrip.Items[1].Enabled = false;
            contextMenuStrip.Items[4].Enabled = false;
            contextMenuStrip.Items[5].Enabled = false;
            contextMenuStrip.Items[6].Enabled = false;
            contextMenuStrip.Items[7].Enabled = false;
            contextMenuStrip.Items[9].Enabled = false;

            clsVisit visit = clsVisit.Find(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));

            if (visit == null) return;

            if (clsProgramSettings.CurrentUser.PermissionTypeEnum == clsUser.enPermissionType.Receptionist)
            {
                contextMenuStrip.Items[0].Enabled = true;
                contextMenuStrip.Items[1].Enabled = false;
                contextMenuStrip.Items[2].Enabled = false;
                contextMenuStrip.Items[4].Enabled = false;
                contextMenuStrip.Items[5].Enabled = false;
                contextMenuStrip.Items[6].Enabled = false;
                contextMenuStrip.Items[7].Enabled = false;
                contextMenuStrip.Items[9].Enabled = false;
                contextMenuStrip.Items[11].Enabled = false;

                if (visit.PaymentAmount > visit.PaidAmount)
                {
                    contextMenuStrip.Items[9].Enabled = true;
                }

                return;
            }


            if (visit.VisitStatusEnum == clsVisit.enVisitStatus.Waiting)
            {
                contextMenuStrip.Items[1].Enabled = true;
                contextMenuStrip.Items[4].Enabled = true;
                contextMenuStrip.Items[6].Enabled = true;
                contextMenuStrip.Items[7].Enabled = true;
            }

            if (visit.VisitStatusEnum == clsVisit.enVisitStatus.InProgress)
            {
                contextMenuStrip.Items[1].Enabled = true;
                contextMenuStrip.Items[5].Enabled = true;
                contextMenuStrip.Items[6].Enabled = true;
                contextMenuStrip.Items[7].Enabled = true;
            }

            if (visit.PaidAmount < visit.PaymentAmount && visit.VisitStatusEnum != clsVisit.enVisitStatus.Cancelled)
            {
                contextMenuStrip.Items[9].Enabled = true;
            }
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmAddPayment payment = new frmAddPayment(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            payment.ShowDialog();

            _dgv_Refresh();
        }
    }
}
