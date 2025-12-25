using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BusinessLayer
{
    public class clsPatient
    {
        enum enMode { Add, Update}
        enMode Mode;

        public int PatientID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get { return (PersonID != -1) ? clsPerson.Find(PersonID) : new clsPerson(); } }
        public string Allergies { get; set; }
        public string ChronicDiseases { get; set; }
        public string CurrentEducations { get; set; }
        public string Notes { get; set; }
        public DateTime CreateDate { get; }
        public bool IsActive { get; set; }

        public clsPatient()
        {
            Mode = enMode.Add;
            PatientID = -1;
            PersonID = -1;
            Allergies = string.Empty;
            ChronicDiseases = string.Empty;
            CurrentEducations = string.Empty;
            Notes = string.Empty;
            IsActive = true;
        }

        clsPatient(int patientID, int personID, string allergies, string chronicDiseases, string currentEducations, string notes, DateTime createDate,
            bool isActive)
        {
            Mode = enMode.Update;
            PatientID = patientID;
            PersonID = personID;
            Allergies = allergies;
            ChronicDiseases = chronicDiseases;
            CurrentEducations = currentEducations;
            Notes = notes;
            CreateDate = createDate;
            IsActive = isActive;
        }

        public static DataTable GetAllPatients()
        {
            return CMS_DataLayer.clsPatient.GetAllPatients();
        }

        public static clsPatient FindByPatientID(int PatientID)
        {
            int PersonID = -1;
            string Allergies = string.Empty;
            string ChronicDiseases = string.Empty;
            string CurrentEducations = string.Empty;
            string Notes = string.Empty;
            DateTime CreateDate = new DateTime();
            bool IsActive = true;

            if (CMS_DataLayer.clsPatient.GetPatientByPatientID(PatientID, ref PersonID, ref Allergies, ref ChronicDiseases,
                ref CurrentEducations, ref Notes, ref CreateDate, ref IsActive))
            {
                return new clsPatient(PatientID, PersonID, Allergies, ChronicDiseases, CurrentEducations, Notes, CreateDate, IsActive);
            }
            else return null;
        }

        public static clsPatient FindByPersonID(int PersonID)
        {
            int PatientID = -1;
            string Allergies = string.Empty;
            string ChronicDiseases = string.Empty;
            string CurrentEducations = string.Empty;
            string Notes = string.Empty;
            DateTime CreateDate = new DateTime();
            bool IsActive = true;

            if (CMS_DataLayer.clsPatient.GetPatientByPersonID(PersonID, ref PatientID, ref Allergies, ref ChronicDiseases,
                ref CurrentEducations, ref Notes, ref CreateDate, ref IsActive))
            {
                return new clsPatient(PatientID, PersonID, Allergies, ChronicDiseases, CurrentEducations, Notes, CreateDate, IsActive);
            }
            else return null;
        }

        bool _Add()
        {
            PatientID = CMS_DataLayer.clsPatient.AddNewPatient(PersonID, Allergies, ChronicDiseases, CurrentEducations, Notes, IsActive);
            return (PatientID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsPatient.UpdatePatient(PatientID, PersonID, Allergies, ChronicDiseases, CurrentEducations, Notes, IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_Add())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static bool DeletePatient(int PatientID)
        {
            return CMS_DataLayer.clsPatient.DeletePatients(PatientID);
        }

        public DataTable GetPatientVisits()
        {
            return CMS_DataLayer.clsVisit.GetVisitsByPatientID(PatientID);
        }

        public DataTable GetPatientAppointments()
        {
            return CMS_DataLayer.clsAppointment.GetAppointmentsByPatientID(PatientID);
        }

        public static bool ActivatePatient(int PatientID)
        {
            return CMS_DataLayer.clsPatient.ActivatePatient(PatientID);
        }

        public static bool DeactivatePatient(int PatientID)
        {
            return CMS_DataLayer.clsPatient.DeactivatePatient(PatientID);
        }
    }
}
