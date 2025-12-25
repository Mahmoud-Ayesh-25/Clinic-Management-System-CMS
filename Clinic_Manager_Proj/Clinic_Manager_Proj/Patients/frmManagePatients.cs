using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Logs;
using Clinic_Manager_Proj.People;
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

namespace Clinic_Manager_Proj.Patients
{
    public partial class frmManagePatients : frmMainFormForManage
    {
        DataTable dtPatients = new DataTable();

        //{LoadData}
        void _dgv_Refresh()
        {
            dtPatients = clsPatient.GetAllPatients();
            dgvData.DataSource = dtPatients;
        }

        void _Organize_dgvDataColumnWidth()
        {
            dgvData.Columns["PatientID"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["Name"].Width = (dgvData.Width * 17) / 100;
            dgvData.Columns["Gender"].Width = (dgvData.Width * 5) / 100;
            dgvData.Columns["Allergies"].Width = (dgvData.Width * 17) / 100;
            dgvData.Columns["ChronicDiseases"].Width = (dgvData.Width * 17) / 100;
            dgvData.Columns["CurrentEducations"].Width = (dgvData.Width * 17) / 100;
            dgvData.Columns["Notes"].Width = (dgvData.Width * 17) / 100;
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

            dgvData.Columns["CreateDate"].Visible = false;

            dgvData.Columns["PatientID"].HeaderText = "ID";
            dgvData.Columns["Name"].HeaderText = "Name";
            dgvData.Columns["Gender"].HeaderText = "Gender";
            dgvData.Columns["Allergies"].HeaderText = "Allergies";
            dgvData.Columns["ChronicDiseases"].HeaderText = "Chronic Diseases";
            dgvData.Columns["CurrentEducations"].HeaderText = "Current Educations";
            dgvData.Columns["Notes"].HeaderText = "Notes";
            dgvData.Columns["IsActive"].HeaderText = "Active";

            _Organize_dgvDataColumnWidth();
        }
        /////////////

        //{FilterHandler}
        void _FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                _dgv_Refresh();
                return;
            }

            DataView view = dtPatients.DefaultView;

            if (cbxFilter.SelectedIndex == 1)
            {
                view.RowFilter = $"PatientID = {tbxFilter.Content}";
            }
            else
            {
                view.RowFilter = $"{dtPatients.Columns[cbxFilter.SelectedIndex - 1].ColumnName} LIKE '{tbxFilter.Content}%'";
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

            DataView view = dtPatients.DefaultView;
            view.RowFilter = $"Gender = '{cbxSubFilter.SelectedItem}'";
            dgvData.DataSource = view;
        }
        /////////////////
        public frmManagePatients()
        {
            InitializeComponent();
        }

        private void frmManagePatients_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            dgvData.ContextMenuStrip = contextMenuStrip;
            contextMenuStrip.Renderer = new MyMenuRenderer();
            _Organize_dgvData();
        }

        private void frmManagePatients_SizeChanged(object sender, EventArgs e)
        {
            if (dgvData.Visible != false)
                _Organize_dgvDataColumnWidth();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvData.Visible == false) return;

            _dgv_Refresh();

            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex != 3);
            cbxSubFilter.Visible = (cbxFilter.SelectedIndex == 3);
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (dgvData.Visible == false) return;

            _FilterHandler();
        }

        private void cbxSubFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvData.Visible == false) return;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePatient patient = new frmAddUpdatePatient();
            patient.ShowDialog();

            _Organize_dgvData();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmAddUpdatePatient patient = new frmAddUpdatePatient(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            patient.ShowDialog();

            _dgv_Refresh();
        }

        private void logsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowLogs logs = new frmShowLogs("Patients", int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            logs.ShowDialog();
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            frmShowPatientInfo patient = new frmShowPatientInfo(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()));
            patient.ShowDialog();

            _dgv_Refresh();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to delete this patient with the ID[{dgvData.CurrentRow.Cells[0].Value.ToString()}]",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPatient.DeletePatient(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The patient has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Patients, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Delete))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The patient was not deleted because it is connected to other data in the database.", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _Organize_dgvData();
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to activate the patient with the ID[{int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())}]?"
                , "Confirm Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPatient.ActivatePatient(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The patient has been successfully activated.", "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Patients, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error while activate the patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _dgv_Refresh();
        }

        private void deactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            if (MessageBox.Show($"Are you sure you want to deactivate the patient with the ID[{int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())}]?"
                , "Confirm Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPatient.DeactivatePatient(int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The patient has been successfully deactivated.", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Patients, int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString()), clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error while deactivate the patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _dgv_Refresh();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            bool active = (bool)dgvData.CurrentRow.Cells[8].Value;

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
