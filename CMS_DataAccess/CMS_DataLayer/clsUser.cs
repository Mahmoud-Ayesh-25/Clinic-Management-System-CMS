using System;
using System.Data;
using System.Data.SqlClient;

namespace CMS_DataLayer
{
    public class clsUser
    {
        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();

            string query = @"SELECT UserID, (FirstName + ' ' + LastName) AS  PersonName, Username,
                            PermissionsTypeTitle, IsActive FROM Users INNER JOIN PermissionsTypes
                            ON Users.PermissionsTypeID = PermissionsTypes.PermissionsTypeID
                            INNER JOIN People ON Users.PersonID = People.PersonID;";

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
                                dtUsers.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtUsers;
        }

        public static bool GetUserByUserID(int UserID, ref int PersonID, ref string Username,
            ref string Password, ref string Salt, ref int PermissionType, ref bool IsActive)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Users WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = int.Parse(reader[1].ToString());
                                Username = reader[2].ToString();
                                Password = reader[3].ToString();
                                Salt = reader[4].ToString();
                                PermissionType = int.Parse(reader[5].ToString());
                                IsActive = (bool)reader[6];
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static bool GetUserByPersonID(int PersonID, ref int UserID, ref string Username,
           ref string Password, ref string Salt, ref int PermissionType, ref bool IsActive)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Users WHERE PersonID = @PersonID;";

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

                                UserID = int.Parse(reader[0].ToString());
                                Username = reader[2].ToString();
                                Password = reader[3].ToString();
                                Salt = reader[4].ToString();
                                PermissionType = int.Parse(reader[5].ToString());
                                IsActive = (bool)reader[6];
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static bool IsUserExistByUsername(string Username)
        {
            bool IsFound = false;

            string query = @"SELECT FOUND = 1 FROM Users WHERE Username = @Username;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Username", Username);

                        object result = command.ExecuteScalar();

                        IsFound = (result != null);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static bool GetUserByUsernameAndPassword(string Username, ref string Password, ref string Salt, ref int UserID, ref int PersonID,
            ref int PermissionType, ref bool IsActive)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Users WHERE Username = @Username;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Username", Username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Password = reader[3].ToString();
                                UserID = int.Parse(reader[0].ToString());
                                PersonID = int.Parse(reader[1].ToString());
                                Salt = reader[4].ToString();
                                PermissionType = int.Parse(reader[5].ToString());
                                IsActive = (bool)reader[6];
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static int AddNewUser(int PersonID, string Username, string Password, string Salt, int PermissionType, bool IsActive)
        {
            int UserID = -1;

            string query = @"INSERT INTO Users
                            VALUES
                            (
	                            @PersonID, @Username, @Password, @Salt, @PermissionType, @IsActive
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
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Salt", Salt);
                        command.Parameters.AddWithValue("@PermissionType", PermissionType);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            UserID = id;
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string Username, string Password, string Salt, int PermissionType, bool IsActive)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Users
                            SET
	                            PersonID = @PersonID,
	                            Username = @Username,
	                            Password = @Password,
	                            Salt = @Salt,
	                            PermissionsTypeID = @PermissionsTypeID,
	                            IsActive = @IsActive
                            WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Salt", Salt);
                        command.Parameters.AddWithValue("@PermissionsTypeID", PermissionType);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool ActivateUser(int UserID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Users
                            SET
	                            IsActive = 1
                            WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool DeactivateUser(int UserID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Users
                            SET
	                            IsActive = 0
                            WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Users WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

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
