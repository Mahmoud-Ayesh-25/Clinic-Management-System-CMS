using System;
using System.Data;
using System.Data.SqlClient;

namespace CMS_DataLayer
{
    public class clsVisit
    {
        public static DataTable GetAllVisits()
        {
            DataTable dtVisits = new DataTable();

            string query = @"SELECT VisitID, AppointmentID, (VisitPatientInfo.FirstName +
                            ' ' + VisitPatientInfo.LastName) AS PatientName,
                            (VisitDoctorInfo.FirstName + ' ' + VisitDoctorInfo.LastName)
                            AS DoctorName, VisitDate, VisitTime,
                            (CASE WHEN VisitStatus = 1 THEN 'Waiting' WHEN VisitStatus = 2
                            THEN 'In Progress' WHEN VisitStatus = 3 THEN 'Completed' WHEN
                            VisitStatus = 4 THEN 'Cancelled' END) AS VisitStatus,
                            EmergencyIncome,
                            (CASE WHEN VisitReason = 1 THEN 'New Examination' WHEN VisitReason
                            = 2 THEN 'Follow Up' END) AS VisitReason
                            , PaymentAmount, PaidAmount = (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID),
                            (CASE WHEN (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID) = 0 
                            THEN 'UnPaid' WHEN  PaymentAmount = (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID)
                            THEN 'Paid' WHEN PaymentAmount > (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID)
                            THEN 'Partially Paid' ELSE 'Error' END)
                            AS PaymentStatus
                            FROM Visits INNER JOIN Patients ON
                            Visits.PatientID = Patients.PatientID INNER JOIN
                            Doctors ON Visits.DoctorID = Doctors.DoctorID
                            INNER JOIN People AS VisitPatientInfo ON
                            Patients.PersonID = VisitPatientInfo.PersonID
                            INNER JOIN People AS VisitDoctorInfo ON
                            Doctors.PersonID = VisitDoctorInfo.PersonID
                            ORDER BY VisitDate, VisitTime;";

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
                                dtVisits.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtVisits;
        }

