using System;
using System.Data;

namespace CMS_BusinessLayer
{
    public class clsDoctor
    {
        enum enMode { Add, Update }
        enMode Mode;

        public int DoctorID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get { return (PersonID != -1) ? clsPerson.Find(PersonID) : new clsPerson(); } }
        public string Specialization { get; set; }
        public string SubSpecialization { get; set; }
        public string LicenseNo { get; set; }
        public DateTime LicenseIssueDate { get; set; }
        public DateTime LicenseExpDate { get; set; }
        public byte ExperienceYears { get; set; }
        public string WeekDays { get; set; }
        public DateTime WorkHourFrom { get; set; }
        public DateTime WorkHourTo { get; set; }
        public float ExaminationPrice { get; set; }
        public bool IsActive { get; set; }

        public clsDoctor()
        {
            Mode = enMode.Add;
            DoctorID = -1;
            PersonID = -1;
            Specialization = string.Empty;
            SubSpecialization = string.Empty;
            LicenseNo = string.Empty;
            LicenseIssueDate = new DateTime();
            LicenseExpDate = new DateTime();
            ExperienceYears = 0;
            WeekDays = string.Empty;
            WorkHourFrom = new DateTime();
            WorkHourTo = new DateTime();
            ExaminationPrice = 0;
            IsActive = true;
        }

        clsDoctor(int doctorID, int personID, string specialization, string subSpecialization, string licenseNo,
            DateTime licenseIssueDate, DateTime licenseExpDate, byte experienceYears, string weekDays, DateTime workHourFrom,
            DateTime workHourTo, float examinationPrice, bool isActive)
        {
            Mode = enMode.Update;
            DoctorID = doctorID;
            PersonID = personID;
            Specialization = specialization;
            SubSpecialization = subSpecialization;
            LicenseNo = licenseNo;
            LicenseIssueDate = licenseIssueDate;
            LicenseExpDate = licenseExpDate;
            ExperienceYears = experienceYears;
            WeekDays = weekDays;
            WorkHourFrom = workHourFrom;
            WorkHourTo = workHourTo;
            ExaminationPrice = examinationPrice;
            IsActive = isActive;
        }

        public static DataTable GetAllDoctors()
        {
            return CMS_DataLayer.clsDoctor.GetAllDoctors();
        }

        public static clsDoctor FindByDoctorID(int DoctorID)
        {
            int PersonID = -1;
            string Specialization = string.Empty;
            string SubSpecialization = string.Empty;
            string LicenseNo = string.Empty;
            DateTime LicenseIssueDate = new DateTime();
            DateTime LicenseExpDate = new DateTime();
            byte ExperienceYears = 0;
            string WeekDays = string.Empty;
            DateTime WorkHourFrom = new DateTime();
            DateTime WorkHourTo = new DateTime();
            float ExaminationPrice = 0;
            bool IsActive = true;

            if (CMS_DataLayer.clsDoctor.GetDoctorByDoctorID(DoctorID, ref PersonID, ref Specialization, ref SubSpecialization,
                ref LicenseNo, ref LicenseIssueDate, ref LicenseExpDate, ref ExperienceYears, ref WeekDays, ref WorkHourFrom,
                ref WorkHourTo, ref ExaminationPrice, ref IsActive))
            {
                return new clsDoctor(DoctorID, PersonID, Specialization, SubSpecialization, LicenseNo, LicenseIssueDate
                    , LicenseExpDate, ExperienceYears, WeekDays, WorkHourFrom, WorkHourTo, ExaminationPrice, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsDoctor FindByPersonID(int PersonID)
        {
            int DoctorID = -1;
            string Specialization = string.Empty;
            string SubSpecialization = string.Empty;
            string LicenseNo = string.Empty;
            DateTime LicenseIssueDate = new DateTime();
            DateTime LicenseExpDate = new DateTime();
            byte ExperienceYears = 0;
            string WeekDays = string.Empty;
            DateTime WorkHourFrom = new DateTime();
            DateTime WorkHourTo = new DateTime();
            float ExaminationPrice = 0;
            bool IsActive = true;

            if (CMS_DataLayer.clsDoctor.GetDoctorByPersonID(PersonID, ref DoctorID, ref Specialization, ref SubSpecialization,
                ref LicenseNo, ref LicenseIssueDate, ref LicenseExpDate, ref ExperienceYears, ref WeekDays, ref WorkHourFrom,
                ref WorkHourTo, ref ExaminationPrice, ref IsActive))
            {
                return new clsDoctor(DoctorID, PersonID, Specialization, SubSpecialization, LicenseNo, LicenseIssueDate
                    , LicenseExpDate, ExperienceYears, WeekDays, WorkHourFrom, WorkHourTo, ExaminationPrice, IsActive);
            }
            else
            {
                return null;
            }
        }

        bool _Add()
        {
            DoctorID = CMS_DataLayer.clsDoctor.AddNewDoctor(PersonID, Specialization, SubSpecialization, LicenseNo, LicenseIssueDate
                , LicenseExpDate, ExperienceYears, WeekDays, WorkHourFrom, WorkHourTo, ExaminationPrice, IsActive);

            return (DoctorID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsDoctor.UpdateDoctor(DoctorID, PersonID, Specialization, SubSpecialization, LicenseNo, LicenseIssueDate
                , LicenseExpDate, ExperienceYears, WeekDays, WorkHourFrom, WorkHourTo, ExaminationPrice, IsActive);
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
                        else { return false; }
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static bool DeleteDoctor(int DoctorID)
        {
            return CMS_DataLayer.clsDoctor.DeleteDoctor(DoctorID);
        }

        public DataTable GetDoctorAppointments()
        {
            return CMS_DataLayer.clsAppointment.GetAppointmentsByDoctorID(DoctorID);
        }

        public DataTable GetDoctorVisits()
        {
            return CMS_DataLayer.clsVisit.GetVisitsByDoctorID(DoctorID);
        }

        public static bool IsDoctorExistByLicenseNo(string LicenseNo)
        {
            return CMS_DataLayer.clsDoctor.IsDoctorExistByLicenseNo(LicenseNo);
        }

        public static bool ActivateDoctor(int DoctorID)
        {
            return CMS_DataLayer.clsDoctor.ActivateDoctor(DoctorID);
        }

        public static bool DeactivateDoctor(int DoctorID)
        {
            return CMS_DataLayer.clsDoctor.DeactivateDoctor(DoctorID);
        }
    }
}
