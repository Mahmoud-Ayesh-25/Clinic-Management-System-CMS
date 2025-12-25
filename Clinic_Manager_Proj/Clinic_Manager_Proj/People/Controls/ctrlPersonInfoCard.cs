using Clinic_Manager_Proj.Properties;
using CMS_BusinessLayer;
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

namespace Clinic_Manager_Proj.People.Controls
{
    public partial class ctrlPersonInfoCard : UserControl
    {
        clsPerson person = new clsPerson();

        public int PersonID 
        {
            get { return person.PersonID; }
        }

        bool _LoadImage()
        {
            if (string.IsNullOrEmpty(person.ImagePath)) return true;

            if (File.Exists(person.ImagePath))
            {
                pbxPersonImage.BackgroundImage = null;
                pbxPersonImage.ImageLocation = person.ImagePath;
                return true;
            }
            else return false;
        }

        void _SetDefaultImage()
        {
            if (person.GenderString == "Male")
            {
                pbxPersonImage.BackgroundImage = Resources._man;
            }
            else
            {
                pbxPersonImage.BackgroundImage = Resources._woman;
            }
        }

        void _LoadDataToControls()
        {
            lblName.Content = $"Name: {person.FullName}";
            lblID.Content = $"Person ID: {PersonID}";
            lblNationalNo.Content = $"National No: {person.NationalNo}";
            lblGender.Content = $"Gender: {person.GenderString}";
            lblAge.Content = $"Address: {person.Address}";
            lblEmail.Content = $"Email: {person.Email}";
            lblDateOfBirth.Content = $"Date Of Birth: {person.DateOfBirth.Date.ToShortDateString()}";
            lblAge.Content = $"Age: {person.Age}";
            lblPhone.Content = $"Phone: {person.Phone}";
        }

        public bool LoadData(int PersonID)
        {
            clsPerson person = clsPerson.Find(PersonID);

            if (person == null) return false;

            this.person = person;

            _LoadDataToControls();
            _SetDefaultImage();
            if (!_LoadImage())
            {
                MessageBox.Show("Error while loading the person image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        public bool LoadData(string NationalNo)
        {
            clsPerson person = clsPerson.Find(NationalNo);

            if (person == null) return false;

            this.person = person;

            _LoadDataToControls();
            _SetDefaultImage();
            if (!_LoadImage())
            {
                MessageBox.Show("Error while loading the person image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        public void LoadDefaultValues()
        {
            lblName.Content = $"Name: ";
            lblID.Content = $"Person ID: ";
            lblNationalNo.Content = $"National No: ";
            lblGender.Content = $"Gender: ";
            lblAge.Content = $"Address: ";
            lblEmail.Content = $"Email: ";
            lblDateOfBirth.Content = $"Date Of Birth: ";
            lblAge.Content = $"Age: ";
            lblPhone.Content = $"Phone: ";
            person = new clsPerson();
        }

        public ctrlPersonInfoCard()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.person.PersonID == -1) return;

            frmAddUpdatePerson person = new frmAddUpdatePerson(PersonID);
            person.ShowDialog();
            LoadData(PersonID);
        }
    }
}
