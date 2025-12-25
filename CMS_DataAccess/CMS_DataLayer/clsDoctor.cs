using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMS_DataLayer
{
    public class clsDoctor
    {
        public static DataTable GetAllDoctors()
        {
            DataTable dtDoctors = new DataTable();

            string query = @"SELECT Doctors.DoctorID, People.NationalNo, (People.FirstName + ' ' + People.LastName) AS Name, 
                            (CASE WHEN People.Gender = 0 THEN 'Male' ELSE 'Female' END) AS Gender,
                            People.Phone, Doctors.Specialization, Doctors.SubSpecialization, Doctors.LicenseNo, Doctors.LicenseIssueDate,
                            Doctors.LicenseExpDate, Doctors.ExperienceYears, Doctors.WeekDays, Doctors.WorkHoureFrom, Doctors.WorkHoureTo,
                            Doctors.ExaminationPrice, Doctors.IsActive FROM Doctors INNER JOIN People ON Doctors.PersonID = People.PersonID;";

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
                                dtDoctors.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtDoctors;
        }

        public static bool GetDoctorByDoctorID(int DoctorID, ref int PersonID, ref string Specialization, ref string SubSpecialization,
            ref string LicenseNo, ref DateTime LicenseIssueDate, ref DateTime LicenseExpDate, ref byte ExperienceYears,
            ref string WeekDays, ref DateTime WorkHourFrom, ref DateTime WorkHourTo, ref float ExaminationPrice, ref bool IsActive)
        {
            bool IsFound = false;

            string query = $"SELECT * FROM Doctors WHERE DoctorID = @DoctorID;";

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
                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = int.Parse(reader[1].ToString());
                                Specialization = reader[2].ToString();
                                
                                if (reader[3] == DBNull.Value)
                                    SubSpecialization = string.Empty;
                                else
                                    SubSpecialization = reader[3].ToString();

                                LicenseNo = reader[4].ToString();
                                LicenseIssueDate = DateTime.Parse(reader[5].ToString());
                                LicenseExpDate = DateTime.Parse(reader[6].ToString());
                                ExperienceYears = byte.Parse(reader[7].ToString());
                                WeekDays = reader[8].ToString();
                                WorkHourFrom = DateTime.Parse(reader[9].ToString());
                                WorkHourTo = DateTime.Parse(reader[10].ToString());
                                ExaminationPrice = float.Parse(reader[11].ToString());
                                IsActive = (bool)reader[12];
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }
        public static bool IsDoctorExistByLicenseNo(string LicenseNo)
        {
            bool IsFound = false;

            string query = $"SELECT FOUND = 1 FROM Doctors WHERE LicenseNo = @LicenseNo;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@LicenseNo", LicenseNo);

                        object result = command.ExecuteScalar();
                        IsFound = (result != null);
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static bool GetDoctorByPersonID(int PersonID, ref int DoctorID, ref string Specialization, ref string SubSpecialization,
            ref string LicenseNo, ref DateTime LicenseIssueDate, ref DateTime LicenseExpDate, ref byte ExperienceYears,
            ref string WeekDays, ref DateTime WorkHourFrom, ref DateTime WorkHourTo, ref float ExaminationPrice, ref bool IsActive)
        {
            bool IsFound = false;

            string query = $"SELECT * FROM Doctors WHERE PersonID = @PersonID;";

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

                                DoctorID = int.Parse(reader[0].ToString());
                                Specialization = reader[2].ToString();

                                if (reader[3] == DBNull.Value)
                                    SubSpecialization = string.Empty;
                                else
                                    SubSpecialization = reader[3].ToString();

                                LicenseNo = reader[4].ToString();
                                LicenseIssueDate = DateTime.Parse(reader[5].ToString());
                                LicenseExpDate = DateTime.Parse(reader[6].ToString());
                                ExperienceYears = byte.Parse(reader[7].ToString());
                                WeekDays = reader[8].ToString();
                                WorkHourFrom = DateTime.Parse(reader[9].ToString());
                                WorkHourTo = DateTime.Parse(reader[10].ToString());
                                ExaminationPrice = float.Parse(reader[11].ToString());
                                IsActive = (bool)reader[12];
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static int AddNewDoctor(int PersonID, string Specialization, string SubSpecialization, string LicenseNo,
            DateTime LicenseIssueDate, DateTime LicenseExpDate, byte ExperienceYears, string WeekDays, DateTime WorkHourFrom,
            DateTime WorkHourTo, float ExaminationPrice, bool IsActive)
        {
            int DoctorID = -1;

            string query = @"INSERT INTO Doctors
                            VALUES
                            (
	                            @PersonID, @Specialization, @SubSpecialization, @LicenseNo,
                                @LicenseIssueDate, @LicenseExpDate, @ExperienceYears, @WeekDays,
                                @WorkHourFrom, @WorkHourTo, @ExaminationPrice, @IsActive
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
                        command.Parameters.AddWithValue("@Specialization", Specialization);

                        if (string.IsNullOrEmpty(SubSpecialization))
                            command.Parameters.AddWithValue("@SubSpecialization", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@SubSpecialization", SubSpecialization);

                        command.Parameters.AddWithValue("@LicenseNo", LicenseNo);
                        command.Parameters.AddWithValue("@LicenseIssueDate", LicenseIssueDate);
                        command.Parameters.AddWithValue("@LicenseExpDate", LicenseExpDate);
                        command.Parameters.AddWithValue("@ExperienceYears", ExperienceYears);
                        command.Parameters.AddWithValue("@WeekDays", WeekDays);
                        command.Parameters.AddWithValue("@WorkHourFrom", WorkHourFrom);
                        command.Parameters.AddWithValue("@WorkHourTo", WorkHourTo);
                        command.Parameters.AddWithValue("@ExaminationPrice", ExaminationPrice);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            DoctorID = id;
                        }
                    }
                    catch { }
                }
            }

            return DoctorID;
        }

        public static bool UpdateDoctor(int DoctorID, int PersonID, string Specialization, string SubSpecialization,
            string LicenseNo, DateTime LicenseIssueDate, DateTime LicenseExpDate, byte ExperienceYears, string WeekDays,
            DateTime WorkHourFrom, DateTime WorkHourTo, float ExaminationPrice, bool IsActive)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Doctors
                            SET
	                            PersonID = @PersonID,
	                            Specialization = @Specialization,
	                            SubSpecialization = @SubSpecialization,
                                LicenseNo = @LicenseNo,
	                            LicenseIssueDate = @LicenseIssueDate,
	                            LicenseExpDate = @LicenseExpDate,
	                            ExperienceYears = @ExperienceYears,
	                            WeekDays = @WeekDays,
	                            WorkHoureFrom = @WorkHourFrom,
	                            WorkHoureTo = @WorkHourTo,
	                            ExaminationPrice = @ExaminationPrice,
	                            IsActive = @IsActive
                            WHERE DoctorID = @DoctorID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Specialization", Specialization);

                        if (string.IsNullOrEmpty(SubSpecialization))
                            command.Parameters.AddWithValue("@SubSpecialization", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@SubSpecialization", SubSpecialization);

                        command.Parameters.AddWithValue("@LicenseNo", LicenseNo);
                        command.Parameters.AddWithValue("@LicenseIssueDate", LicenseIssueDate);
                        command.Parameters.AddWithValue("@LicenseExpDate", LicenseExpDate);
                        command.Parameters.AddWithValue("@ExperienceYears", ExperienceYears);
                        command.Parameters.AddWithValue("@WeekDays", WeekDays);
                        command.Parameters.AddWithValue("@WorkHourFrom", WorkHourFrom);
                        command.Parameters.AddWithValue("@WorkHourTo", WorkHourTo);
                        command.Parameters.AddWithValue("@ExaminationPrice", ExaminationPrice);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }

        public static bool ActivateDoctor(int DoctorID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Doctors
                            SET
	                            IsActive = 1
                            WHERE DoctorID = @DoctorID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }

        public static bool DeactivateDoctor(int DoctorID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Doctors
                            SET
	                            IsActive = 0
                            WHERE DoctorID = @DoctorID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }

        public static bool DeleteDoctor(int DoctorID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Doctors
                            WHERE DoctorID = @DoctorID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

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
