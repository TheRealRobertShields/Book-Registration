using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class BookRegistrationDB
    {
        public static void RegisterBook(Registration bookReg)
        {
            // Establish connection to DB
            SqlConnection connection = DBHelper.GetConnection();
            // Setup query
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO Registration (CustomerID, ISBN, RegDate) VALUES (@CustomerID, @ISBN, GETDATE())";

            command.Parameters.AddWithValue("@CustomerID", bookReg.CustomerID);
            command.Parameters.AddWithValue("@ISBN", bookReg.BookISBN);

            try
            {
                // Open connection
                connection.Open();
                // Send query to DB
                command.ExecuteNonQuery();
            }
            finally
            {
                // Close DB connection
                connection.Dispose();
            }
        }
    }
}
