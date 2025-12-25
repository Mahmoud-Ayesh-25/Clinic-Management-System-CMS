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
    public partial class ctrlDoctorCard : UserControl
    {
        clsDoctor doctor = new clsDoctor();
        public int DoctorID { get { return doctor.DoctorID; } }

        public bool LoadData(int DoctorID)
        {
            doctor = clsDoctor.FindByDoctorID(DoctorID);

            if (doctor == null) return false;

            lblID.Content = $"ID: {doctor.DoctorID}";
            lblSpecialization.Content = $"Specialization: {doctor.Specialization}";
            lblSubSpecialization.Content = $"Sub Specialization: {doctor.SubSpecialization}";
            lblLicenseNo.Content = $"License Number: {doctor.LicenseNo}";
            lblLicenseIssueDate.Content = $"License Issue Date: {doctor.LicenseIssueDate.ToShortDateString()}";
            lblLicenseExpDate.Content = $"License Exp Date: {doctor.LicenseExpDate.ToShortDateString()}";
            lblWeekDays.Content = $"Week Days: {doctor.WeekDays}";
            lblExperYears.Content = $"Experience Years: {doctor.ExperienceYears}";
            lblWorkFrom.Content = $"Work From: {doctor.WorkHourFrom.ToShortTimeString()}";
            lblWorkTo.Content = $"Work To: {doctor.WorkHourTo.ToShortTimeString()}";
            lblExaminationPrice.Content = $"Examination Price: {doctor.ExaminationPrice}";
            lblActive.Content = $"Is Active: {((doctor.IsActive)? "Yes" : "No")}";

            return true;
        }

        public ctrlDoctorCard()
        {
            InitializeComponent();
        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            if (DoctorID == -1) return;

            frmAddUpdateDoctor doctor = new frmAddUpdateDoctor(DoctorID);
            doctor.ShowDialog();

            LoadData(DoctorID);
        }
    }
}
