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

namespace Clinic_Manager_Proj.Visits.Controls
{
    public partial class ctrlVisitCard : UserControl
    {
        public int VisitID { get { return visit.VisitID; } }
        clsVisit visit = new clsVisit();

        clsExamination examination = new clsExamination();

        bool _LoadExaminationData(int ExaminationID)
        {
            examination = clsExamination.Find(ExaminationID);

            if (examination == null) return false;

            lblExID.Content = $"Examination ID: {examination.ExaminationID}";
            lblSymptoms.Content = $"Symptoms: {examination.Symptoms}";
            lblDiagnosis.Content = $"Diagnosis: {examination.Diagnosis}";
            lblNotes.Content = $"Notes: {examination.Notes}";
            lblPrescription.Content = $"Prescription: {examination.Prescription}";

            return true;
        }

        public bool LoadData(int VisitID)
        {
            visit = clsVisit.Find(VisitID);

            if (visit == null) return false;

            lblID.Content = $"Visit ID: {visit.VisitID}";
            lblAID.Content = $"Appointment ID: {visit.AppointmentID}";
            lblPatientName.Content = $"Patient Name: {visit.PatientInfo.PersonInfo.FullName}";
            lblDoctorName.Content = $"Doctor Name: {visit.DoctorInfo.PersonInfo.FullName}";
            lblDate.Content = $"Date: {visit.VisitDate.ToShortDateString()}";
            lblTime.Content = $"Time: {visit.VisitTime.ToShortTimeString()}";
            lblStatus.Content = $"Status: {visit.VisitStatusEnum.ToString()}";
            lblVisitReason.Content = $"Visit Reason: {visit.VisitReasonEnum.ToString()}";
            lblEmergency.Content = $"Emergency Income: {((visit.EmergencyIncome)? "Yes" : "No")}";
            lblPayment.Content = $"Payment Amount: {visit.PaymentAmount}";
            lblPaidAmount.Content = $"Paid Amount: {visit.PaidAmount}";
            lblPaymentStatus.Content = $"Payment Status: {visit.PaymentStatusEnum.ToString()}";

            return _LoadExaminationData(visit.ExaminationID);
        }

        public ctrlVisitCard()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditVisit visit = new frmEditVisit(VisitID);
            visit.ShowDialog();

            LoadData(VisitID);
        }
    }
}
