using System;
using System.Data;
using System.Data.SqlClient;

namespace CMS_DataLayer
{
    public class clsPatient
    {
        public static DataTable GetAllPatients()
        {
            DataTable dtPatients = new DataTable();

            string query = @"SELECT PatientID, (People.FirstName + (CASE WHEN People.SecondName IS NULL
                            THEN '' ELSE ' ' + People.SecondName END) + (CASE WHEN People.ThirdName IS
                            NULL THEN '' ELSE ' ' + People.ThirdName END) + ' ' + People.LastName)
                            AS Name, (CASE WHEN People.Gender = 0 THEN 'Male' ELSE 'Female' END) AS Gender,
                            Allergies, ChronicDiseases, CurrentEducations, Notes, CreateDate, IsActive
                            FROM Patients INNER JOIN People ON Patients.PersonID = People.PersonID;";

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
                                dtPatients.Load(reader);   
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtPatients;
        }

        public static bool GetPatientByPatientID(int PatientID, ref int PersonID, ref string Allergies, ref string ChronicDiseases,
            ref string CurrentEducations, ref string Notes, ref DateTime CreateDate, ref bool IsActive)
        {
            bool IsFound = false;

            string query = $"SELECT * FROM Patients WHERE PatientID = @PatientID;";

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
                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = int.Parse(reader[1].ToString());
                                
                                if (reader[2] == DBNull.Value)
                                    Allergies = string.Empty;
                                else
                                    Allergies = reader[2].ToString();

                                if (reader[3] == DBNull.Value)
                                    ChronicDiseases = string.Empty;
                                else
                                    ChronicDiseases = reader[3].ToString();

                                if (reader[4] == DBNull.Value)
                                    CurrentEducations = string.Empty;
                                else
                                    CurrentEducations = reader[4].ToString();

                                if (reader[5] == DBNull.Value)
                                    Notes = string.Empty;
                                else
                                    Notes = reader[5].ToString();

                                CreateDate = DateTime.Parse(reader[6].ToString());

                                IsActive = (bool)reader[7];
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static bool GetPatientByPersonID(int PersonID, ref int PatientID, ref string Allergies, ref string ChronicDiseases,
            ref string CurrentEducations, ref string Notes, ref DateTime CreateDate, ref bool IsActive)
        {
            bool IsFound = false;

            string query = $"SELECT * FROM Patients WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PatientID = int.Parse(reader[0].ToString());

                                if (reader[2] == DBNull.Value)
                                    Allergies = string.Empty;
                                else
                                    Allergies = reader[2].ToString();

                                if (reader[3] == DBNull.Value)
                                    ChronicDiseases = string.Empty;
                                else
                                    ChronicDiseases = reader[3].ToString();

                                if (reader[4] == DBNull.Value)
                                    CurrentEducations = string.Empty;
                                else
                                    CurrentEducations = reader[4].ToString();

                                if (reader[5] == DBNull.Value)
                                    Notes = string.Empty;
                                else
                                    Notes = reader[5].ToString();

                                CreateDate = DateTime.Parse(reader[6].ToString());

                                IsActive = (bool)reader[7];
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static int AddNewPatient(int PersonID, string Allergies, string ChronicDiseases, string CurrentEducations,
            string Notes, bool IsActive)
        {
            int PatientID = -1;

            string query = @"INSERT INTO Patients
                            VALUES
                            (
	                            @PersonID, @Allergies, @ChronicDiseases, @CurrentEducations, @Notes, @CreateDate, @IsActive
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        if (string.IsNullOrEmpty(Allergies))
                            command.Parameters.AddWithValue("@Allergies", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Allergies", Allergies);

                        if (string.IsNullOrEmpty(ChronicDiseases))
                            command.Parameters.AddWithValue("@ChronicDiseases", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ChronicDiseases", ChronicDiseases);

                        if (string.IsNullOrEmpty(CurrentEducations))
                            command.Parameters.AddWithValue("@CurrentEducations", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@CurrentEducations", CurrentEducations);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

                        command.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            PatientID = id;
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return PatientID;
        }

        public static bool UpdatePatient(int PatientID, int PersonID, string Allergies, string ChronicDiseases, string CurrentEducations,
            string Notes, bool IsActive)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Patients
                            SET
	                            PersonID = @PersonID,
	                            Allergies = @Allergies,
	                            ChronicDiseases = @ChronicDiseases,
	                            CurrentEducations = @CurrentEducations,
	                            Notes = @Notes,
	                            IsActive = @IsActive
                            WHERE PatientID = @PatientID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        if (string.IsNullOrEmpty(Allergies))
                            command.Parameters.AddWithValue("@Allergies", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Allergies", Allergies);

                        if (string.IsNullOrEmpty(ChronicDiseases))
                            command.Parameters.AddWithValue("@ChronicDiseases", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ChronicDiseases", ChronicDiseases);

                        if (string.IsNullOrEmpty(CurrentEducations))
                            command.Parameters.AddWithValue("@CurrentEducations", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@CurrentEducations", CurrentEducations);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool ActivatePatient(int PatientID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Patients
                            SET
	                            IsActive = 1
                            WHERE PatientID = @PatientID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool DeactivatePatient(int PatientID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Patients
                            SET
	                            IsActive = 0
                            WHERE PatientID = @PatientID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool DeletePatients(int PatientID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Patients WHERE PatientID = @PatientID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);

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