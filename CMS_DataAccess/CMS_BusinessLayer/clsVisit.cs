using System;
using System.Data;
using System.Windows.Forms;

namespace CMS_BusinessLayer
{
    public class clsVisit
    {
        public enum enVisitStatus { Waiting = 1, InProgress, Completed, Cancelled }

        public enum enVisitReason { NewExamination = 1, FollowUp }

        public enum enPaymentStatus { Paid = 1, PartiallyPaid, UnPaid, Error}

        enum enMode { Add, Update}
        enMode Mode;

        public int VisitID {  get; set; }
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public clsPatient PatientInfo { get { return (PatientID != -1) ? clsPatient.FindByPatientID(PatientID) : new clsPatient(); } }
        public int DoctorID { get; set; }
        public clsDoctor DoctorInfo { get { return (DoctorID != -1) ? clsDoctor.FindByDoctorID(DoctorID) : new clsDoctor(); } }
        public DateTime VisitDate { get; set; }
        public DateTime VisitTime { get; set; }
        public int VisitStatus { get; set; }
        public enVisitStatus VisitStatusEnum { get { return (enVisitStatus)VisitStatus; } }
        public int ExaminationID { get; set; }
        public bool EmergencyIncome { get; set; }
        public int VisitReason { get; set; }
        public enVisitReason VisitReasonEnum { get { return (enVisitReason)VisitReason; } }
        public float PaymentAmount { get; set; }
        public float PaidAmount 
        {
            get
            {
                if (VisitID == -1) return 0;
                else
                {
                    float total = 0;

                    DataTable dtPayments = clsPayment.GetAllPaymentsByVisitID(VisitID);

                    if (dtPayments.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtPayments.Rows)
                        {
                            total += float.Parse(row[2].ToString());
                        }
                    }

                    return total;
                }
            }
        }
        public int PaymentStatus 
        { 
            get
            {
                if (PaidAmount == 0)
                    return 3;
                else if (PaymentAmount == PaidAmount)
                    return 1;
                else if (PaymentAmount > PaidAmount)
                    return 2;
                else
                    return 4;
            }
        }
        public enPaymentStatus PaymentStatusEnum { get { return (enPaymentStatus)PaymentStatus; } }

        public clsVisit()
        {
            Mode = enMode.Add;
            VisitID = -1;
            AppointmentID = -1;
            PatientID = -1;
            DoctorID = -1;
            VisitDate = new DateTime();
            VisitTime = new DateTime();
            VisitStatus = 1;
            ExaminationID = -1;
            EmergencyIncome = false;
            VisitReason = 1;
            PaymentAmount = 0;
        }

        clsVisit(int visitID, int appointmentID, int patientID, int doctorID, DateTime visitDate, DateTime visitTime, int visitStatus,
            int examinationID, bool emergencyIncome, int visitReason, float paymentAmount)
        {
            Mode = enMode.Update;
            VisitID = visitID;
            AppointmentID = appointmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            VisitDate = visitDate;
            VisitTime = visitTime;
            VisitStatus = visitStatus;
            ExaminationID = examinationID;
            EmergencyIncome = emergencyIncome;
            VisitReason = visitReason;
            PaymentAmount = paymentAmount;
        }

        public static DataTable GetAllVisits()
        {
            return CMS_DataLayer.clsVisit.GetAllVisits();
        }

        public static DataTable GetAllVisitsForDashboard()
        {
            return CMS_DataLayer.clsVisit.GetAllVisitsForDashboard();
        }

        public static DataTable GetVisitsByPatientID(int PatientID)
        {
            return CMS_DataLayer.clsVisit.GetVisitsByPatientID(PatientID);
        }

        public static DataTable GetVisitsByDoctorID(int DoctorID)
        {
            return CMS_DataLayer.clsVisit.GetVisitsByDoctorID(DoctorID);
        }

        public static clsVisit Find(int VisitID)
        {
            int AppointmentID = -1;
            int PatientID = -1;
            int DoctorID = -1;
            DateTime VisitDate = new DateTime();
            DateTime VisitTime = new DateTime();
            int VisitStatus = 1;
            int ExaminationID = -1;
            bool EmergencyIncome = false;
            int VisitReason = 1;
            float PaymentAmount = 0;

            if (CMS_DataLayer.clsVisit.GetVisitByID(VisitID, ref AppointmentID, ref PatientID, ref DoctorID,
                ref VisitDate, ref VisitTime, ref VisitStatus, ref ExaminationID, ref EmergencyIncome, ref VisitReason,
                ref PaymentAmount))
            {
                return new clsVisit(VisitID, AppointmentID, PatientID, DoctorID, VisitDate, VisitTime, VisitStatus,
                    ExaminationID, EmergencyIncome, VisitReason, PaymentAmount);
            }
            else return null;
        }

        bool _Add()
        {
            VisitID = CMS_DataLayer.clsVisit.AddNewVisit(AppointmentID, PatientID, DoctorID, VisitDate, VisitTime, VisitStatus,
                ExaminationID, EmergencyIncome, VisitReason, PaymentAmount);

            return (VisitID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsVisit.UpdateVisit(VisitID, AppointmentID, PatientID, DoctorID, VisitDate, VisitTime,
                VisitStatus, ExaminationID, EmergencyIncome, VisitReason, PaymentAmount);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_Add())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static bool DeleteVisit(int VisitID)
        {
            clsVisit visit = clsVisit.Find(VisitID);
            if (visit == null) return false;

            if (visit.ExaminationID != -1)
            {
                if (!CMS_BusinessLayer.clsExamination.DeleteExamination(visit.ExaminationID))
                {
                    MessageBox.Show("Error while deleting the examination associated with this visit, Do you want to proceed with the deletion anyway?.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            DataTable dtPayments = CMS_BusinessLayer.clsPayment.GetAllPaymentsByVisitID(VisitID);

            if (dtPayments.Rows.Count > 0)
            {
                foreach (DataRow row in dtPayments.Rows)
                {
                    if (!CMS_BusinessLayer.clsPayment.DeletePayment(int.Parse(row[0].ToString())))
                    {
                        if (MessageBox.Show("Error while deleting the payment associated with this visit, Do you want to proceed with the deletion anyway?.",
                        "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                        {
                            return false;
                        }
                    }
                }
            }

            return CMS_DataLayer.clsVisit.DeleteVisit(VisitID);
        }

        public DataTable GetVisitPayments()
        {
            return CMS_BusinessLayer.clsPayment.GetAllPaymentsByVisitID(VisitID);
        }

        public bool SetVisitStatus(int Status)
        {
            return CMS_DataLayer.clsVisit.SetVisitStatus(VisitID, Status);
        }

        public static bool SetVisitStatus(int VisitID, enVisitStatus Status)
        {
            return CMS_DataLayer.clsVisit.SetVisitStatus(VisitID, (int)Status);
        }

        public static bool SetEmergencyTrue(int VisitID)
        {
            return CMS_DataLayer.clsVisit.SetEmergencyTrue(VisitID);
        }
    }
}