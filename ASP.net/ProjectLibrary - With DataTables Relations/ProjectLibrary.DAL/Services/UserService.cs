using Microsoft.Data.SqlClient;
using ProjectLibrary.Common.Repositories;
using ProjectLibrary.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjectLibrary.DAL.Services
{
    public class UserService : IUserRepository<User>
    {
        private readonly SqlConnection _connection;

        public UserService(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool CheckAdmnistrator(Guid userID)
        {
            try
            {
                using (SqlCommand command = _connection.CreateCommand())
                {
                    command.CommandText = "SP_User_CheckAdministrator";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(userID), userID);
                    _connection.Open();

                    //Si tu récupère un Id et qu'il est le même que celui donné en paramètres
                    return (userID == (Guid)command.ExecuteScalar());

                }
            }

            catch (Exception)
            {
                //Sinon c'est qu'il y a une erreur, le userId n'est pas présent dans la table, donc on retourne false
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public Guid CheckPassword(string email, string password)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_User_CheckPassword";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(email), email);
                command.Parameters.AddWithValue(nameof(password), password);
                _connection.Open();
                return (Guid)command.ExecuteScalar();
                _connection.Close();
            }
        }

        public Guid Create(User entity)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_User_Insert";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(User.Email), entity.Email);
                command.Parameters.AddWithValue(nameof(User.Password), entity.Password);
                _connection.Open();
                return (Guid)command.ExecuteScalar();
                _connection.Close();
            }
        }

        public void RemoveAdministrator(Guid userID)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_User_RemoveAdministrator";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(userID), userID);
                _connection.Open();

                command.ExecuteNonQuery();


            }
        }

        public void SetAsAdministrator(Guid userID)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_User_SetAsAdministrator";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(userID), userID);
                _connection.Open();

                command.ExecuteNonQuery();


            }
        }
    }
}
