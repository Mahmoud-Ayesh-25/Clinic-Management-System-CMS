using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CMS_BusinessLayer
{
    public class clsPerson
    {
        enum enMode { Add, Update};
        enMode Mode;

        public int PersonID {  get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return _GetFullName(); } }
        public DateTime DateOfBirth { get; set; }
        public byte Age { get { return (byte)((DateOfBirth != new DateTime()) ? (DateTime.Now.Year - DateOfBirth.Year) : 0); } }
        public byte Gender { get; set; }
        public string GenderString { get; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            Mode = enMode.Add;
            PersonID = -1;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = new DateTime();
            Gender = 0;
            GenderString = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            ImagePath = string.Empty;
        }

        clsPerson(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName,
            DateTime dateOfBirth, byte gender, string phone, string email, string address, string imagePath)
        {
            Mode = enMode.Update;
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            GenderString = (Gender == 0) ? "Male" : "Female";
            Phone = phone;
            Email = email;
            Address = address;
            ImagePath = imagePath;
        }

        string _GetFullName()
        {
            return FirstName + (string.IsNullOrEmpty(SecondName) ? "" : " " + SecondName) +
                (string.IsNullOrEmpty(ThirdName) ? "" : " " + ThirdName) + " " + LastName;
        }

        public static DataTable GetAllPeople()
        {
            return CMS_DataLayer.clsPerson.GetAllPeople();
        }

        public static clsPerson Find(int PersonID)
        {
            string NationalNo = string.Empty;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = new DateTime();
            byte Gender = 0;
            string Phone = string.Empty;
            string Email = string.Empty;
            string Address = string.Empty;
            string ImagePath = string.Empty;

            if (CMS_DataLayer.clsPerson.GetPersonByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Phone, ref Email, ref Address, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Phone
                    , Email, Address, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = new DateTime();
            byte Gender = 0;
            string Phone = string.Empty;
            string Email = string.Empty;
            string Address = string.Empty;
            string ImagePath = string.Empty;

            if (CMS_DataLayer.clsPerson.GetPersonByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Phone, ref Email, ref Address, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Phone
                    , Email, Address, ImagePath);
            }
            else
            {
                return null;
            }
        }

        bool _Add()
        {
            PersonID = CMS_DataLayer.clsPerson.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender
                , Phone, Email, Address, ImagePath);

            return (PersonID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsPerson.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth
                , Gender, Phone, Email, Address, ImagePath);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    {
                        if (_Add())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            { return false; }
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static bool DeletePerson(int PersonID)
        {
            clsPerson person = clsPerson.Find(PersonID);

            if (person == null) return false;

            if (!string.IsNullOrEmpty(person.ImagePath))
            {
                if (File.Exists(person.ImagePath))
                {
                    try
                    {
                        File.Delete(person.ImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CMS_DataLayer.clsDataAccessSettings.CreateEventLog(ex.Message);
                    }
                }
            }

            return CMS_DataLayer.clsPerson.DeletePerson(PersonID);
        }
    }
}
