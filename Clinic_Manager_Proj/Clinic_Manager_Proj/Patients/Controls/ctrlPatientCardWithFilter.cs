using CMS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Patients.Controls
{
    public partial class ctrlPatientCardWithFilter : UserControl
    {
        public int PatientID { get { return patient.PatientID; } }
        clsPatient patient = new clsPatient();

        public bool LoadData(int PatientID)
        {
            patient = clsPatient.FindByPatientID(PatientID);
            if (patient == null) { patient = new clsPatient(); return false; }

            if (!ctrlPatientCard1.LoadData(PatientID)) return false;
            if (!ctrlPersonInfoCard1.LoadData(patient.PersonID)) return false;

            btnSelect.Visible = false;
            btnAddPatient.Visible = false;

            return true;
        }

        void _LoadDataForDataBack(int PatientID)
        {
            if (LoadData(PatientID) == false)
            {
                MessageBox.Show("Error while selecting the patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPatientCard1.LoadDefaultData();
                ctrlPersonInfoCard1.LoadDefaultValues();
                return;
            }

            btnSelect.Visible = true;
            btnAddPatient.Visible = true;
        }

        public ctrlPatientCardWithFilter()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectPatient patient = new frmSelectPatient();
            patient.DataBack += _LoadDataForDataBack;
            patient.ShowDialog();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddUpdatePatient patient = new frmAddUpdatePatient();
            patient.DataBack += _LoadDataForDataBack;
            patient.ShowDialog();
        }
    }
}
