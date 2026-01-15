using Clinic_Manager_Proj.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CMS_BusinessLayer;
using CuoreUI.Controls;

namespace Clinic_Manager_Proj.Visits
{
    public partial class frmEditVisit : frmMain
    {
        int VisitID = -1;
        clsVisit visit = new clsVisit();
        clsExamination examination = new clsExamination();

        //{LoadData}
        bool _LoadVisitData()
        {
            visit = clsVisit.Find(VisitID);

            if (visit == null) return false;

            lblID.Content = $"ID: {visit.VisitID}";
            lblPatientName.Content = $"Patient Name: {visit.PatientInfo.PersonInfo.FullName}";
            lblDoctorName.Content = $"Doctor Name: {visit.DoctorInfo.PersonInfo.FullName}";
            schEMERG.Checked = visit.EmergencyIncome;

            return true;
        }

        bool _LoadExaminationData()
        {
            examination = clsExamination.Find(visit.ExaminationID);

            if (examination == null) return false;

            tbxSymptoms.Content = examination.Symptoms;
            tbxDiagnosis.Content = examination.Diagnosis;
            tbxNotes.Content = examination.Notes;
            tbxPrescription.Content = examination.Prescription;

            return true;
        }
        //////////////

        bool _IsAllFieldsFilled()
        {
            if (string.IsNullOrEmpty(tbxSymptoms.Content)) return false;
            if (string.IsNullOrEmpty(tbxDiagnosis.Content)) return false;
            if (string.IsNullOrEmpty(tbxPrescription.Content)) return false;

            return true;
        }

        public frmEditVisit(int VisitID)
        {
            InitializeComponent();

            this.VisitID = VisitID;
        }

        private void frmEditVisit_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin &&
                clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Receptionist)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            if (!_LoadVisitData())
            {
                MessageBox.Show("Error while retrieving visit data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (visit.ExaminationID != -1)
            {
                if (!_LoadExaminationData())
                {
                    MessageBox.Show("Error while retrieving doctors data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void tbxSymptoms_Validating(object sender, CancelEventArgs e)
        {
            cuiTextBox tbx = ((cuiTextBox)sender);

            if (string.IsNullOrEmpty(tbx.Content))
            {
                tbx.OutlineColor = Color.Red;
                tbx.PlaceholderColor = Color.Red;
                tbx.ForeColor = Color.Red;
                tbx.PlaceholderText = "Required";
            }
            else
            {
                tbx.OutlineColor = Color.Black;
                tbx.PlaceholderColor = Color.DimGray;
                tbx.ForeColor = Color.White;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsAllFieldsFilled())
            {
                MessageBox.Show("Make sure to fill in all the required fields.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            examination.Symptoms = tbxSymptoms.Content;
            examination.Diagnosis = tbxDiagnosis.Content;
            examination.Notes = tbxNotes.Content;
            examination.Prescription = tbxPrescription.Content;

            if (examination.Save())
            {
                if (!clsMisc.MakeLog(clsMisc.enTableName.Examinations, examination.ExaminationID, (visit.ExaminationID == -1)? clsLog.enActionType.AddNew : clsLog.enActionType.Update))
                {
                    MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                visit.EmergencyIncome = schEMERG.Checked;
                visit.ExaminationID = examination.ExaminationID;

                if (visit.VisitStatusEnum == clsVisit.enVisitStatus.Waiting || visit.VisitStatusEnum == clsVisit.enVisitStatus.InProgress)
                    visit.VisitStatus = 3;

                if (visit.Save())
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, visit.VisitID, clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show($"The visit has been saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show($"An error occurred while saving the visit, most likely due to a connection error with the database, either because it was deleted or because it was moved from its expected location.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"An error occurred while saving the visit, most likely due to a connection error with the database, either because it was deleted or because it was moved from its expected location.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
