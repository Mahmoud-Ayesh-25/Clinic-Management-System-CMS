using CMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Patients.Controls
{
    public partial class ctrlPatientCard : UserControl
    {
        public int PatientID { get { return patient.PatientID; } }
        clsPatient patient = new clsPatient();

        public bool LoadData(int PatientID)
        {
            patient = clsPatient.FindByPatientID(PatientID);

            if (patient == null) { return false; }

            lblID.Content = $"ID: {patient.PatientID}";
            lblAllergies.Content = $"Allergies: {patient.Allergies}";
            lblChronicDiseases.Content = $"Chronic Diseases: {patient.ChronicDiseases}";
            lblCurrentMedications.Content = $"Current Medications: {patient.CurrentEducations}";
            lblNotes.Content = $"Notes: {patient.Notes}";
            lblActive.Content = $"Is Active: {((patient.IsActive) ? "Yes" : "No")}";

            return true;
        }

        public void LoadDefaultData()
        {
            lblID.Content = $"ID: ";
            lblAllergies.Content = $"Allergies: ";
            lblChronicDiseases.Content = $"Chronic Diseases: ";
            lblCurrentMedications.Content = $"Current Medications: ";
            lblNotes.Content = $"Notes: ";
            lblActive.Content = $"Is Active: ";
        }

        public ctrlPatientCard()
        {
            InitializeComponent();
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (PatientID == -1) return;

            frmAddUpdatePatient patient = new frmAddUpdatePatient(PatientID);
            patient.ShowDialog();

            LoadData(PatientID);
        }
    }
}
