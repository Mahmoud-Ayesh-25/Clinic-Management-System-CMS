using Clinic_Manager_Proj.Classes;
using Clinic_Manager_Proj.Properties;
using CMS_BusinessLayer;
using CuoreUI.Controls;
using DVLD_Project.MainSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.People
{
    public partial class frmAddUpdatePerson : frmMain
    {
        public delegate void DataBackEventHandler(int PersonID);
        public event DataBackEventHandler DataBack;

        enum enMode { Add, Edit}
        enMode _Mode;

        clsPerson person = new clsPerson();

        void _HandleImage()
        {
            if (pbxPersonImage.ImageLocation == person.ImagePath) return;

            if (File.Exists(person.ImagePath))
            {
                try
                {
                    File.Delete(person.ImagePath);
                    person.ImagePath = "";
                }
                catch (Exception e)
                { MessageBox.Show($"Error: {e.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            if (pbxPersonImage.ImageLocation != null)
            {
                string imagePath = pbxPersonImage.ImageLocation;

                if (clsMisc.CopyImageToImagesFolder(ref imagePath))
                {
                    person.ImagePath = imagePath;
                }
                else
                {
                    { MessageBox.Show($"Error while saving the image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        void _PutDataInPersonObject()
        {
            person.NationalNo = tbxNationalNo.Content;
            person.Phone = tbxPhone.Content;
            person.Email = tbxEmail.Content;
            person.Address = tbxAddress.Content;
            person.FirstName = tbxFirstName.Content;
            person.LastName = tbxLastName.Content;
            person.ThirdName = tbxThirdName.Content;
            person.SecondName = tbxSecondName.Content;
            if (btnMale.Checked) person.Gender = 0; else person.Gender = 1;
            person.DateOfBirth = cdpDateOfBirth.Content.Date;

            _HandleImage();
        }

        // {Load Data}
        bool _LoadImage()
        {
            if (string.IsNullOrEmpty(person.ImagePath)) return true;

            if (File.Exists(person.ImagePath))
            {
                pbxPersonImage.BackgroundImage = null;
                pbxPersonImage.ImageLocation = person.ImagePath;
                btnDelete.Visible = true;
                return true;
            }
            else return false;
        }

        void _SetDefaultImage()
        {
            if (pbxPersonImage.ImageLocation != null)
            {
                btnDelete.Visible = true;
                return;
            }

            btnDelete.Visible = false;

            if (person.GenderString == "Male")
            {
                pbxPersonImage.BackgroundImage = Resources._man;
            }
            else
            {
                pbxPersonImage.BackgroundImage = Resources._woman;
            }
        }

        void _HandleGender()
        {
            if (person.GenderString == "Male")
            {
                btnMale.Checked = true;
                btnFemale.Checked = false;
            }
            else
            {
                btnMale.Checked = false;
                btnFemale.Checked = true;
            }
        }

        void _SetDataToControls()
        {
            lblID.Content = $"ID: {person.PersonID}";
            tbxFirstName.Content = person.FirstName;
            tbxSecondName.Content = person.SecondName;
            tbxThirdName.Content = person.ThirdName;
            tbxLastName.Content = person.LastName;
            tbxNationalNo.Content = person.NationalNo;
            tbxPhone.Content = person.Phone;
            tbxEmail.Content = person.Email;
            tbxAddress.Content = person.Address;
            cdpDateOfBirth.Content = person.DateOfBirth;
        }

        bool _LoadData(int PersonID)
        {
            person = clsPerson.Find(PersonID);

            if (person == null) return false;

            _SetDataToControls();
            _HandleGender();
            _SetDefaultImage();
            if (!_LoadImage())
            {
                MessageBox.Show("Error while loading the person image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }
        //////////////

        bool _IsFieldsFull()
        {
            if (string.IsNullOrEmpty(tbxFirstName.Content)) return false;
            if (string.IsNullOrEmpty(tbxLastName.Content)) return false;
            if (string.IsNullOrEmpty(tbxPhone.Content)) return false;

            return true;
        }

        public frmAddUpdatePerson()
        {
            InitializeComponent();

            _Mode = enMode.Add;
            lblMainTitle.Content = "Add New Person";

            cdpDateOfBirth.Content = DateTime.Now;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Edit;
            lblMainTitle.Content = "Edit Person";

            if (!_LoadData(PersonID))
            {
                MessageBox.Show("An error occurred while loading the person's data, most likely because it has been deleted from the " +
                    "database or there is an issue with the database itself.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            if (clsProgramSettings.CurrentUser.PermissionTypeEnum != clsUser.enPermissionType.Admin)
            {
                MessageBox.Show("You don't have the permissions for this.", "No Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }
        }

        private void tbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(((cuiTextBox)sender).Content))
            {
                ((cuiTextBox)sender).OutlineColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderColor = Color.Red;
                ((cuiTextBox)sender).PlaceholderText = "Required";
            }
            else
            {
                ((cuiTextBox)sender).OutlineColor = Color.Black;
            }
        }

        private void tbxNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.Find(tbxNationalNo.Content) != null && tbxNationalNo.Content != person.NationalNo)
            {
                tbxNationalNo.OutlineColor = Color.Red;
                tbxNationalNo.ForeColor = Color.Red;
                return;
            }

            tbxNationalNo.OutlineColor = Color.Black;
            tbxNationalNo.ForeColor = Color.White;
        }

        private void tbxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxEmail.Content))
            {
                tbxEmail.OutlineColor = Color.Black;
                tbxEmail.ForeColor = Color.White;
                return;
            }

            if (!clsValidation.IsValidEmail(tbxEmail.Content))
            {
                tbxEmail.OutlineColor = Color.Red;
                tbxEmail.ForeColor = Color.Red;
                return;
            }
        }

        private void btnImportImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose a picture";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxPersonImage.BackgroundImage = null;
                pbxPersonImage.ImageLocation = openFileDialog.FileName;
                btnDelete.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this image?", "Confirm Remove",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pbxPersonImage.ImageLocation = null;
                _SetDefaultImage();
                btnDelete.Visible = false;
            }
        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            if (!_IsFieldsFull())
            {
                MessageBox.Show($"Make sure to fill in all the required fields.", "Cannot Save Now",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!clsValidation.IsValidDate(cdpDateOfBirth.Content.Date))
            {
                MessageBox.Show($"The date you entered is not valid. A valid date should be between {DateTime.Now.AddYears(-150).ToShortDateString()} and" +
                    $" {DateTime.Now.ToShortDateString()}", "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (clsPerson.Find(tbxNationalNo.Content) != null && tbxNationalNo.Content != person.NationalNo)
            {
                MessageBox.Show($"There is already someone who has the national number \"{tbxNationalNo.Content}\"",
                    "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!string.IsNullOrEmpty(tbxEmail.Content))
            {
                if (!clsValidation.IsValidEmail(tbxEmail.Content))
                {
                    MessageBox.Show($"\"{tbxEmail.Content}\" is not a correct format for email.",
                        "Cannot Save Now", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            _PutDataInPersonObject();

            if (person.Save())
            {
                if (_Mode == enMode.Add)
                {
                    lblMainTitle.Content = "Edit Person";
                    lblID.Content = $"ID: {person.PersonID}";
                    _Mode = enMode.Edit;

                    if (!clsMisc.MakeLog(clsMisc.enTableName.People, person.PersonID, clsLog.enActionType.AddNew))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!clsMisc.MakeLog(clsMisc.enTableName.People, person.PersonID, clsLog.enActionType.Update))
                    {
                        MessageBox.Show($"An error occurred while saving the log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show($"The person has been saved successfully with ID[{person.PersonID}].", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(person.PersonID);
            }
            else
            {
                MessageBox.Show("An error occurred while saving the person, most likely due to a connection error with the database, either because" +
                    " it was deleted or because it was moved from its expected location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidation.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            if (pbxPersonImage.ImageLocation == null || string.IsNullOrEmpty(pbxPersonImage.ImageLocation))
                pbxPersonImage.BackgroundImage = Resources._woman;
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            if (pbxPersonImage.ImageLocation == null || string.IsNullOrEmpty(pbxPersonImage.ImageLocation))
                pbxPersonImage.BackgroundImage = Resources._man;
        }
    }
}