        public static DataTable GetAllVisitsForDashboard()
        {
            DataTable dtVisits = new DataTable();

            string query = @"SELECT VisitID, (VisitPatientInfo.FirstName +
                            ' ' + VisitPatientInfo.LastName) AS PatientName,
                            (VisitDoctorInfo.FirstName + ' ' + VisitDoctorInfo.LastName)
                            AS DoctorName, VisitDate, VisitTime, VisitStatus, EmergencyIncome,
                            (CASE WHEN VisitReason = 1 THEN 'New Examination' WHEN VisitReason
                            = 2 THEN 'Follow Up' END) AS VisitReason
                            , PaymentAmount, PaidAmount = (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID)
                            FROM Visits INNER JOIN Patients ON
                            Visits.PatientID = Patients.PatientID INNER JOIN
                            Doctors ON Visits.DoctorID = Doctors.DoctorID
                            INNER JOIN People AS VisitPatientInfo ON
                            Patients.PersonID = VisitPatientInfo.PersonID
                            INNER JOIN People AS VisitDoctorInfo ON
                            Doctors.PersonID = VisitDoctorInfo.PersonID
                            ORDER BY VisitDate, VisitTime;";

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
                                dtVisits.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtVisits;
        }

        public static DataTable GetVisitsByPatientID(int PatientID)
        {
            DataTable dtVisits = new DataTable();

            string query = @"SELECT VisitID, AppointmentID, (VisitPatientInfo.FirstName +
                            ' ' + VisitPatientInfo.LastName) AS PatientName,
                            (VisitDoctorInfo.FirstName + ' ' + VisitDoctorInfo.LastName)
                            AS DoctorName, VisitDate, VisitTime,
                            (CASE WHEN VisitStatus = 1 THEN 'Waiting' WHEN VisitStatus = 2
                            THEN 'In Progress' WHEN VisitStatus = 3 THEN 'Completed' WHEN
                            VisitStatus = 4 THEN 'Cancelled' END) AS VisitStatus,
                            EmergencyIncome,
                            (CASE WHEN VisitReason = 1 THEN 'New Examination' WHEN VisitReason
                            = 2 THEN 'Follow Up' END) AS VisitReason
                            , PaymentAmount, PaidAmount = (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID),
                            (CASE WHEN (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID) = 0 
                            THEN 'UnPaid' WHEN  PaymentAmount = (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID)
                            THEN 'Paid' WHEN PaymentAmount > (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID)
                            THEN 'Partially Paid' ELSE 'Error' END)
                            AS PaymentStatus
                            FROM Visits INNER JOIN Patients ON
                            Visits.PatientID = Patients.PatientID INNER JOIN
                            Doctors ON Visits.DoctorID = Doctors.DoctorID
                            INNER JOIN People AS VisitPatientInfo ON
                            Patients.PersonID = VisitPatientInfo.PersonID
                            INNER JOIN People AS VisitDoctorInfo ON
                            Doctors.PersonID = VisitDoctorInfo.PersonID
                            WHERE Patients.PatientID = @PatientID
                            ORDER BY VisitDate, VisitTime;";

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
                                dtVisits.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtVisits;
        }

        public static DataTable GetVisitsByDoctorID(int DoctorID)
        {
            DataTable dtVisits = new DataTable();

            string query = @"SELECT VisitID, AppointmentID, (VisitPatientInfo.FirstName +
                            ' ' + VisitPatientInfo.LastName) AS PatientName,
                            (VisitDoctorInfo.FirstName + ' ' + VisitDoctorInfo.LastName)
                            AS DoctorName, VisitDate, VisitTime,
                            (CASE WHEN VisitStatus = 1 THEN 'Waiting' WHEN VisitStatus = 2
                            THEN 'In Progress' WHEN VisitStatus = 3 THEN 'Completed' WHEN
                            VisitStatus = 4 THEN 'Cancelled' END) AS VisitStatus,
                            EmergencyIncome,
                            (CASE WHEN VisitReason = 1 THEN 'New Examination' WHEN VisitReason
                            = 2 THEN 'Follow Up' END) AS VisitReason
                            , PaymentAmount, PaidAmount = (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID),
                            (CASE WHEN (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID) = 0 
                            THEN 'UnPaid' WHEN  PaymentAmount = (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID)
                            THEN 'Paid' WHEN PaymentAmount > (SELECT ISNULL(SUM(PaidAmount), 0)
                            FROM Payments WHERE Visits.VisitID = Payments.VisitID)
                            THEN 'Partially Paid' ELSE 'Error' END)
                            AS PaymentStatus
                            FROM Visits INNER JOIN Patients ON
                            Visits.PatientID = Patients.PatientID INNER JOIN
                            Doctors ON Visits.DoctorID = Doctors.DoctorID
                            INNER JOIN People AS VisitPatientInfo ON
                            Patients.PersonID = VisitPatientInfo.PersonID
                            INNER JOIN People AS VisitDoctorInfo ON
                            Doctors.PersonID = VisitDoctorInfo.PersonID
                            WHERE Doctors.DoctorID = @DoctorID
                            ORDER BY VisitDate, VisitTime;";

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
                                dtVisits.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtVisits;
        }

        public static bool GetVisitByID(int VisitID, ref int AppointmentID, ref int PatientID, ref int DoctorID, ref DateTime VisitDate,
            ref DateTime VisitTime, ref int VisitStatus, ref int ExaminationID, ref bool EmergencyIncome, ref int VisitReason,
            ref float PaymentAmount)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Visits WHERE VisitID = @VisitID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@VisitID", VisitID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                if (reader[1] == DBNull.Value)
                                    AppointmentID = -1;
                                else
                                    AppointmentID = int.Parse(reader[1].ToString());

                                PatientID = int.Parse(reader[2].ToString());
                                DoctorID = int.Parse(reader[3].ToString());
                                VisitDate = DateTime.Parse(reader[4].ToString());
                                VisitTime = DateTime.Parse(reader[5].ToString());
                                VisitStatus = int.Parse(reader[6].ToString());

                                if (reader[7] == DBNull.Value)
                                    ExaminationID = -1;
                                else
                                    ExaminationID = int.Parse(reader[7].ToString());

                                EmergencyIncome = (bool)reader[8];
                                VisitReason = int.Parse(reader[9].ToString());
                                PaymentAmount = float.Parse(reader[10].ToString());
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static int AddNewVisit(int AppointmentID, int PatientID, int DoctorID, DateTime VisitDate,
            DateTime VisitTime, int VisitStatus, int ExaminationID, bool EmergencyIncome, int VisitReason,
            float PaymentAmount)
        {
            int VisitID = -1;

            string query = @"INSERT INTO Visits
                            VALUES
                            (
	                            @AppointmentID, @PatientID, @DoctorID, @VisitDate, @VisitTime, @VisitStatus,
                                @ExaminationID, @EmergencyIncome, @VisitReason, @PaymentAmount
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        if (AppointmentID == -1)
                            command.Parameters.AddWithValue("@AppointmentID", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@VisitDate", VisitDate);
                        command.Parameters.AddWithValue("@VisitTime", VisitTime);
                        command.Parameters.AddWithValue("@VisitStatus", VisitStatus);

                        if (ExaminationID == -1)
                            command.Parameters.AddWithValue("@ExaminationID", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ExaminationID", ExaminationID);

                        command.Parameters.AddWithValue("@EmergencyIncome", EmergencyIncome);
                        command.Parameters.AddWithValue("@VisitReason", VisitReason);
                        command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            VisitID = id;
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return VisitID;
        }

        public static bool UpdateVisit(int VisitID, int AppointmentID, int PatientID, int DoctorID, DateTime VisitDate,
            DateTime VisitTime, int VisitStatus, int ExaminationID, bool EmergencyIncome, int VisitReason,
            float PaymentAmount)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Visits
                            SET
	                            AppointmentID = @AppointmentID,
	                            PatientID = @PatientID,
	                            DoctorID = @DoctorID,
	                            VisitDate = @VisitDate,
	                            VisitTime = @VisitTime,
	                            VisitStatus = @VisitStatus, 
	                            ExaminationID = @ExaminationID,
	                            EmergencyIncome = @EmergencyIncome,
	                            VisitReason = @VisitReason,
	                            PaymentAmount = @PaymentAmount
                            WHERE VisitID = @VisitID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@VisitID", VisitID);

                        if (AppointmentID == -1)
                            command.Parameters.AddWithValue("@AppointmentID", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@VisitDate", VisitDate);
                        command.Parameters.AddWithValue("@VisitTime", VisitTime);
                        command.Parameters.AddWithValue("@VisitStatus", VisitStatus);

                        if (ExaminationID == -1)
                            command.Parameters.AddWithValue("@ExaminationID", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ExaminationID", ExaminationID);

                        command.Parameters.AddWithValue("@EmergencyIncome", EmergencyIncome);
                        command.Parameters.AddWithValue("@VisitReason", VisitReason);
                        command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool SetEmergencyTrue(int VisitID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Visits
                            SET
	                            EmergencyIncome = 1
                            WHERE VisitID = @VisitID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@VisitID", VisitID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool SetVisitStatus(int VisitID, int VisitStatus)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Visits
                            SET
	                            VisitStatus = @VisitStatus
                            WHERE VisitID = @VisitID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@VisitID", VisitID);
                        command.Parameters.AddWithValue("@VisitStatus", VisitStatus);
                        
                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool DeleteVisit(int VisitID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Visits WHERE VisitID = @VisitID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@VisitID", VisitID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsDeleted = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsDeleted;
        }
    }
}