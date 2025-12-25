using Clinic_Manager_Proj.People;
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

namespace Clinic_Manager_Proj.Doctors
{
    public partial class frmShowDoctorInfo : frmMain
    {
        clsDoctor doctor = new clsDoctor();

        public frmShowDoctorInfo(int DoctorID)
        {
            InitializeComponent();

            doctor = clsDoctor.FindByDoctorID(DoctorID);
        }

        private void frmShowDoctorInfo_Load(object sender, EventArgs e)
        {
            if (doctor == null)
            {
                MessageBox.Show("Error while retrieving doctor data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ctrlDoctorCard1.LoadData(doctor.DoctorID);
            ctrlPersonInfoCard1.LoadData(doctor.PersonID);
        }
    }
}
