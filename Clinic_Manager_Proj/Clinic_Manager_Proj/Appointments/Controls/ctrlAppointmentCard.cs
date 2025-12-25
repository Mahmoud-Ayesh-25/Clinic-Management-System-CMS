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

namespace Clinic_Manager_Proj.Appointments.Controls
{
    public partial class ctrlAppointmentCard : UserControl
    {
        int AppointmentID { get { return appointment.AppointmentID; } }
        clsAppointment appointment = new clsAppointment();

        public bool LoadData(int AppointmentID)
        {
            appointment = clsAppointment.Find(AppointmentID);
            if (appointment == null) return false;

            lblID.Content = $"Appointment ID: {appointment.AppointmentID}";
            lblPatientName.Content = $"Patient Name: {appointment.PatientInfo.PersonInfo.FullName}";
            lblDoctorName.Content = $"Doctor Name: {appointment.DoctorInfo.PersonInfo.FullName}";
            lblDate.Content = $"Date: {appointment.Date.ToShortDateString()}";
            lblTime.Content = $"Time: {appointment.Time.ToShortTimeString()}";
            lblStatus.Content = $"Status: {appointment.StatusEnum}";
            lblNotes.Content = $"Notes: {appointment.Notes}";

            return true;
        }

        public ctrlAppointmentCard()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateAppointment appointment = new frmAddUpdateAppointment(AppointmentID);
            appointment.ShowDialog();
            LoadData(AppointmentID);
        }
    }
}
