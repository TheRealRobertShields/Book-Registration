using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    /// <summary>
    /// DB Helper to manage Books.
    /// </summary>
    static class BookDB
    {
        public static List<Book> GetAllBooks()
        {
            // Establish connection to DB
            SqlConnection connection = DBHelper.GetConnection();
            // Setup query
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = connection;
            SelectCommand.CommandText = "SELECT ISBN, Title, Price FROM Book";
            // Open connection
            connection.Open();
            // Send query to DB
            SqlDataReader reader = SelectCommand.ExecuteReader();
            // Do something with results
            var books = new List<Book>();
            while (reader.Read())
            {
                Book currentBook = new Book();
                currentBook.BookISBN = (string)reader["ISBN"];
                currentBook.BookTitle = (string)reader["Title"];
                currentBook.BookPrice = (decimal)reader["Price"];
                books.Add(currentBook);
            }
            // Close DB connection
            connection.Close();
            return books;
        }

        public static bool AddBook(Book book)
        {
            // Establish connection to DB
            SqlConnection connection = DBHelper.GetConnection();
            // Setup query
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO Book (ISBN,Title,Price) VALUES (@ISBN, @Title, @Price)";

            command.Parameters.AddWithValue("@ISBN", book.BookISBN);
            command.Parameters.AddWithValue("@Title", book.BookTitle);
            command.Parameters.AddWithValue("@Price", book.BookPrice);

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
