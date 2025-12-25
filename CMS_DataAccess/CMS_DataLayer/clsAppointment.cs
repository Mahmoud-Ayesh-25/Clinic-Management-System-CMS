using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CMS_DataLayer
{
    public class clsAppointment
    {
        public static DataTable GetAllAppointments()
        {
            DataTable dtAppointments = new DataTable();

            string query = @"SELECT AppointmentID, (PatientPersonInfo.FirstName + ' ' + PatientPersonInfo.LastName) AS PatientName,
                            (DoctorPersonInfo.FirstName + ' ' + DoctorPersonInfo.LastName) AS DoctorName,
                            AppointmantDate, AppointmantTime,
                            (CASE WHEN Appointments.Status = 1 THEN 'Scheduled' WHEN Appointments.Status = 2 THEN 'Completed'
                            WHEN Appointments.Status = 3 THEN 'Cancelled' WHEN Appointments.Status = 4 THEN 'No Show' END) AS Status,
                            Appointments.Notes FROM Appointments INNER JOIN Patients ON
                            Appointments.PatientID = Patients.PatientID INNER JOIN Doctors ON
                            Appointments.DoctorID = Doctors.DoctorID INNER JOIN People AS PatientPersonInfo ON
                            Patients.PersonID = PatientPersonInfo.PersonID
                            INNER JOIN People AS DoctorPersonInfo ON Doctors.PersonID = DoctorPersonInfo.PersonID
                            ORDER BY AppointmantDate, AppointmantTime;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAppointments.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtAppointments;
        }

        public static DataTable GetAppointmentsByDate(DateTime Date)
        {
            DataTable dtAppointments = new DataTable();

            string query = @"SELECT AppointmentID, (PatientPersonInfo.FirstName + ' ' + PatientPersonInfo.LastName) AS PatientName,
                            (DoctorPersonInfo.FirstName + ' ' + DoctorPersonInfo.LastName) AS DoctorName,
                            AppointmantDate, AppointmantTime,
                            (CASE WHEN Appointments.Status = 1 THEN 'Scheduled' WHEN Appointments.Status = 2 THEN 'Completed'
                            WHEN Appointments.Status = 3 THEN 'Cancelled' WHEN Appointments.Status = 4 THEN 'No Show' END) AS Status,
                            Appointments.Notes FROM Appointments INNER JOIN Patients ON
                            Appointments.PatientID = Patients.PatientID INNER JOIN Doctors ON
                            Appointments.DoctorID = Doctors.DoctorID INNER JOIN People AS PatientPersonInfo ON
                            Patients.PersonID = PatientPersonInfo.PersonID
                            INNER JOIN People AS DoctorPersonInfo ON Doctors.PersonID = DoctorPersonInfo.PersonID
                            WHERE AppointmantDate = @Date
                            ORDER BY AppointmantTime;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Date", Date.Date);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAppointments.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtAppointments;
        }

        public static DataTable GetAppointmentsByPatientID(int PatientID)
        {
            DataTable dtAppointments = new DataTable();

            string query = @"SELECT AppointmentID, (PatientPersonInfo.FirstName + ' ' + PatientPersonInfo.LastName) AS PatientName,
                            (DoctorPersonInfo.FirstName + ' ' + DoctorPersonInfo.LastName) AS DoctorName,
                            AppointmantDate, AppointmantTime,
                            (CASE WHEN Appointments.Status = 1 THEN 'Scheduled' WHEN Appointments.Status = 2 THEN 'Completed'
                            WHEN Appointments.Status = 3 THEN 'Cancelled' WHEN Appointments.Status = 4 THEN 'No Show' END) AS Status,
                            Appointments.Notes FROM Appointments INNER JOIN Patients ON
                            Appointments.PatientID = Patients.PatientID INNER JOIN Doctors ON
                            Appointments.DoctorID = Doctors.DoctorID INNER JOIN People AS PatientPersonInfo ON
                            Patients.PersonID = PatientPersonInfo.PersonID
                            INNER JOIN People AS DoctorPersonInfo ON Doctors.PersonID = DoctorPersonInfo.PersonID
                            WHERE Appointments.PatientID = @PatientID
                            ORDER BY AppointmantDate, AppointmantTime;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAppointments.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtAppointments;
        }

        public static DataTable GetAppointmentsByDoctorID(int DoctorID)
        {
            DataTable dtAppointments = new DataTable();

            string query = @"SELECT AppointmentID, (PatientPersonInfo.FirstName + ' ' + PatientPersonInfo.LastName) AS PatientName,
                            (DoctorPersonInfo.FirstName + ' ' + DoctorPersonInfo.LastName) AS DoctorName,
                            AppointmantDate, AppointmantTime,
                            (CASE WHEN Appointments.Status = 1 THEN 'Scheduled' WHEN Appointments.Status = 2 THEN 'Completed'
                            WHEN Appointments.Status = 3 THEN 'Cancelled' WHEN Appointments.Status = 4 THEN 'No Show' END) AS Status,
                            Appointments.Notes FROM Appointments INNER JOIN Patients ON
                            Appointments.PatientID = Patients.PatientID INNER JOIN Doctors ON
                            Appointments.DoctorID = Doctors.DoctorID INNER JOIN People AS PatientPersonInfo ON
                            Patients.PersonID = PatientPersonInfo.PersonID
                            INNER JOIN People AS DoctorPersonInfo ON Doctors.PersonID = DoctorPersonInfo.PersonID
                            WHERE Appointments.DoctorID = @DoctorID
                            ORDER BY AppointmantDate, AppointmantTime;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAppointments.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtAppointments;
        }

        public static bool GetAppointmentByID(int AppointmentID, ref int PatientID, ref int DoctorID, ref DateTime AppointmentDate,
            ref DateTime AppointmentTime, ref int Status, ref string Notes)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Appointments WHERE AppointmentID = @AppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PatientID = int.Parse(reader[1].ToString());
                                DoctorID = int.Parse(reader[2].ToString());
                                AppointmentDate = DateTime.Parse(reader[3].ToString());
                                AppointmentTime = DateTime.Parse(reader[4].ToString());
                                Status = int.Parse(reader[5].ToString());
                                
                                if (reader[6] == DBNull.Value)
                                    Notes = string.Empty;
                                else
                                    Notes = reader[6].ToString();
                            }
                        }
                    }
                    catch {}
                }
            }

            return IsFound;
        }

        public static bool GetAppointmentByDateAndTime(DateTime AppointmentDateTime, ref int AppointmentID,
            ref int PatientID, ref int DoctorID, ref int Status, ref string Notes)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Appointments WHERE AppointmantDate = @AppointmantDate AND AppointmantTime = @AppointmantTime AND Status = 1;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@AppointmantDate", AppointmentDateTime.Date);
                        command.Parameters.AddWithValue("@AppointmantTime", AppointmentDateTime.TimeOfDay);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                AppointmentID = int.Parse(reader[0].ToString());
                                PatientID = int.Parse(reader[1].ToString());
                                DoctorID = int.Parse(reader[2].ToString());
                                Status = int.Parse(reader[5].ToString());

                                if (reader[6] == DBNull.Value)
                                    Notes = string.Empty;
                                else
                                    Notes = reader[6].ToString();
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static int AddNewAppointment(int PatientID, int DoctorID, DateTime AppointmentDate,
            DateTime AppointmentTime, int Status, string Notes)
        {
            int AppointmentID = -1;

            string query = @"INSERT INTO Appointments
                            VALUES
                            (
	                            @PatientID, @DoctorID, @AppointmentDate, @AppointmentTime, @Status, @Notes
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@AppointmentTime", AppointmentTime);
                        command.Parameters.AddWithValue("@Status", Status);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            AppointmentID = id;
                        }
                    }
                    catch { }
                }
            }

            return AppointmentID;
        }

        public static bool UpdateAppointment(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDate,
            DateTime AppointmentTime, int Status, string Notes)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Appointments
                            SET
	                            PatientID = @PatientID,
	                            DoctorID = @DoctorID,
	                            AppointmantDate = @AppointmentDate,
	                            AppointmantTime = @AppointmentTime,
	                            Status = @Status,
	                            Notes = @Notes
                            WHERE AppointmentID = @AppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@AppointmentTime", AppointmentTime);
                        command.Parameters.AddWithValue("@Status", Status);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }

        public static bool SetAppointmentStatus(int AppointmentID, int Status)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Appointments
                            SET
	                            Status = @Status
                            WHERE AppointmentID = @AppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        command.Parameters.AddWithValue("@Status", Status);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }

        public static bool DeleteAppointment(int AppointmentID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Appointments WHERE AppointmentID = @AppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsDeleted = (rowsEffected > 0);
                    }
                    catch {}
                }
            }

            return IsDeleted;
        }

        public static bool IsThereAppointmentAroundForDoctorID(DateTime dateTime, int DoctorID, ref int AppointmentID)
        {
            bool IsFound = false;

            string query = @"SELECT AppointmentID FROM Appointments
                            WHERE AppointmantDate = @Date
                            AND AppointmantTime > @HourFrom
                            AND AppointmantTime < @HourTo
                            AND DoctorID = @DoctorID
                            AND Status = 1;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Date", dateTime.Date);
                        cmd.Parameters.AddWithValue("@HourFrom", dateTime.AddMinutes(-15).TimeOfDay);
                        cmd.Parameters.AddWithValue("@HourTo", dateTime.AddMinutes(15).TimeOfDay);
                        cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            AppointmentID = id;
                            IsFound = true;
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }
    }
}