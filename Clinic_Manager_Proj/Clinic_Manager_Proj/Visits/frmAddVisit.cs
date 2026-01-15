using Clinic_Manager_Proj.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CMS_BusinessLayer;
using DVLD_Project.MainSettings;

namespace Clinic_Manager_Proj.Visits
{
    public partial class frmAddVisit : frmMain
    {
        int AppointmentID = -1;

        DataTable doctors = new DataTable();

        DataTable paymentMethods = new DataTable();

        float PaymentAmount = 0;

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

        bool _LoadAppointmentData()
        {
            clsAppointment appointment = clsAppointment.Find(AppointmentID);

            if (appointment == null) return false;

            lblAID.Content = $"Appointment ID: {AppointmentID}";
            cbxDoctor.SelectedItem = string.Empty;
            cbxDoctor.SelectedItem = appointment.DoctorInfo.PersonInfo.FirstName + " " + appointment.DoctorInfo.PersonInfo.LastName;
            cbxDoctor.Enabled = false;
            lblPayment.Content = $"Payment Amount {appointment.DoctorInfo.ExaminationPrice}";
            PaymentAmount = appointment.DoctorInfo.ExaminationPrice;
            ctrlPatientCardWithFilter1.LoadData(appointment.PatientID);

            pnlAppointmentDetails.BringToFront();
            btnBack.Visible = true;
            btnNext.Visible = false;
            btnSaveVisit.Visible = true;

            return true;
        }

        void _SetPaymentAmount()
        {
            PaymentAmount = float.Parse(doctors.Rows[cbxDoctor.SelectedIndex]["ExaminationPrice"].ToString());
            lblPayment.Content = $"Payment Amount: {PaymentAmount}";
        }

        bool _LoadPaymentMethods()
        {
            paymentMethods = clsPaymentMethod.GetAllPaymentMethods();

            if (paymentMethods == null || paymentMethods.Rows.Count == 0) return false;

            foreach (DataRow row in paymentMethods.Rows)
            {
                cbxPaymentMethod.AddItem(row[1].ToString());

                if (cbxPaymentMethod.SelectedItem == string.Empty)
                    cbxPaymentMethod.SelectedItem = row[1].ToString();
            }

            return true;
        }

        public frmAddVisit(int AppointmentID = -1)
        {
            InitializeComponent();

            ctrlPatientCardWithFilter1.BringToFront();
            this.AppointmentID = AppointmentID;

            cbxVisitReason.SelectedItem = "New Examination";

        }

        private void frmAddVisit_Load(object sender, EventArgs e)
        {
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

            if (!_LoadPaymentMethods())
            {
                MessageBox.Show("Error while retrieving payment methods data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (AppointmentID != -1)
            {
                if (!_LoadAppointmentData())
                {
                    MessageBox.Show("Error while retrieving appointment data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPatientCardWithFilter1.PatientID != -1)
            {
                btnSaveVisit.Visible = true;
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
            btnSaveVisit.Visible = false;
            btnNext.Visible = true;
            btnBack.Visible = false;
            ctrlPatientCardWithFilter1.BringToFront();
        }

        private void cbxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctors.Rows.Count > 0)
                _SetPaymentAmount();
        }

        private void tbxPaid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPaid.Content) || float.Parse(tbxPaid.Content) > PaymentAmount)
            {
                tbxPaid.PlaceholderColor = Color.Red;
                tbxPaid.PlaceholderText = "Required";
                tbxPaid.OutlineColor = Color.Red;
                tbxPaid.ForeColor = Color.Red;
            }
            else
            {
                tbxPaid.PlaceholderColor = Color.DimGray;
                tbxPaid.OutlineColor = Color.Black;
                tbxPaid.ForeColor = Color.White;
            }
        }

        private void tbxPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidation.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '.') return;
                e.Handled = true;
            }
        }

        private void btnSaveVisit_Click(object sender, EventArgs e)
        {
            if (cbxVisitReason.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(tbxPaid.Content))
                {
                    MessageBox.Show("Make sure to fill in all the required fields.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                if (float.Parse(tbxPaid.Content) > PaymentAmount)
                {
                    MessageBox.Show("Paid Amount > Payment Amount.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }

            clsVisit visit = new clsVisit();

            visit.AppointmentID = this.AppointmentID;
            visit.PatientID = ctrlPatientCardWithFilter1.PatientID;

            foreach (DataRow row in doctors.Rows)
            {
                if (row[2].ToString() == cbxDoctor.SelectedItem)
                {
                    visit.DoctorID = int.Parse(row[0].ToString());
                    break;
                }
            }

            visit.VisitDate = DateTime.Now;
            visit.VisitTime = new DateTime(1800,1,1,DateTime.Now.Hour, DateTime.Now.Minute, 0);
            visit.VisitStatus = 1;
            visit.VisitReason = cbxVisitReason.SelectedIndex + 1;
            
            if (cbxVisitReason.SelectedIndex == 0)
            {
                visit.PaymentAmount = this.PaymentAmount;
            }
            else
            {
                visit.PaymentAmount = 0;
            }

            visit.EmergencyIncome = schEMERG.Checked;

            if (visit.Save())
            {
                if (visit.AppointmentID != -1)
                {
                    if (!clsAppointment.SetAppointmentStatus(visit.AppointmentID, clsAppointment.enStatus.Completed))
                    {
                        MessageBox.Show("Error while updating the appointment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!clsMisc.MakeLog(clsMisc.enTableName.Appointments, visit.AppointmentID, clsLog.enActionType.Update))
                        {
                            MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (cbxVisitReason.SelectedIndex == 0)
                {
                    clsPayment payment = new clsPayment();

                    payment.VisitID = visit.VisitID;
                    payment.PaidAmount = float.Parse(tbxPaid.Content);

                    foreach (DataRow row in paymentMethods.Rows)
                    {
                        if (row[1].ToString() == cbxPaymentMethod.SelectedItem)
                        {
                            payment.PaymentMethodID = int.Parse(row[0].ToString());
                            break;
                        }
                    }

                    payment.Date = visit.VisitDate;
                    payment.Status = 1;

                    if (payment.Save())
                    {
                        if (!clsMisc.MakeLog(clsMisc.enTableName.Payments, payment.PaymentID, clsLog.enActionType.AddNew))
                        {
                            MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                lblVID.Content = $"Visit ID: {visit.VisitID}";

                if (!clsMisc.MakeLog(clsMisc.enTableName.Visits, visit.VisitID, clsLog.enActionType.AddNew))
                {
                    MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show($"The visit has been saved successfully with ID[{visit.VisitID}].", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show($"An error occurred while saving the visit, most likely due to a connection error with the database, either because it was deleted or because it was moved from its expected location.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxVisitReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxPaid.Enabled = (cbxVisitReason.SelectedIndex == 0);
        }
    }
}
