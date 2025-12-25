using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Logs;
using Clinic_Manager_Proj.People;
using Clinic_Manager_Proj.Visits;
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

namespace Clinic_Manager_Proj.Appointments
{
    public partial class frmManageAppointment : frmMainFormForManage
    {
        enum enMode { Admin, Doctor}
        enMode Mode;

        DataTable dtAppointments = new DataTable();

        string filter = string.Empty;

        // {LoadData}
        void _dgv_Refresh()
        {
            filter = string.Empty;

            if (Mode == enMode.Admin)
            {
                dtAppointments = clsAppointment.GetAllAppointments();
            }
            else if (Mode == enMode.Doctor)
            {
                clsDoctor doctor = clsDoctor.FindByPersonID(clsProgramSettings.CurrentUser.PersonID);

                dtAppointments = clsAppointment.GetAppointmentsByDoctorID(doctor.DoctorID);
            }

            if (dtAppointments.Rows.Count == 0) return;

            DataView view = dtAppointments.DefaultView;
            
            if (schDateFilter.Checked)
            {
                view.RowFilter = $"AppointmantDate = '{cdpDate.Content.ToShortDateString().Replace('/', '-')}'";
                filter = view.RowFilter;
            }

            dgvData.DataSource = view;
        }

        void _Organize_dgvDataColumnWidth()
        {
            dgvData.Columns["AppointmentID"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["PatientName"].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns["DoctorName"].Width = (dgvData.Width * 20) / 100;
            dgvData.Columns["AppointmantDate"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["AppointmantTime"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["Status"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["Notes"].Width = ((dgvData.Width * 20) / 100) + 10;
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

            dgvData.Columns["AppointmentID"].HeaderText = "ID";
            dgvData.Columns["PatientName"].HeaderText = "Patient Name";
            dgvData.Columns["DoctorName"].HeaderText = "Doctor Name";
            dgvData.Columns["AppointmantDate"].HeaderText = "Date";
            dgvData.Columns["AppointmantTime"].HeaderText = "Time";
            dgvData.Columns["Status"].HeaderText = "Status";
            dgvData.Columns["Notes"].HeaderText = "Notes";

            _Organize_dgvDataColumnWidth();
        }
        ///////////////

        void _FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                _dgv_Refresh();
                return;
            }

            DataView view = dtAppointments.DefaultView;

            if (cbxFilter.SelectedIndex == 1)
            {
                view.RowFilter = $@"AppointmentID = {tbxFilter.Content}
                                {((!string.IsNullOrEmpty(filter)) ? $"AND {filter}" : "")}";
            }
            else
            {
                view.RowFilter = $@"{dtAppointments.Columns[cbxFilter.SelectedIndex - 1].ColumnName} LIKE '{tbxFilter.Content}%'
                                {((!string.IsNullOrEmpty(filter)) ? $"AND {filter}" : "")}";
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

            DataView view = dtAppointments.DefaultView;

            view.RowFilter = $@"Status = '{cbxSubFilter.SelectedItem}'
                                {((!string.IsNullOrEmpty(filter)) ? $"AND {filter}" : "")}";

            dgvData.DataSource = view;
        }

        public frmManageAppointment()
        {
            InitializeComponent();

            contextMenuStrip.Renderer = new MyMenuRenderer();
            dgvData.ContextMenuStrip = contextMenuStrip;

            Mode = enMode.Admin;
        }

        private void frmManageAppointment_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin &&
                clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Doctor)
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

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (dgvData.Visible)
                _FilterHandler();
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

        private void cbxSubFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvData.Visible)
                _StatusFilterHandler();
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
            frmAddUpdateAppointment appointment = new frmAddUpdateAppointment();
            appointment.ShowDialog();

            _Organize_dgvData();
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowAppointmentInfo appointment = new frmShowAppointmentInfo(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            appointment.ShowDialog();

            _dgv_Refresh();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmAddUpdateAppointment appointment = new frmAddUpdateAppointment(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            appointment.ShowDialog();

            _dgv_Refresh();
        }

        private void logsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowLogs logs = new frmShowLogs("Appointments", int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            logs.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to delete this appointment with the ID[{dgvData.CurrentRow.Cells[0].Value.ToString()}]",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsAppointment.DeleteAppointment(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The appointment has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Appointments, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Delete))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The appointment was not deleted because it is connected to other data in the database.", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _Organize_dgvData();
        }

        private void frmManageAppointment_SizeChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
                _Organize_dgvDataColumnWidth();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            contextMenuStrip.Items[1].Enabled = false;
            contextMenuStrip.Items[4].Enabled = false;
            contextMenuStrip.Items[5].Enabled = false;
            contextMenuStrip.Items[6].Enabled = false;

            clsAppointment app = clsAppointment.Find(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));

            if (app == null) return;

            if (app.StatusEnum == clsAppointment.enStatus.Scheduled)
            {
                contextMenuStrip.Items[1].Enabled = true;
                contextMenuStrip.Items[4].Enabled = true;
                contextMenuStrip.Items[5].Enabled = true;
                contextMenuStrip.Items[6].Enabled = true;
            }
        }

        private void makeVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmAddVisit visit = new frmAddVisit(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            visit.ShowDialog();

            _dgv_Refresh();
        }

        private void setCancelledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show("Are you sure you want to cancel this appointment?", "Cancel Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsAppointment.SetAppointmentStatus(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()),
                    clsAppointment.enStatus.Cancelled))
                {
                    MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Appointments, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                _dgv_Refresh();
            }
        }

        private void setNoShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show("Are you sure you want to change this appointment status to No Show?", "Change Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsAppointment.SetAppointmentStatus(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()),
                    clsAppointment.enStatus.NoShow))
                {
                    MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Appointments, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                _dgv_Refresh();
            }
        }
    }
}