using CMS_BusinessLayer;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Payments.Controls
{
    public partial class ctrlShowPaymentInfo : UserControl
    {
        public int PaymentID { get { return payment.PaymentID; } }
        clsPayment payment = new clsPayment();

        public bool LoadData(int PaymentID)
        {
            payment = clsPayment.Find(PaymentID);

            if (payment == null) return false;

            lblPaymentID.Content = $"Payment ID: {payment.PaymentID}";
            lblVisitID.Content = $"Visit ID: {payment.VisitID}";
            lblPaid.Content = $"Paid Amount: {payment.PaidAmount}";
            lblPaymentMethod.Content = $"Payment Method: {payment.PaymentMethodString}";
            lblDate.Content = $"Date: {payment.Date.ToShortDateString()}";
            lblStatus.Content = $"Status: {payment.StatusEnum}";

            return true;
        }

        public ctrlShowPaymentInfo()
        {
            InitializeComponent();
        }
    }
}
