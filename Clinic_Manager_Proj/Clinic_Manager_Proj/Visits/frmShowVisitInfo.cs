using CMS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Visits
{
    public partial class frmShowVisitInfo : frmMain
    {
        clsVisit visit = new clsVisit();

        public frmShowVisitInfo(int VisitID)
        {
            InitializeComponent();

            visit = clsVisit.Find(VisitID);
        }

        private void frmShowVisitInfo_Load(object sender, EventArgs e)
        {
            if (visit == null)
            {
                MessageBox.Show("Error while retrieving visit data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ctrlVisitCard1.LoadData(visit.VisitID);
        }
    }
}
