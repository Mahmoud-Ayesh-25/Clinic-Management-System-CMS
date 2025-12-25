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
