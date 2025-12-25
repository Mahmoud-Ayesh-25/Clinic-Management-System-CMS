using Clinic_Manager_Proj.Classes;
using CMS_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmEditUser : frmMain
    {
        int UserID = -1;
        clsUser user = new clsUser();

        bool _IsAllFieldsFilled()
        {
            if (string.IsNullOrEmpty(tbxUsername.Content)) return false;
            if (string.IsNullOrEmpty(ctrlOldPassword.Content)) return false;
            
            if (schChangePassword.Checked)
            {
                if (string.IsNullOrEmpty(ctrlNewPassword.Content)) return false;
                if (string.IsNullOrEmpty(ctrlConfirmPassword.Content)) return false;
            }

            return true;
        }

        bool _LoadData(int UserID)
        {
            user = clsUser.FindByUserID(UserID);

            if (user == null) return false;

            lblID.Content = $"ID: {UserID}";
            tbxUsername.Content = user.Username;
            cbxPermissions.SelectedItem = user.PermissionTypeEnum.ToString();
            schActive.Checked = user.IsActive;

            return true;
        }

        public frmEditUser(int UserID)
        {
            InitializeComponent();

            this.UserID = UserID;
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            cbxPermissions.SelectedItem = "Admin";

            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }

            if (!_LoadData(UserID))
            {
                MessageBox.Show($"The user with the ID[{UserID}] was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void schChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            ctrlNewPassword.Enabled = schChangePassword.Checked;
            ctrlConfirmPassword.Enabled = schChangePassword.Checked;
        }

        private void tbxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (tbxUsername.Content != user.Username)
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
                    tbxUsername.PlaceholderText = "Username";
                }
            }
        }

        private void ctrlOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlOldPassword.Content) || clsMisc.HashPassword(ctrlOldPassword.Content, user.Salt) != user.Password)
            {
                ctrlOldPassword.OutLineColor = Color.Red;
                ctrlOldPassword.PlaceHolderColor = Color.Red;
                ctrlOldPassword.ForeColor = Color.Red;
                ctrlOldPassword.PlaceHolderText = "Required";
            }
            else
            {
                ctrlOldPassword.OutLineColor = Color.Black;
                ctrlOldPassword.PlaceHolderColor = Color.DimGray;
                ctrlOldPassword.ForeColor = Color.White;
                ctrlOldPassword.PlaceHolderText = "Username";
            }
        }

        private void ctrlNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlNewPassword.Content))
            {
                ctrlNewPassword.OutLineColor = Color.Red;
                ctrlNewPassword.PlaceHolderColor = Color.Red;
                ctrlNewPassword.ForeColor = Color.Red;
                ctrlNewPassword.PlaceHolderText = "Required";
            }
            else
            {
                ctrlNewPassword.OutLineColor = Color.Black;
                ctrlNewPassword.PlaceHolderColor = Color.DimGray;
                ctrlNewPassword.ForeColor = Color.White;
                ctrlNewPassword.PlaceHolderText = "Username";
            }
        }

        private void ctrlConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlConfirmPassword.Content) || ctrlNewPassword.Content != ctrlConfirmPassword.Content)
            {
                ctrlConfirmPassword.OutLineColor = Color.Red;
                ctrlConfirmPassword.PlaceHolderColor = Color.Red;
                ctrlConfirmPassword.ForeColor = Color.Red;
                ctrlConfirmPassword.PlaceHolderText = "Required";
            }
            else
            {
                ctrlConfirmPassword.OutLineColor = Color.Black;
                ctrlConfirmPassword.PlaceHolderColor = Color.DimGray;
                ctrlConfirmPassword.ForeColor = Color.White;
                ctrlConfirmPassword.PlaceHolderText = "Username";
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!_IsAllFieldsFilled())
            {
                MessageBox.Show("Make sure to fill in all the required fields.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (tbxUsername.Content != user.Username)
            {
                if (clsUser.IsUserExistByUsername(tbxUsername.Content))
                {
                    MessageBox.Show("There is already a user with the same username.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }

            if (clsMisc.HashPassword(ctrlOldPassword.Content, user.Salt) != user.Password)
            {
                MessageBox.Show("The old password is incorrect.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (schChangePassword.Checked)
            {
                if (ctrlNewPassword.Content != ctrlConfirmPassword.Content)
                {
                    MessageBox.Show("The password does not match correctly.", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }

            user.Username = tbxUsername.Content;

            if (schChangePassword.Checked)
            {
                user.Salt = Guid.NewGuid().ToString();
                user.Password = clsMisc.HashPassword(ctrlNewPassword.Content, user.Salt);
            }

            if (cbxPermissions.SelectedIndex == -1)
            {
                user.PermissionType = 1;
            }
            else
                user.PermissionType = cbxPermissions.SelectedIndex + 1;
            user.IsActive = schActive.Checked;

            if (user.Save())
            {
                MessageBox.Show($"The user has been updated successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!clsMisc.MakeLog(clsMisc.enTableName.Users, user.UserID, clsLog.enActionType.Update))
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