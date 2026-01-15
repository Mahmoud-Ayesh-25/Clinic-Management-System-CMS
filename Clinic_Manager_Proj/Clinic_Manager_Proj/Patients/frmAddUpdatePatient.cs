using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Patients
{
    public partial class frmAddUpdatePatient : frmMain
    {
        public delegate void DataBackEventHander(int ID);
        public event DataBackEventHander DataBack;

        enum enMode { Add, Update }
        enMode Mode;

        int PatientID = -1;
        clsPatient patient = new clsPatient();

        bool _LoadData()
        {
            patient = clsPatient.FindByPatientID(PatientID);

            if (patient == null) return false;

            ctrlPersonCardWithSearch1.LoadData(patient.PersonID);

            lblID.Content = $"ID: {PatientID}";
            tbxAllergies.Content = patient.Allergies;
            tbxChronicDiseases.Content = patient.ChronicDiseases;
            tbxCurrentEducations.Content = patient.CurrentEducations;
            tbxNotes.Content = patient.Notes;
            schActive.Checked = patient.IsActive;

            return true;
        }

        public frmAddUpdatePatient()
        {
            InitializeComponent();

            Mode = enMode.Add;
            lblMainTitle.Content = "Add New Patient";
            ctrlPersonCardWithSearch1.BringToFront();
        }

        public frmAddUpdatePatient(int PatientID)
        {
            InitializeComponent();

            this.PatientID = PatientID;
            Mode = enMode.Update;
            lblMainTitle.Content = "Edit Patient";
            pnlDoctorDetails.BringToFront();
            btnBack.Visible = true;
            btnNext.Visible = false;
            btnSaveUser.Visible = true;
        }

        private void frmAddUpdatePatient_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            if (PatientID != -1)
            {
                if (!_LoadData())
                {
                    MessageBox.Show("Error while retrieving patient data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithSearch1.PersonID != -1)
            {
                if (clsPatient.FindByPersonID(ctrlPersonCardWithSearch1.PersonID) != null && ctrlPersonCardWithSearch1.PersonID != patient.PersonID)
                {
                    MessageBox.Show("This person is already a patient.", "Cannot Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    btnSaveUser.Visible = true;
                    btnNext.Visible = false;
                    btnBack.Visible = true;
                    pnlDoctorDetails.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("You have to choose a person first.", "Cannot Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnSaveUser.Visible = false;
            btnNext.Visible = true;
            btnBack.Visible = false;
            ctrlPersonCardWithSearch1.BringToFront();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            patient.PersonID = ctrlPersonCardWithSearch1.PersonID;
            patient.Allergies = tbxAllergies.Content;
            patient.ChronicDiseases = tbxChronicDiseases.Content;
            patient.CurrentEducations = tbxCurrentEducations.Content;
            patient.Notes = tbxNotes.Content;
            patient.IsActive = schActive.Checked;

            if (patient.Save())
            {
                if (Mode == enMode.Add)
                {
                    Mode = enMode.Update;
                    PatientID = patient.PatientID;
                    lblID.Content = $"ID: {PatientID}";
                    lblMainTitle.Content = "Edit Patient";
                    ctrlPersonCardWithSearch1.LoadData(patient.PersonID);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Patients, PatientID, clsLog.enActionType.AddNew))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Patients, PatientID, clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                DataBack?.Invoke(patient.PatientID);

                MessageBox.Show($"The patient has been saved successfully with ID[{PatientID}].", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"An error occurred while saving the patient, most likely due to a connection error with the database, either because it was deleted or because it was moved from its expected location.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
