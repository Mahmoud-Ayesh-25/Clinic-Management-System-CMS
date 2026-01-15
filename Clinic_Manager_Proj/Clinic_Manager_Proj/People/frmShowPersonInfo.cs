using System.Windows.Forms;

namespace Clinic_Manager_Proj.People
{
    public partial class frmShowPersonInfo : frmMain
    {
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();

            if (!ctrlPersonInfoCard1.LoadData(PersonID))
            {
                MessageBox.Show("Error while retrieving person data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
