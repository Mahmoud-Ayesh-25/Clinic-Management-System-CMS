using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.Users
{
    public partial class frmAddNewUser : frmMain
    {
        bool _IsAllFieldsFilled()
        {
            if (string.IsNullOrEmpty(tbxUsername.Content)) return false;
            if (string.IsNullOrEmpty(ctrlPassword.Content)) return false;
            if (string.IsNullOrEmpty(ctrlConfirmPassword.Content)) return false;

            return true;
        }

        public frmAddNewUser()
        {
            InitializeComponent();

            ctrlPersonCardWithSearch1.BringToFront();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            cbxPermissions.SelectedItem = "Admin";

            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }
        }

        private void ctrlPassword1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlPassword.Content))
            {
                ctrlPassword.OutLineColor = Color.Red;
                ctrlPassword.PlaceHolderColor = Color.Red;
                ctrlPassword.ForeColor = Color.Red;
                ctrlPassword.PlaceHolderText = "Required";
            }
            else
            {
                ctrlPassword.OutLineColor = Color.Black;
                ctrlPassword.PlaceHolderColor = Color.DimGray;
                ctrlPassword.ForeColor = Color.White;
                ctrlPassword.PlaceHolderText = "Password";
            }
        }

        private void ctrlConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (ctrlConfirmPassword.Content != ctrlPassword.Content)
            {
                ctrlConfirmPassword.OutLineColor = Color.Red;
                ctrlConfirmPassword.PlaceHolderColor = Color.Red;
                ctrlConfirmPassword.ForeColor = Color.Red;
                ctrlConfirmPassword.PlaceHolderText = "Not Match";
            }
            else
            {
                ctrlConfirmPassword.OutLineColor = Color.Black;
                ctrlConfirmPassword.PlaceHolderColor = Color.DimGray;
                ctrlConfirmPassword.ForeColor = Color.White;
                ctrlConfirmPassword.PlaceHolderText = "Confirm Password";
            }
        }

        private void tbxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxUsername.Content) || clsUser.IsUserExistByUsername(tbxUsername.Content))
            {
                tbxUsername.OutlineColor = Color.Red;
                tbxUsername.PlaceholderColor = Color.Red;
                tbxUsername.ForeColor = Color.Red;
                tbxUsername.PlaceholderText = "Required";
            }
            else
            {
                tbxUsername.OutlineColor = Color.Black;
                tbxUsername.PlaceholderColor = Color.DimGray;
                tbxUsername.ForeColor = Color.White;
                tbxUsername.PlaceholderText = "Password";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithSearch1.PersonID != -1)
            {
                if (clsUser.FindByPersonID(ctrlPersonCardWithSearch1.PersonID) == null)
                {
                    btnSaveUser.Visible = true;
                    btnNext.Visible = false;
                    btnBack.Visible = true;
                    pnlUserDetails.BringToFront();
                }
                else
                {
                    MessageBox.Show("This person is already a user.", "Cannot Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("You have to choose a person first.", "Cannot Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnSaveUser.Visible = false;
            btnNext.Visible = true;
            btnBack.Visible = false;
            ctrlPersonCardWithSearch1.BringToFront();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!_IsAllFieldsFilled())
            {
                MessageBox.Show("Make sure to fill in all the required fields.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (clsUser.IsUserExistByUsername(tbxUsername.Content))
            {
                MessageBox.Show("There is already a user with the same username.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ctrlConfirmPassword.Content != ctrlPassword.Content)
            {
                MessageBox.Show("The password does not match correctly.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            clsUser user = new clsUser();

            user.Username = tbxUsername.Content;
            user.PermissionType = cbxPermissions.SelectedIndex + 1;
            user.Salt = Guid.NewGuid().ToString();
            user.Password = clsMisc.HashPassword(ctrlPassword.Content, user.Salt);
            user.PersonID = ctrlPersonCardWithSearch1.PersonID;
            user.IsActive = schActive.Checked;

            if (user.Save())
            {
                lblID.Content = $"ID: {user.UserID}";
                MessageBox.Show($"The user has been saved successfully with ID[{user.UserID}].", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!clsMisc.MakeLog(clsMisc.enTableName.Users, user.UserID, clsLog.enActionType.AddNew))
                {
                    MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("An error occurred while saving the user, most likely due to a connection error with the database, " +
                    "either because it was deleted or because it was moved from its expected location.", "Not Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}