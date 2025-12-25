using DVLD_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.People
{
    public partial class frmMainFormForManage : frmMain
    {
        void SizeChange()
        {
            pnlDgvContainer.Width = this.Width - 24;
            pnlDgvContainer.Height = this.Height - 202;
            dgvData.Width = pnlDgvContainer.Width - 2;
            dgvData.Height = pnlDgvContainer.Height - 32;
            pnlFilterContainer.Width = this.Width - 24;
        }

        public frmMainFormForManage()
        {
            InitializeComponent();
        }

        private void frmMainFormForManage_SizeChanged(object sender, EventArgs e)
        {
            SizeChange();
        }

        private void dgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblRecordes.Content = $"Records : {dgvData.Rows.Count}";
        }
    }
}
