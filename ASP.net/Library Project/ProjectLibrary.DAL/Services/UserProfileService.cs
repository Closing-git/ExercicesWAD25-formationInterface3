using Microsoft.Data.SqlClient;
using ProjectLibrary.DAL.Entities;
using ProjectLibrary.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.DAL.Services
{
    public class UserProfileService
    {
        private readonly string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = ProjectLibrary; Integrated Security = True";


        public IEnumerable<UserProfile> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_UserProfile_Get_All";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToUserProfile();
                        }

                        connection.Close();
                    }
                }
            }
        }


        public UserProfile Get(Guid userProfileId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_UserProfile_Get_ById";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(userProfileId), userProfileId);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToUserProfile();
                        }

                        throw new ArgumentOutOfRangeException(nameof(userProfileId));
                    }
                    connection.Close();
                }
            }
        }


        public Guid Create(UserProfile entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_UserProfile_Insert";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(nameof(UserProfile.LastName), entity.LastName);
                    command.Parameters.AddWithValue(nameof(UserProfile.FirstName), entity.FirstName);
                    command.Parameters.AddWithValue(nameof(UserProfile.BirthDate), entity.BirthDate);
                    command.Parameters.AddWithValue(nameof(UserProfile.Biography), (object?)entity.Biography ?? DBNull.Value);
                    command.Parameters.AddWithValue(nameof(UserProfile.ReadingSkill), (object?)entity.ReadingSkill ?? DBNull.Value);
                    command.Parameters.AddWithValue(nameof(UserProfile.NewsLetterSubscribed), entity.NewsLetterSubscribed);

                    connection.Open();
                    return (Guid)command.ExecuteScalar();
                    ;
                    connection.Close();
                }
                ;
            }
            ;
        }


        public void Update(Guid userProfileId, UserProfile newData)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_UserProfile_Update";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Bien penser que l'ID reste celui de l'entity d'avant (mis en parametre de la fonction Update)
                    command.Parameters.AddWithValue(nameof(UserProfile.UserProfileId), userProfileId);
                    command.Parameters.AddWithValue(nameof(UserProfile.Biography), (object?)newData.Biography ?? DBNull.Value);
                    command.Parameters.AddWithValue(nameof(UserProfile.ReadingSkill), (object?)newData.ReadingSkill ?? DBNull.Value);
                    command.Parameters.AddWithValue(nameof(UserProfile.NewsLetterSubscribed), newData.NewsLetterSubscribed);

                    connection.Open();
                    command.ExecuteNonQuery();
                    ;
                    connection.Close();
                }
                ;
            }
    ;
        }


        public void Delete(Guid userProfileId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_UserProfile_Delete";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(userProfileId), userProfileId);

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
