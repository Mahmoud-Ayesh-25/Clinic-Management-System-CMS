using Clinic_Manager_Proj.Doctors;
using Clinic_Manager_Proj.People.Controls;
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

namespace Clinic_Manager_Proj.Appointments
{
    public partial class frmShowAppointmentInfo : frmMain
    {
        clsAppointment appointment = new clsAppointment();

        public frmShowAppointmentInfo(int AppointmentID)
        {
            InitializeComponent();

            appointment = clsAppointment.Find(AppointmentID);
        }

        private void frmShowAppointmentInfo_Load(object sender, EventArgs e)
        {
            if (appointment == null)
            {
                MessageBox.Show("Error while retrieving appointment data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ctrlAppointmentCard1.LoadData(appointment.AppointmentID);
        }
    }
}
