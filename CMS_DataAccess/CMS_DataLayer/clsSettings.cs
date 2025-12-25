using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    catch { }
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
                    catch { }
                }
            }

            return IsUpdated;
        }
    }
}
