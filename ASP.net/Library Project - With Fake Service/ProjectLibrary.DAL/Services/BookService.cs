using Microsoft.Data.SqlClient;
using ProjectLibrary.Common.Repositories;
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

    public class BookService : IBookRepository<Book>
    {
        //La connectionString est renseignée dans appsettings.json
        //Ajouter SQLConnection dans les services dans program.cs du MVC
        private readonly SqlConnection _connection;
        public BookService(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Book> Get()
        {

            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_Book_Get_All";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                _connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.ToBook();
                    }
                    ;
                }
                _connection.Close();

            }
        }
        public Book Get(Guid bookId)
        {

            using (SqlCommand command = _connection.CreateCommand())
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

                _connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.ToBook();
                    }
                    throw new ArgumentOutOfRangeException(nameof(bookId));
                }

                _connection.Close();


            }
        }

        public Guid Create(Book entity)
        {

            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_Book_Insert";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue(nameof(Book.Title), entity.Title);
                command.Parameters.AddWithValue(nameof(Book.ReleaseDate), entity.ReleaseDate);
                command.Parameters.AddWithValue(nameof(Book.ISBN), (object?)entity.ISBN ?? DBNull.Value);
                command.Parameters.AddWithValue(nameof(Book.Author), (object?)entity.Author ?? DBNull.Value);

                _connection.Open();
                return (Guid)command.ExecuteScalar();
                ;
                _connection.Close();
            }
                ;

        }
        public void Update(Guid bookId, Book newData)
        {

            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_Book_Update";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //Bien penser que l'ID reste celui de l'entity d'avant (mis en parametre de la fonction Update)
                command.Parameters.AddWithValue(nameof(Book.BookId), bookId);
                command.Parameters.AddWithValue(nameof(Book.Title), newData.Title);
                command.Parameters.AddWithValue(nameof(Book.ReleaseDate), newData.ReleaseDate);
                command.Parameters.AddWithValue(nameof(Book.ISBN), (object?)newData.ISBN ?? DBNull.Value);
                command.Parameters.AddWithValue(nameof(Book.Author), (object?)newData.Author ?? DBNull.Value);

                _connection.Open();
                command.ExecuteNonQuery();
                ;
                _connection.Close();
            }
                ;


        }


        public void Delete(Guid bookId)
        {
            //Ne va pas supprimer, parce que dans la table Book on a mis un TRIGGER qui au lieu de supprimer,
            //va changer la DisabledDate

            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_Book_Delete";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(bookId), bookId);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
               ;

        }

    }
}
