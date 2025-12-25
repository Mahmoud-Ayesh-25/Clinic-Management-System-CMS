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

namespace Clinic_Manager_Proj.Users
{
    public partial class frmShowUserInfo : frmMain
    {
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();

            clsUser user = clsUser.FindByUserID(UserID);

            if (user == null)
            {
                MessageBox.Show($"The user with the ID[{UserID}] was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ctrlUserCard1.LoadDataByUserID(UserID);
            ctrlPersonInfoCard1.LoadData(user.PersonID);
        }
    }
}
