using System;
using System.Data;
using System.Data.SqlClient;

namespace CMS_DataLayer
{
    public class clsLog
    {
        public static DataTable GetAllLogs()
        {
            DataTable dtLogs = new DataTable();

            string query = @"SELECT LogID, Username, TableName, RecordID,
                            (CASE WHEN ActionType = 1 THEN 'AddNew' WHEN ActionType = 2
                            THEN 'Update' WHEN ActionType = 3 THEN 'Delete' END)
                            AS ActionType, DateTime 
                            FROM Logs INNER JOIN Users ON Logs.UserID = Users.UserID
                            ORDER BY LogID DESC;";

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
                                dtLogs.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtLogs;
        }

        public static DataTable GetAllLogsByUserID(int UserID)
        {
            DataTable dtLogs = new DataTable();

            string query = @"SELECT LogID, Username, TableName, RecordID,
                            (CASE WHEN ActionType = 1 THEN 'AddNew' WHEN ActionType = 2
                            THEN 'Update' WHEN ActionType = 3 THEN 'Delete' END)
                            AS ActionType, DateTime 
                            FROM Logs INNER JOIN Users ON Logs.UserID = Users.UserID
                            WHERE Logs.UserID = @UserID
                            ORDER BY LogID DESC;";

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
                            if (reader.HasRows)
                            {
                                dtLogs.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtLogs;
        }

        public static DataTable GetAllLogsByTableNameAndRecordID(string TableName, int RecordID)
        {
            DataTable dtLogs = new DataTable();

            string query = @"SELECT LogID, Username, TableName, RecordID,
                            (CASE WHEN ActionType = 1 THEN 'AddNew' WHEN ActionType = 2
                            THEN 'Update' WHEN ActionType = 3 THEN 'Delete' END)
                            AS ActionType, DateTime 
                            FROM Logs INNER JOIN Users ON Logs.UserID = Users.UserID
                            WHERE Logs.TableName = @TableName AND RecordID = @RecordID
                            ORDER BY LogID DESC;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TableName", TableName);
                        command.Parameters.AddWithValue("@RecordID", RecordID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtLogs.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtLogs;
        }

        public static bool GetLogByID(int LogID, ref int UserID, ref string TableName, ref int RecordID,
            ref int ActionType, ref DateTime DateTime)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Logs WHERE LogID = @LogID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@LogID", LogID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                UserID = int.Parse(reader[1].ToString());
                                TableName = reader[2].ToString();
                                RecordID = int.Parse(reader[3].ToString());
                                ActionType = int.Parse(reader[4].ToString());
                                DateTime = DateTime.Parse(reader[5].ToString());
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static int AddNewLog(int UserID, string TableName,  int RecordID,
            int ActionType, DateTime DateTime)
        {
            int LogID = -1;

            string query = @"INSERT INTO Logs
                            VALUES
                            (
	                            @UserID, @TableName, @RecordID, @ActionType, @DateTime
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@TableName", TableName);
                        command.Parameters.AddWithValue("@RecordID", RecordID);
                        command.Parameters.AddWithValue("@ActionType", ActionType);
                        command.Parameters.AddWithValue("@DateTime", DateTime);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            LogID = id;
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return LogID;
        }

        public static bool UpdateLog(int LogID, int UserID, string TableName, int RecordID,
            int ActionType, DateTime DateTime)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Logs
                            SET
	                            UserID = @UserID, 
	                            TableName = @TableName,
	                            RecordID = @RecordID,
	                            ActionType = @ActionType,
	                            DateTime = @DateTime
                            WHERE LogID = @LogID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@LogID", LogID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@TableName", TableName);
                        command.Parameters.AddWithValue("@RecordID", RecordID);
                        command.Parameters.AddWithValue("@ActionType", ActionType);
                        command.Parameters.AddWithValue("@DateTime", DateTime);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool DeleteLog(int LogID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Logs WHERE LogID = @LogID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@LogID", LogID);

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
