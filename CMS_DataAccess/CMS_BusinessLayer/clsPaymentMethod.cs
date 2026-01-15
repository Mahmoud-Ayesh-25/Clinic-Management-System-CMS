using System.Data;

namespace CMS_BusinessLayer
{
    public class clsPaymentMethod
    {
        enum enMode { Add, Update}
        enMode Mode;

        public int PaymentMethodID { get; set; }
        public string PaymentMethodName { get; set; }

        public clsPaymentMethod()
        {
            Mode = enMode.Add;
            PaymentMethodID = -1;
            PaymentMethodName = string.Empty;
        }

        clsPaymentMethod(int paymentMethodID, string paymentMethodName)
        {
            Mode = enMode.Update;
            PaymentMethodID = paymentMethodID;
            PaymentMethodName = paymentMethodName;
        }

        public static DataTable GetAllPaymentMethods()
        {
            return CMS_DataLayer.clsPaymentMethod.GetAllPaymentMethods();
        }

        public static clsPaymentMethod Find(int PaymentMethodID)
        {
            string PaymentMethodName = string.Empty;

            if (CMS_DataLayer.clsPaymentMethod.GetPaymentMethodByID(PaymentMethodID, ref PaymentMethodName))
            {
                return new clsPaymentMethod(PaymentMethodID, PaymentMethodName);
            }
            else return null;
        }

        bool _Add()
        {
            PaymentMethodID = CMS_DataLayer.clsPaymentMethod.AddNewPaymentMethod(PaymentMethodName);
            return (PaymentMethodID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsPaymentMethod.UpdatePaymentMethod(PaymentMethodID, PaymentMethodName);
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
                        else return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static bool DeletePaymentMethod(int PaymentMethodID)
        {
            return CMS_DataLayer.clsPaymentMethod.DeletePaymentMethod(PaymentMethodID);
        }

        public static bool IsPaymentMethodExistByMethodName(string PaymentMethodTitle)
        {
            return CMS_DataLayer.clsPaymentMethod.IsPaymentMethodExistByMethodName(PaymentMethodTitle);
        }
    }
}
