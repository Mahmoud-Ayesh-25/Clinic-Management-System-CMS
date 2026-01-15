using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.People;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CMS_BusinessLayer;
using DVLD_Project;
using DVLD_Project.MainSettings;
using Clinic_Manager_Proj.Logs;

namespace Clinic_Manager_Proj.Doctors
{
    public partial class frmManageDoctors : frmMainFormForManage
    {
        DataTable dtDoctors = new DataTable();

        //{LoadData}
        void _dgv_Refresh()
        {
            dtDoctors = clsDoctor.GetAllDoctors();
            dgvData.DataSource = dtDoctors;
        }

        void _Organize_dgvDataColumnsWidth()
        {
            dgvData.Columns["DoctorID"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["NationalNo"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["Name"].Width = (dgvData.Width * 10) / 100;
            dgvData.Columns["Gender"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["Phone"].Width = (dgvData.Width * 6) / 100;
            dgvData.Columns["Specialization"].Width = (dgvData.Width * 9) / 100;
            dgvData.Columns["SubSpecialization"].Width = (dgvData.Width * 9) / 100;
            dgvData.Columns["LicenseNo"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["LicenseIssueDate"].Width = (dgvData.Width * 6) / 100;
            dgvData.Columns["LicenseExpDate"].Width = (dgvData.Width * 6) / 100;
            dgvData.Columns["ExperienceYears"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["WeekDays"].Width = (dgvData.Width * 9) / 100;
            dgvData.Columns["WorkHoureFrom"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["WorkHoureTo"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["ExaminationPrice"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["IsActive"].Width = ((dgvData.Width * 5) / 100) + 10;
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

            dgvData.Columns["DoctorID"].HeaderText = "ID";
            dgvData.Columns["NationalNo"].HeaderText = "Nat No";
            dgvData.Columns["Name"].HeaderText = "Name";
            dgvData.Columns["Gender"].HeaderText = "Gender";
            dgvData.Columns["Phone"].HeaderText = "Phone";
            dgvData.Columns["Specialization"].HeaderText = "Specialization";
            dgvData.Columns["SubSpecialization"].HeaderText = "Sub Specialization";
            dgvData.Columns["LicenseNo"].HeaderText = "License No";
            dgvData.Columns["LicenseIssueDate"].HeaderText = "Lic Issue Date";
            dgvData.Columns["LicenseExpDate"].HeaderText = "Lic Exp Date";
            dgvData.Columns["ExperienceYears"].HeaderText = "Experience";
            dgvData.Columns["WeekDays"].HeaderText = "Week Days";
            dgvData.Columns["WorkHoureFrom"].HeaderText = "Work From";
            dgvData.Columns["WorkHoureTo"].HeaderText = "Work To";
            dgvData.Columns["ExaminationPrice"].HeaderText = "Price";
            dgvData.Columns["IsActive"].HeaderText = "Active";

            _Organize_dgvDataColumnsWidth();
        }
        ///////////////

        void _FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                _dgv_Refresh();
                return;
            }

            DataView view = dtDoctors.DefaultView;

            if (cbxFilter.SelectedIndex == 1)
            {
                view.RowFilter = $"DoctorID = {tbxFilter.Content}";
            }
            else
            {
                view.RowFilter = $@"{((cbxFilter.SelectedIndex > 4)? dtDoctors.Columns[cbxFilter.SelectedIndex].ColumnName :
                    dtDoctors.Columns[cbxFilter.SelectedIndex - 1].ColumnName)} LIKE '{tbxFilter.Content}%'";
            }

            dgvData.DataSource = view;
        }
        void _GenderFilterHandler()
        {
            if (cbxSubFilter.SelectedIndex == 0)
            {
                _dgv_Refresh();
                return;
            }
            else
            {
                DataView view = dtDoctors.DefaultView;
                view.RowFilter = $"Gender = '{cbxSubFilter.SelectedItem}'";
                dgvData.DataSource = view;
            }
        }

        public frmManageDoctors()
        {
            InitializeComponent();

            dgvData.ContextMenuStrip = contextMenuStrip;
            contextMenuStrip.Renderer = new MyMenuRenderer();
        }

        private void frmManageDoctors_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            _Organize_dgvData();
        }

        private void frmManageDoctors_SizeChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count > 0)
                _Organize_dgvDataColumnsWidth();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvData.Columns.Count == 0) return;
                
            _Organize_dgvData();
            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex != 4);
            cbxSubFilter.Visible = (cbxFilter.SelectedIndex == 4);
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            _FilterHandler();
        }

        private void cbxSubFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GenderFilterHandler();
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

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmAddUpdateDoctor doctor = new frmAddUpdateDoctor(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            doctor.ShowDialog();

            _dgv_Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor doctor = new frmAddUpdateDoctor();
            doctor.ShowDialog();

            if (dgvData.Visible == false)
            {
                _Organize_dgvData();
            }
            else
            {
                _dgv_Refresh();
            }
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowDoctorInfo doctor = new frmShowDoctorInfo(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            doctor.ShowDialog();

            _dgv_Refresh();
        }

        private void logsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowLogs logs = new frmShowLogs("Doctors", int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            logs.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to delete this doctor with the ID[{dgvData.CurrentRow.Cells[0].Value.ToString()}]",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsDoctor.DeleteDoctor(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The doctor has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Doctors, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Delete))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The doctor was not deleted because it is connected to other data in the database.", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _Organize_dgvData();
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to activate the doctor with the ID[{int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())}]?"
                , "Confirm Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsDoctor.ActivateDoctor(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The doctor has been successfully activated.", "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Doctors, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error while activate the doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _dgv_Refresh();
        }

        private void deactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to deactivate the doctor with the ID[{int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())}]?"
                , "Confirm Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsDoctor.DeactivateDoctor(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The doctor has been successfully deactivated.", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Doctors, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error while deactivate the doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _dgv_Refresh();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            bool active = (bool)dgvData.CurrentRow.Cells[15].Value;

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
    }
}
