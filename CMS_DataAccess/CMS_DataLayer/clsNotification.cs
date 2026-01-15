using System;
using System.Data;
using System.Data.SqlClient;

namespace CMS_DataLayer
{
    public class clsNotification
    {
        public static DataTable GetAllNotifications()
        {
            DataTable dtNotifications = new DataTable();

            string query = @"SELECT NotificationID, NotificationMessage, Username, NotificationTime,
                            NotificationsDate, IsRead FROM Notifications INNER JOIN Users ON
                            Notifications.UserID = Users.UserID
                            ORDER BY NotificationID DESC;";

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
                                dtNotifications.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtNotifications;
        }

        public static bool GetNotificationByID(int NotificationID, ref int UserID, ref string Message, ref DateTime Time
            , ref DateTime Date, ref bool IsRead)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Notifications WHERE NotificationID = @NotificationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@NotificationID", NotificationID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                UserID = int.Parse(reader[2].ToString());
                                Message = reader[1].ToString();
                                Time = DateTime.Parse(reader[3].ToString());
                                Date = DateTime.Parse(reader[4].ToString());
                                IsRead = (bool)reader[5];
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static int AddNewNotification(int UserID, string Message, DateTime Time, DateTime Date, bool IsRead)
        {
            int NotificationID = -1;

            string query = @"INSERT INTO Notifications
                            VALUES
                            (
	                            @Message, @UserID, @Time, @Date, @IsRead
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
                        command.Parameters.AddWithValue("@Message", Message);
                        command.Parameters.AddWithValue("@Time", Time);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@IsRead", IsRead);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            NotificationID = id;
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return NotificationID;
        }

        public static bool UpdateNotification(int NotificationID, int UserID, string Message, DateTime Time, DateTime Date, bool IsRead)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Notifications
                            SET
	                            NotificationMessage = @NotificationMessage,
	                            UserID = @UserID,
	                            NotificationTime = @NotificationTime,
	                            NotificationsDate = @NotificationsDate,
	                            IsRead = @IsRead
                            WHERE NotificationID = @NotificationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@NotificationID", NotificationID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@NotificationMessage", Message);
                        command.Parameters.AddWithValue("@NotificationTime", Time);
                        command.Parameters.AddWithValue("@NotificationsDate", Date);
                        command.Parameters.AddWithValue("@IsRead", IsRead);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool SetNotificationRead(int NotificationID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Notifications
                            SET
	                            IsRead = 1
                            WHERE NotificationID = @NotificationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@NotificationID", NotificationID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool DeleteNotification(int NotificationID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Notifications WHERE NotificationID = @NotificationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@NotificationID", NotificationID);

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