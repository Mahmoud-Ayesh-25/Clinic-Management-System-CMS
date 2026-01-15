using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using DVLD_Project.MainSettings;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Payments
{
    public partial class frmAddPayment : frmMain
    {
        int VisitID = -1;
        clsVisit visit = new clsVisit();

        DataTable dtPayments = new DataTable();

        bool _LoadData()
        {
            visit = clsVisit.Find(VisitID);

            if (visit == null) return false;

            lblVisitID.Content = $"Visit ID: {visit.VisitID}";
            lblDoctorName.Content = $"Doctor Name: {visit.DoctorInfo.PersonInfo.FullName}";
            lblPatientName.Content = $"Patient Name: {visit.PatientInfo.PersonInfo.FullName}";
            lblPayment.Content = $"Payment Amount: {visit.PaymentAmount}";
            lblRemaining.Content = $"Remaining Amount: {visit.PaymentAmount - visit.PaidAmount}";

            return true;
        }

        bool _LoadPaymentMethods()
        {
            dtPayments = clsPaymentMethod.GetAllPaymentMethods();

            if (dtPayments.Rows.Count == 0) return false;

            foreach (DataRow dr in dtPayments.Rows)
            {
                cbxPaymentMethod.AddItem(dr[1].ToString());

                if (cbxPaymentMethod.SelectedItem == string.Empty)
                    cbxPaymentMethod.SelectedItem = dr[1].ToString();
            }

            return true;
        }

        public frmAddPayment(int VisitID)
        {
            InitializeComponent();

            this.VisitID = VisitID;
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            if (!_LoadPaymentMethods())
            {
                MessageBox.Show($"Error while retrieving payment methods data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (!_LoadData())
            {
                MessageBox.Show($"The visit with the ID[{VisitID}] was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void tbxPaid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPaid.Content) || (float.Parse(tbxPaid.Content) > (visit.PaymentAmount - visit.PaidAmount)))
            {
                tbxPaid.OutlineColor = Color.Red;
                tbxPaid.ForeColor = Color.Red;
                tbxPaid.PlaceholderColor = Color.Red;
                tbxPaid.PlaceholderText = "Required";
            }
            else
            {
                tbxPaid.OutlineColor = Color.Black;
                tbxPaid.ForeColor = Color.White;
            }
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPaid.Content) || (float.Parse(tbxPaid.Content) > (visit.PaymentAmount - visit.PaidAmount)))
            {
                MessageBox.Show("Check the paid amount field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPayment payment = new clsPayment();

            payment.VisitID = VisitID;
            payment.Status = 1;
            payment.Date = DateTime.Now;
            
            foreach (DataRow row in dtPayments.Rows)
            {
                if (row[1].ToString() == cbxPaymentMethod.SelectedItem)
                {
                    payment.PaymentMethodID = int.Parse(row[0].ToString());
                }
            }

            payment.PaidAmount = float.Parse(tbxPaid.Content);

            if (payment.Save())
            {
                lblPaymentID.Content = $"Payment ID: {payment.PaymentID}";

                if (!clsMisc.MakeLog(clsMisc.enTableName.Payments, payment.PaymentID, clsLog.enActionType.AddNew))
                {
                    MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("The payment has been saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while saving the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidation.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != '.') e.Handled = true;
            }
        }
    }
}
