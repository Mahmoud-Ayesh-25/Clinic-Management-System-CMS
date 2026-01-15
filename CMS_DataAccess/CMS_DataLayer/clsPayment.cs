using System;
using System.Data;
using System.Data.SqlClient;

namespace CMS_DataLayer
{
    public class clsPayment
    {
        public static DataTable GetAllPayments()
        {
            DataTable dtPayments = new DataTable();

            string query = @"SELECT PaymentID, VisitID, PaidAmount, PaymentMethodTitle, Date, 
                            (CASE WHEN Status = 1 THEN 'Completed' WHEN Status = 2 THEN 'Cancelled' END) AS Status
                            FROM Payments INNER JOIN PaymentMethodes ON Payments.PaymentMethod = PaymentMethodes.PaymentMethodID
                            ORDER BY Date DESC;";

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
                                dtPayments.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtPayments;
        }

        public static DataTable GetAllPaymentsByVisitID(int VisitID)
        {
            DataTable dtPayments = new DataTable();

            string query = @"SELECT PaymentID, VisitID, PaidAmount, PaymentMethodTitle, Date, 
                            (CASE WHEN Status = 1 THEN 'Completed' WHEN Status = 2 THEN 'Cancelled' END) AS Status
                            FROM Payments INNER JOIN PaymentMethodes ON Payments.PaymentMethod = PaymentMethodes.PaymentMethodID
                            WHERE VisitID = @VisitID
                            ORDER BY Date DESC;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@VisitID", VisitID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtPayments.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return dtPayments;
        }

        public static bool GetPaymentByID(int PaymentID, ref int VisitID, ref float PaidAmount, ref int PaymentMethod,
            ref DateTime Date, ref int Status)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Payments WHERE PaymentID = @PaymentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                VisitID = int.Parse(reader[1].ToString());
                                PaidAmount = float.Parse(reader[2].ToString());
                                PaymentMethod = int.Parse(reader[3].ToString());
                                Date = DateTime.Parse(reader[4].ToString());
                                Status = int.Parse(reader[5].ToString());
                            }
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsFound;
        }

        public static int AddNewPayment(int VisitID, float PaidAmount, int PaymentMethod, DateTime Date, int Status)
        {
            int PaymentID = -1;

            string query = @"INSERT INTO Payments
                            VALUES
                            (
	                            @VisitID, @PaidAmount, @PaymentMethod, @Date, @Status
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@VisitID", VisitID);
                        command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Status", Status);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            PaymentID = id;
                        }
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return PaymentID;
        }

        public static bool UpdatePayment(int PaymentID, int VisitID, float PaidAmount, int PaymentMethod, DateTime Date, int Status)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Payments
                            SET
	                            VisitID = @VisitID,
	                            PaidAmount = @PaidAmount, 
	                            PaymentMethod = @PaymentMethod,
	                            Date = @Date,
	                            Status = @Status
                            WHERE PaymentID = @PaymentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        command.Parameters.AddWithValue("@VisitID", VisitID);
                        command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Status", Status);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch (Exception ex) { clsDataAccessSettings.CreateEventLog(ex.Message); }
                }
            }

            return IsUpdated;
        }

        public static bool DeletePayment(int PaymentID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Payments WHERE PaymentID = @PaymentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);

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
