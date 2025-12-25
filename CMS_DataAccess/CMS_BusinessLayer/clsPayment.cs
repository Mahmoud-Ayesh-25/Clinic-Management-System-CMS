using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BusinessLayer
{
    public class clsPayment
    {
        public enum enStatus { Completed = 1, Cancelled}

        enum enMode { Add, Update}
        enMode Mode;

        public int PaymentID { get; set; }
        public int VisitID { get; set; }
        public clsVisit VisitInfo { get { return (VisitID != -1) ? clsVisit.Find(VisitID) : new clsVisit(); } }
        public float PaidAmount { get; set; }
        public int PaymentMethodID { get; set; }
        public string PaymentMethodString { get { return (PaymentMethodID != -1) ? clsPaymentMethod.Find(PaymentMethodID).PaymentMethodName : string.Empty; } }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public enStatus StatusEnum { get { return ((enStatus)Status); } }

        public clsPayment()
        {
            Mode = enMode.Add;
            PaymentID = -1;
            VisitID = -1;
            PaidAmount = 0;
            PaymentMethodID = -1;
            Date = new DateTime();
            Status = 1;
        }

        clsPayment(int paymentID, int visitID, float paidAmount, int paymentMethodID, DateTime date, int status)
        {
            Mode = enMode.Update;
            PaymentID = paymentID;
            VisitID = visitID;
            PaidAmount = paidAmount;
            PaymentMethodID = paymentMethodID;
            Date = date;
            Status = status;
        }

        public static DataTable GetAllPayments()
        {
            return CMS_DataLayer.clsPayment.GetAllPayments();
        }

        public static DataTable GetAllPaymentsByVisitID(int VisitID)
        {
            return CMS_DataLayer.clsPayment.GetAllPaymentsByVisitID(VisitID);
        }

        public static clsPayment Find(int PaymentID)
        {
            int VisitID = -1;
            float PaidAmount = 0;
            int PaymentMethodID = -1;
            DateTime Date = new DateTime();
            int Status = -1;

            if (CMS_DataLayer.clsPayment.GetPaymentByID(PaymentID, ref VisitID, ref PaidAmount, ref PaymentMethodID, ref Date, ref Status))
            {
                return new clsPayment(PaymentID, VisitID, PaidAmount, PaymentMethodID, Date, Status);
            }
            else return null;
        }

        bool _Add()
        {
            PaymentID = CMS_DataLayer.clsPayment.AddNewPayment(VisitID, PaidAmount, PaymentMethodID, Date, Status);
            return (PaymentID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsPayment.UpdatePayment(PaymentID, VisitID, PaidAmount, PaymentMethodID, Date, Status);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    {
                        if (_Add())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else { return false; }
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static bool DeletePayment(int PaymentID)
        {
            return CMS_DataLayer.clsPayment.DeletePayment(PaymentID);
        }
    }
}
