using CMS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Users
{
    public partial class ctrlUserCard : UserControl
    {
        clsUser user = new clsUser();
        public int UserID { get { return user.UserID; } }

        void _PutDataInControls()
        {
            lblID.Content = $"User ID: {user.UserID}";
            lblUsername.Content = $"Username: {user.Username}";
            lblPermissions.Content = $"Permissions: {user.PermissionTypeEnum.ToString()}";
            lblIsActive.Content = $"Is Active: {((user.IsActive)? "Yes" : "No")}";
        }
        public bool LoadDataByUserID(int UserID)
        {
            user = clsUser.FindByUserID(UserID);

            if (user == null) return false;

            _PutDataInControls();

            return true;
        }

        public bool LoadDataByPersonID(int PersonID)
        {
            user = clsUser.FindByPersonID(PersonID);

            if (user == null) return false;

            _PutDataInControls();

            return true;
        }

        public void SetDefaultData()
        {
            lblID.Content = $"User ID: ";
            lblUsername.Content = $"Username: ";
            lblPermissions.Content = $"Permissions: ";
            lblIsActive.Content = $"Is Active: ";
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (user.UserID != -1)
            {
                frmEditUser user = new frmEditUser(this.user.UserID);
                user.ShowDialog();
                LoadDataByUserID(this.user.UserID);
            }
        }
    }
}