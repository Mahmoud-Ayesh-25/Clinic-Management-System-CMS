using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using CuoreUI.Controls;
using DVLD_Project.MainSettings;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Appointments
{
    public partial class frmAddUpdateAppointment : frmMain
    {
        enum enMode { Add, Update}
        enMode Mode;

        int AppointmentID = -1;
        clsAppointment appointment = new clsAppointment();

        DataTable doctors = new DataTable();

        bool _LoadDoctors()
        {
            doctors = clsDoctor.GetAllDoctors();

            if (doctors == null || doctors.Rows.Count == 0) return false;

            foreach (DataRow row in doctors.Rows)
            {
                cbxDoctor.AddItem(row[2].ToString());

                if (cbxDoctor.SelectedItem == string.Empty)
                    cbxDoctor.SelectedItem = row[2].ToString();
            }

            return true;
        }

        bool _LoadData()
        {
            appointment = clsAppointment.Find(AppointmentID);

            if (appointment == null) return false;

            if (!ctrlPatientCardWithFilter1.LoadData(appointment.PatientID)) return false;

            cbxDoctor.SelectedItem = $"{appointment.DoctorInfo.PersonInfo.FirstName} {appointment.DoctorInfo.PersonInfo.LastName}";
            cdpDate.Content = appointment.Date;

            if (appointment.Time.Hour != 12 &&  appointment.Time.Hour != 0)
            {
                if (appointment.Time.Hour > 12)
                {
                    btnPM.Checked = true;
                    btnAM.Checked = false;

                    tbxHours.Content = (appointment.Time.Hour - 12).ToString();
                }
                else
                {
                    tbxHours.Content = (appointment.Time.Hour).ToString();
                }
            }
            else
            {
                if (appointment.Time.Hour == 12)
                {
                    btnPM.Checked = true;
                    btnAM.Checked = false;
                }
                else
                {
                    btnPM.Checked = false;
                    btnAM.Checked = true;
                }

                tbxHours.Content = "12";
            }
            tbxMin.Content = appointment.Time.Minute.ToString();

            tbxNotes.Content = appointment.Notes;

            cbxDoctor.Enabled = false;

            return true;
        }

        public frmAddUpdateAppointment()
        {
            InitializeComponent();

            Mode = enMode.Add;
            lblMainTitle.Content = "Add New Patient";
            ctrlPatientCardWithFilter1.BringToFront();
            cdpDate.Content = DateTime.Now;
            cbxStatus.Enabled = false;

            btnNext.Visible = true;
            btnBack.Visible = false;
            btnSaveAppointment.Visible = false;
        }

        public frmAddUpdateAppointment(int AppointmentID)
        {
            InitializeComponent();

            Mode = enMode.Update;
            lblMainTitle.Content = "Edit Patient";
            pnlAppointmentDetails.BringToFront();
            this.AppointmentID = AppointmentID;

            btnNext.Visible = false;
            btnBack.Visible = true;
            btnSaveAppointment.Visible = true;
        }

        private void frmAddUpdateAppointment_Load(object sender, EventArgs e)
        {
            cbxStatus.SelectedItem = "Scheduled";
            
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin &&
            clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Receptionist)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            if (!_LoadDoctors())
            {
                MessageBox.Show("Error while retrieving doctors data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (AppointmentID != -1)
            {
                if (!_LoadData())
                {
                    MessageBox.Show("Error while retrieving appointment data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPatientCardWithFilter1.PatientID != -1)
            {
                btnSaveAppointment.Visible = true;
                btnNext.Visible = false;
                btnBack.Visible = true;
                pnlAppointmentDetails.BringToFront();
            }
            else
            {
                MessageBox.Show("You have to choose a patient first.", "Cannot Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnSaveAppointment.Visible = false;
            btnNext.Visible = true;
            btnBack.Visible = false;
            ctrlPatientCardWithFilter1.BringToFront();
        }

        private void tbxHours_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((cuiTextBox)sender).Content))
            {
                ((cuiTextBox)sender).OutlineColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderText = "Required";
                ((cuiTextBox)sender).ForeColor = Color.Red;
            }
            else
            {
                ((cuiTextBox)sender).OutlineColor = Color.Black;
                ((cuiTextBox)sender).PlaceholderColor = Color.DimGray;
                ((cuiTextBox)sender).ForeColor = Color.White;
            }
        }

        private void tbxHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidation.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxHours.Content) || string.IsNullOrEmpty(tbxMin.Content))
            {
                MessageBox.Show("Make sure to fill in all the required fields.", "Cannot Save Now",  MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            // set hour ready to save
            int hour = 0;

            if (tbxHours.Content == "12")
            {
                if (btnPM.Checked) hour = 12;
                else hour = 0;
            }
            else
            {
                if (btnPM.Checked)
                    hour = int.Parse(tbxHours.Content) + 12;
                else
                    hour = int.Parse(tbxHours.Content);
            }
            /////////////////////////

            if (DateTime.Now > new DateTime(cdpDate.Content.Year, cdpDate.Content.Month, cdpDate.Content.Day,
                hour, int.Parse(tbxMin.Content), 0))
            {
                MessageBox.Show("You cannot make an appointment in the past.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            // Get DoctorID
            foreach (DataRow row in doctors.Rows)
            {
                if (row[2].ToString() == cbxDoctor.SelectedItem)
                {
                    appointment.DoctorID = int.Parse(row[0].ToString());
                    break;
                }
            }

            // This check if there appointment between 15 minutes before and 15 minutes after this for the same doctor id.
            int AppID = -1;

            if (clsAppointment.IsThereAppointmentAroundForDoctorID(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                hour, int.Parse(tbxMin.Content), 0), appointment.DoctorID, ref AppID))
            {
                if (Mode == enMode.Update && AppID != appointment.AppointmentID)
                {
                    MessageBox.Show("There is a nearby appointment for the same doctor, change the timing of this appointment slightly.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else if (Mode == enMode.Add)
                {
                    MessageBox.Show("There is a nearby appointment for the same doctor, change the timing of this appointment slightly.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }

            appointment.PatientID = ctrlPatientCardWithFilter1.PatientID;
            appointment.Date = cdpDate.Content;

            appointment.Time = new DateTime(1800, 1, 1, hour, int.Parse(tbxMin.Content), 0);

            appointment.Status = cbxStatus.SelectedIndex + 1;
            appointment.Notes = tbxNotes.Content;

            if (appointment.Save())
            {
                if (Mode == enMode.Add)
                {
                    Mode = enMode.Update;
                    AppointmentID = appointment.AppointmentID;
                    lblID.Content = $"ID: {AppointmentID}";
                    lblMainTitle.Content = "Edit Appointment";
                    ctrlPatientCardWithFilter1.LoadData(appointment.PatientID);

                    if (!clsMisc.MakeLog(clsMisc.enTableName.Appointments, AppointmentID, clsLog.enActionType.AddNew))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.Appointments, AppointmentID, clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show($"The appointment has been saved successfully with ID[{AppointmentID}].", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show($"An error occurred while saving the appointment, most likely due to a connection error with the database, either because it was deleted or because it was moved from its expected location.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
