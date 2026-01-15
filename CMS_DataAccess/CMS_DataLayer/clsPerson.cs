using System;
using System.Data;
using System.Data.SqlClient;

namespace CMS_DataLayer
{
    public class clsPerson
    {
        public static DataTable GetAllPeople()
        {
            DataTable dtPeople = new DataTable();

            string query = @"SELECT PersonID, NationalNo, (FirstName + (CASE WHEN SecondName IS NULL THEN '' ELSE ' ' + SecondName END) +
                            (CASE WHEN ThirdName IS NULL THEN '' ELSE ' ' + ThirdName END) + ' ' + LastName) AS Name, DateOfBirth,
                            (DATEDIFF(Year, DateOfBirth, GETDATE())) AS Age, (CASE WHEN Gender = 0 THEN 'Male' ELSE 'Female' END) AS Gender,
                            Phone, Email, Address FROM People;";

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
                                dtPeople.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtPeople;
        }

        public static bool GetPersonByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Phone,
            ref string Email, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM People WHERE PersonID = @PersonID;";

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

                                NationalNo = reader[1].ToString();
                                FirstName = reader[2].ToString();

                                if (reader[3] == DBNull.Value)
                                    SecondName = string.Empty;
                                else
                                    SecondName = reader[3].ToString();

                                if (reader[4] == DBNull.Value)
                                    ThirdName = string.Empty;
                                else
                                    ThirdName = reader[4].ToString();

                                LastName = reader[5].ToString();
                                DateOfBirth = DateTime.Parse(reader[6].ToString());
                                Gender = byte.Parse(reader[7].ToString());
                                Phone = reader[8].ToString();

                                if (reader[9] == DBNull.Value)
                                    Email = string.Empty;
                                else
                                    Email = reader[9].ToString();

                                if (reader[10] == DBNull.Value)
                                    Address = string.Empty;
                                else
                                    Address = reader[10].ToString();

                                if (reader[11] == DBNull.Value)
                                    ImagePath = string.Empty;
                                else
                                    ImagePath = reader[11].ToString();
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static bool GetPersonByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Phone,
            ref string Email, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM People WHERE NationalNo = @NationalNo;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = int.Parse(reader[0].ToString());
                                FirstName = reader[2].ToString();

                                if (reader[3] == DBNull.Value)
                                    SecondName = string.Empty;
                                else
                                    SecondName = reader[3].ToString();

                                if (reader[4] == DBNull.Value)
                                    ThirdName = string.Empty;
                                else
                                    ThirdName = reader[4].ToString();

                                LastName = reader[5].ToString();
                                DateOfBirth = DateTime.Parse(reader[6].ToString());
                                Gender = byte.Parse(reader[7].ToString());
                                Phone = reader[8].ToString();

                                if (reader[9] == DBNull.Value)
                                    Email = string.Empty;
                                else
                                    Email = reader[9].ToString();

                                if (reader[10] == DBNull.Value)
                                    Address = string.Empty;
                                else
                                    Address = reader[10].ToString();

                                if (reader[11] == DBNull.Value)
                                    ImagePath = string.Empty;
                                else
                                    ImagePath = reader[11].ToString();
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gender, string Phone, string Email, string Address, string ImagePath)
        {
            int PersonID = -1;

            string query = @"INSERT INTO People
                            VALUES
                            (
	                            @NationalNo, @FirstName, @SecondName, @ThirdName, @LastName,
                                @DateOfBirth, @Gender, @Phone, @Email, @Address, @ImagePath
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Phone", Phone);

                        if (string.IsNullOrEmpty(SecondName))
                            command.Parameters.AddWithValue("@SecondName", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@SecondName", SecondName);

                        if (string.IsNullOrEmpty(ThirdName))
                            command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);

                        if (string.IsNullOrEmpty(Email))
                            command.Parameters.AddWithValue("@Email", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Email", Email);

                        if (string.IsNullOrEmpty(Address))
                            command.Parameters.AddWithValue("@Address", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Address", Address);

                        if (string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);


                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            PersonID = id;
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gender, string Phone, string Email, string Address, string ImagePath)
        {
            bool IsUpdate = false;

            string query = @"UPDATE People
                            SET
	                            NationalNo = @NationalNo,
	                            FirstName = @FirstName,
	                            SecondName = @SecondName,
	                            ThirdName = @ThirdName,
	                            LastName = @LastName,
	                            DateOfBirth = @DateOfBirth,
	                            Gender = @Gender,
	                            Phone = @Phone,
	                            Email = @Email,
	                            Address = @Address,
	                            ImagePath = @ImagePath
                            WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Phone", Phone);

                        if (string.IsNullOrEmpty(SecondName))
                            command.Parameters.AddWithValue("@SecondName", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@SecondName", SecondName);

                        if (string.IsNullOrEmpty(ThirdName))
                            command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);

                        if (string.IsNullOrEmpty(Email))
                            command.Parameters.AddWithValue("@Email", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Email", Email);

                        if (string.IsNullOrEmpty(Address))
                            command.Parameters.AddWithValue("@Address", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Address", Address);

                        if (string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);


                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdate = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdate;
        }
        
        public static bool DeletePerson(int PersonID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM People WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

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