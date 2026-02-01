using Microsoft.Data.SqlClient;
using ProjectLibrary.DAL.Entities;
using ProjectLibrary.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectLibrary.DAL.Services
{
    public class BookService
    {
        private readonly string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = ProjectLibrary; Integrated Security = True";
        public IEnumerable<Book> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Book_Get_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToBook();
                        }
                        ;
                    }
                    connection.Close();
                }
            }
        }
        public Book Get(Guid bookId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Book_Get_ById";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(bookId), bookId);

                    //OU FAIRE AINSI
                    //SqlParameter param_id = new SqlParameter()
                    //{
                    //    ParameterName = "bookId",
                    //    Value = bookId
                    //};
                    //command.Parameters.Add(param_id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToBook();
                        }
                        throw new ArgumentOutOfRangeException(nameof(bookId));
                    }

                    connection.Close();

                }
            }
        }

        public Guid Create(Book entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Book_Insert";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(nameof(Book.Title), entity.Title);
                    command.Parameters.AddWithValue(nameof(Book.ReleaseDate), entity.ReleaseDate);
                    command.Parameters.AddWithValue(nameof(Book.ISBN), (object?)entity.ISBN ?? DBNull.Value);
                    command.Parameters.AddWithValue(nameof(Book.Author), (object?)entity.Author ?? DBNull.Value);

                    connection.Open();
                    return (Guid)command.ExecuteScalar();
                    ;
                    connection.Close();
                }
                ;
            }
            ;
        }
        public void Update(Guid bookId, Book newData)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Book_Update";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Bien penser que l'ID reste celui de l'entity d'avant (mis en parametre de la fonction Update)
                    command.Parameters.AddWithValue(nameof(Book.BookId), bookId);
                    command.Parameters.AddWithValue(nameof(Book.Title), newData.Title);
                    command.Parameters.AddWithValue(nameof(Book.ReleaseDate), newData.ReleaseDate);
                    command.Parameters.AddWithValue(nameof(Book.ISBN), (object?)newData.ISBN ?? DBNull.Value);
                    command.Parameters.AddWithValue(nameof(Book.Author), (object?)newData.Author ?? DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    ;
                    connection.Close();
                }
                ;
            }
            ;
        }


        public void Delete(Guid bookId)
        {
            //Ne va pas supprimer, parce que dans la table Book on a mis un TRIGGER qui au lieu de supprimer,
            //va changer la DisabledDate
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Book_Delete";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(bookId), bookId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
               ;
            }
            ;
        }

    }
}
