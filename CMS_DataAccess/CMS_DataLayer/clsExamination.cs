using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_DataLayer
{
    public class clsExamination
    {
        public static bool GetExaminationByID(int ExaminationID, ref string Symptoms, ref string Diagnosis,
            ref string Notes, ref string Prescription)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Examinations WHERE ExaminationID = @ExaminationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ExaminationID", ExaminationID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Symptoms = reader[1].ToString();
                                Diagnosis = reader[2].ToString();
                                Notes = reader[3].ToString();
                                Prescription = reader[4].ToString();
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static int AddNewExamination(string Symptoms, string Diagnosis, string Notes, string Prescription)
        {
            int ExaminationID = -1;

            string query = @"INSERT INTO Examinations
                            VALUES
                            (
	                            @Symptoms, @Diagnosis, @Notes, @Prescription
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Symptoms", Symptoms);
                        command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                        command.Parameters.AddWithValue("@Notes", Notes);
                        command.Parameters.AddWithValue("@Prescription", Prescription);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            ExaminationID = id;
                        }
                    }
                    catch { }
                }
            }

            return ExaminationID;
        }

        public static bool UpdateExamination(int ExaminationID, string Symptoms, string Diagnosis, string Notes, string Prescription)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Examinations
                            SET
                                Symptoms = @Symptoms,
                                Diagnosis = @Diagnosis,
                                Notes = @Notes,
                                Prescription = @Prescription
                            WHERE ExaminationID = @ExaminationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ExaminationID", ExaminationID);
                        command.Parameters.AddWithValue("@Symptoms", Symptoms);
                        command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                        command.Parameters.AddWithValue("@Notes", Notes);
                        command.Parameters.AddWithValue("@Prescription", Prescription);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }

        public static bool DeleteExamination(int ExaminationID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Examinations WHERE ExaminationID = @ExaminationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ExaminationID", ExaminationID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsDeleted = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsDeleted;
        }
    }
}
