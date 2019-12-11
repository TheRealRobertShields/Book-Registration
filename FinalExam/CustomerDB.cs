using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class CustomerDB
    {
        public static List<Customer> GetAllCustomers()
        {
            // Establish connection to DB
            SqlConnection connection = DBHelper.GetConnection();
            // Setup query
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = connection;
            SelectCommand.CommandText = "SELECT CustomerID, FirstName, LastName, DateOfBirth FROM Customer";
            // Open connection
            connection.Open();
            // Send query to DB
            SqlDataReader reader = SelectCommand.ExecuteReader();
            // Do something with results
            var customers = new List<Customer>();
            while (reader.Read())
            {
                Customer currentCust = new Customer();
                currentCust.CustomerID = (int)reader["CustomerID"];
                currentCust.FirstName = (string)reader["FirstName"];
                currentCust.LastName = (string)reader["LastName"];
                currentCust.DateOfBirth = (DateTime)reader["DateOfBirth"];
                customers.Add(currentCust);
            }
            // Close DB connection
            connection.Close();
            return customers;
        }

        public static bool AddCustomer(Customer cust, string custTitle)
        {
            // Establish connection to DB
            SqlConnection connection = DBHelper.GetConnection();
            // Setup query
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO Customer (FirstName,LastName,DateOfBirth,Title) VALUES (@FirstName, @LastName, @DateOfBirth, @Title)";

            command.Parameters.AddWithValue("@FirstName", cust.FirstName);
            command.Parameters.AddWithValue("@LastName", cust.LastName);
            command.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth);
            command.Parameters.AddWithValue("@Title", custTitle);

            // Open connection
            connection.Open();

            // Send query to DB
            int RowsAffected = command.ExecuteNonQuery();

            // Close DB connection
            connection.Close();
            if (RowsAffected == 1)
            {
                return true;
            }
            return false;
        }
    }
}
