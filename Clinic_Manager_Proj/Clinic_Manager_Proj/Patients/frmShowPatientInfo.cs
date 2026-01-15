using CMS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Patients
{
    public partial class frmShowPatientInfo : frmMain
    {
        clsPatient patient = new clsPatient();

        public frmShowPatientInfo(int PatientID)
        {
            InitializeComponent();

            patient = clsPatient.FindByPatientID(PatientID);
        }

        private void frmShowPatientInfo_Load(object sender, EventArgs e)
        {
            if (patient == null)
            {
                MessageBox.Show("Error while retrieving patient data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ctrlPatientCard1.LoadData(patient.PatientID);
            ctrlPersonInfoCard1.LoadData(patient.PersonID);
        }
    }
}
