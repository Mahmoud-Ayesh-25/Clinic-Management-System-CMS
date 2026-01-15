using System;
using System.Data.SqlClient;

namespace CMS_DataLayer
{
    public class clsSettings
    {
        public static bool GetSettings(ref bool Notifications, ref bool AutoSave, ref string Location)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Settings;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Notifications = (bool)reader[0];
                                AutoSave = (bool)reader[1];
                                Location = reader[2].ToString();
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static bool UpdateNotifications(bool Notifications)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Settings
                            SET
	                            Notifications = @Notifications;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Notifications", Notifications);

                        int result = command.ExecuteNonQuery();
                        IsUpdated = (result > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }
    }
}
