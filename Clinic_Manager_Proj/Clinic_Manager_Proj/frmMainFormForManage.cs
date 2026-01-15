using System;
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
