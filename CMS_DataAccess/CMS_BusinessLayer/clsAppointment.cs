using System;
using System.Data;

namespace CMS_BusinessLayer
{
    public class clsAppointment
    {
        public enum enStatus { Scheduled = 1, Completed, Cancelled, NoShow, NoStatus}

        enum enMode { Add, Update}
        enMode Mode;

        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public clsPatient PatientInfo { get { return (PatientID != -1) ? clsPatient.FindByPatientID(PatientID) : new clsPatient(); } }
        public int DoctorID { get; set; }
        public clsDoctor DoctorInfo { get { return (DoctorID != -1) ? clsDoctor.FindByDoctorID(DoctorID) : new clsDoctor(); } }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Status { get; set; }
        public enStatus StatusEnum { get { return (enStatus)Status; } }
        public string Notes { get; set; }

        public clsAppointment()
        {
            Mode = enMode.Add;
            AppointmentID = -1;
            PatientID = -1;
            DoctorID = -1;
            Date = new DateTime();
            Time = new DateTime();
            Status = 1;
            Notes = string.Empty;
        }

        clsAppointment(int appointmentID, int patientID, int doctorID, DateTime date, DateTime time, int status, string notes)
        {
            Mode = enMode.Update;
            AppointmentID = appointmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            Date = date;
            Time = time;
            Status = status;
            Notes = notes;
        }

        public static DataTable GetAllAppointments()
        {
            return CMS_DataLayer.clsAppointment.GetAllAppointments();
        }

        public static DataTable GetAppointmentsByDate(DateTime Date)
        {
            return CMS_DataLayer.clsAppointment.GetAppointmentsByDate(Date);
        }

        public static DataTable GetAppointmentsByPatientID(int PatientID)
        {
            return CMS_DataLayer.clsAppointment.GetAppointmentsByPatientID(PatientID);
        }

        public static DataTable GetAppointmentsByDoctorID(int DoctorID)
        {
            return CMS_DataLayer.clsAppointment.GetAppointmentsByDoctorID(DoctorID);
        }

        public static clsAppointment Find(int AppointmentID)
        {
            int PatientID = -1;
            int DoctorID = -1;
            DateTime Date = new DateTime();
            DateTime Time = new DateTime();
            int Status = -1;
            string Notes = string.Empty;

            if (CMS_DataLayer.clsAppointment.GetAppointmentByID(AppointmentID, ref PatientID, ref DoctorID, ref Date, ref Time,
                ref Status, ref Notes))
            {
                return new clsAppointment(AppointmentID, PatientID, DoctorID, Date, Time, Status, Notes);
            }
            else return null;
        }

        public static clsAppointment Find(DateTime AppointmentDateTime)
        {
            int AppointmentID = -1;
            int PatientID = -1;
            int DoctorID = -1;
            int Status = -1;
            string Notes = string.Empty;

            if (CMS_DataLayer.clsAppointment.GetAppointmentByDateAndTime(AppointmentDateTime, ref AppointmentID, ref PatientID, ref DoctorID,
                ref Status, ref Notes))
            {
                return new clsAppointment(AppointmentID, PatientID, DoctorID, AppointmentDateTime.Date,
                    new DateTime(1800,1,1,AppointmentDateTime.Hour, AppointmentDateTime.Minute, AppointmentDateTime.Second)
                    , Status, Notes);
            }
            else return null;
        }

        bool _Add()
        {
            AppointmentID = CMS_DataLayer.clsAppointment.AddNewAppointment(PatientID, DoctorID, Date, Time, Status, Notes);
            return (AppointmentID != -1);
        }

        bool _Update()
        {
            return CMS_DataLayer.clsAppointment.UpdateAppointment(AppointmentID, PatientID, DoctorID, Date, Time, Status, Notes);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    {
                        if(_Add())
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

        public static bool SetAppointmentStatus(int AppointmentID, enStatus Status)
        {
            return CMS_DataLayer.clsAppointment.SetAppointmentStatus(AppointmentID, (int)Status);
        }

        public static bool DeleteAppointment(int Appointment)
        {
            return CMS_DataLayer.clsAppointment.DeleteAppointment(Appointment);
        }

        public static bool IsThereAppointmentAroundForDoctorID(DateTime dateTime, int DoctorID, ref int AppointmentID)
        {
            return CMS_DataLayer.clsAppointment.IsThereAppointmentAroundForDoctorID(dateTime, DoctorID, ref AppointmentID);
        }
    }
}