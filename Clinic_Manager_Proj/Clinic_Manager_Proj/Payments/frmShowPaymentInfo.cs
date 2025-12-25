using Clinic_Manager_Proj.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Payments
{
    public partial class frmShowPaymentInfo : frmMain
    {
        public frmShowPaymentInfo(int PaymentID)
        {
            InitializeComponent();

            if (!ctrlShowPaymentInfo1.LoadData(PaymentID))
            {
                MessageBox.Show("Error while retrieving payment data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
