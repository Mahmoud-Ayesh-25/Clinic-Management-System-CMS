using Clinic_Manager_Proj.Classes;
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

namespace Clinic_Manager_Proj.Settings.PaymentMethods
{
    public partial class frmAddUpdatePaymentMethod : frmMain
    {
        enum enMode { Add, Update}
        enMode Mode;

        int MethodID = -1;
        clsPaymentMethod method = new clsPaymentMethod();

        bool _LoadData()
        {
            method = clsPaymentMethod.Find(MethodID);

            if (method == null ) return false;

            lblID.Content = $"ID: {MethodID}";
            tbxMethodTitle.Content = method.PaymentMethodName;

            return true;
        }

        public frmAddUpdatePaymentMethod()
        {
            InitializeComponent();

            lblMainTitle.Content = "Add Payment Method";
            Mode = enMode.Add;
        }

        public frmAddUpdatePaymentMethod(int MethodID)
        {
            InitializeComponent();

            this.MethodID = MethodID;
            lblMainTitle.Content = "Edit Payment Method";
            Mode = enMode.Update;
        }

        private void frmAddUpdatePaymentMethod_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            if (Mode == enMode.Update)
            {
                if (!_LoadData())
                {
                    MessageBox.Show("An error occurred while loading the method's data, most likely because it has been deleted from the " +
                        "database or there is an issue with the database itself.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();
                }
            }
        }

        private void tbxMethodTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxMethodTitle.Content) || (clsPaymentMethod.IsPaymentMethodExistByMethodName(tbxMethodTitle.Content) &&
                tbxMethodTitle.Content != method.PaymentMethodName))
            {
                tbxMethodTitle.OutlineColor = Color.Red;
                tbxMethodTitle.ForeColor = Color.Red;
                tbxMethodTitle.PlaceholderColor = Color.Red;
                tbxMethodTitle.PlaceholderText = "Required";
            }
            else
            {
                tbxMethodTitle.OutlineColor = Color.Black;
                tbxMethodTitle.ForeColor = Color.White;
            }
        }

        private void btnSaveMethod_Click(object sender, EventArgs e)
        {
            // This check if the tbxMethodTitle is empty and the written title is not already exist if it's not like the current title.
            if (string.IsNullOrEmpty(tbxMethodTitle.Content) || (clsPaymentMethod.IsPaymentMethodExistByMethodName(tbxMethodTitle.Content) &&
                tbxMethodTitle.Content != method.PaymentMethodName))
            {
                if (string.IsNullOrEmpty(tbxMethodTitle.Content))
                {
                    MessageBox.Show("Make sure to fill in all the required fields.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("There is already a method with the same name.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return;
            }

            method.PaymentMethodName = tbxMethodTitle.Content;

            if (method.Save())
            {
                if (Mode == enMode.Add)
                {
                    MethodID = method.PaymentMethodID;
                    lblID.Content = $"ID: {method.PaymentMethodID}";
                    lblMainTitle.Content = "Edit Payment Method";
                    Mode = enMode.Update;

                    if (!clsMisc.MakeLog(clsMisc.enTableName.PaymentMethodes, method.PaymentMethodID, clsLog.enActionType.AddNew))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.PaymentMethodes, method.PaymentMethodID, clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("The payment method has been saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while saving the payment method, most likely due to a connection error with the database, either because it was deleted or because it was moved from its expected location.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
