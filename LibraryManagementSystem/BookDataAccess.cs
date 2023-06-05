using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem
{
    public class BookDataAccess
    {
        private string connectionString = "Data Source=DESKTOP-95L5PDJ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = reader["Title"].ToString(),
                        Author = reader["Author"].ToString(),
                        PublicationDate = reader["PublicationDate"] as DateTime?,
                        IsAvailable = Convert.ToBoolean(reader["IsAvailable"])
                    };

                    books.Add(book);
                }
            }

            return books;
        }

        // Implement other CRUD methods (e.g., GetBookById, AddBook, UpdateBook, DeleteBook)
    }
}