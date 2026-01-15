using System;
using System.Data;
using System.Data.SqlClient;

namespace CMS_DataLayer
{
    public class clsPaymentMethod
    {
        public static DataTable GetAllPaymentMethods()
        {
            DataTable dtPaymentMethods = new DataTable();

            string query = @"SELECT * FROM PaymentMethodes;";

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
                                dtPaymentMethods.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtPaymentMethods;
        }

        public static bool GetPaymentMethodByID(int PaymentMethodID, ref string PaymentMethodTitle)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM PaymentMethodes WHERE PaymentMethodID = @PaymentMethodID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PaymentMethodTitle = reader[1].ToString();
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static bool IsPaymentMethodExistByMethodName(string PaymentMethodTitle)
        {
            bool IsFound = false;

            string query = @"SELECT FOUND = 1 FROM PaymentMethodes WHERE PaymentMethodTitle = @PaymentMethodTitle;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PaymentMethodTitle", PaymentMethodTitle);

                        object result = command.ExecuteScalar();
                        IsFound = (result != null);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static int AddNewPaymentMethod(string PaymentMethodTitle)
        {
            int PaymentMethodID = -1;

            string query = @"INSERT INTO PaymentMethodes
                            VALUES
                            (
	                            @PaymentMethodTitle
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PaymentMethodTitle", PaymentMethodTitle);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            PaymentMethodID = id;
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return PaymentMethodID;
        }

        public static bool UpdatePaymentMethod(int PaymentMethodID, string PaymentMethodTitle)
        {
            bool IsUpdated = false;

            string query = @"UPDATE PaymentMethodes
                            SET
                                PaymentMethodTitle = @PaymentMethodTitle
                            WHERE PaymentMethodID = @PaymentMethodID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PaymentMethodTitle", PaymentMethodTitle);
                        command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool DeletePaymentMethod(int PaymentMethodID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM PaymentMethodes WHERE PaymentMethodID = @PaymentMethodID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

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
