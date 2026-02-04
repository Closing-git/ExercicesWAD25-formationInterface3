using Microsoft.Data.SqlClient;
using ProjectLibrary.Common.Repositories;
using ProjectLibrary.DAL.Entities;
using ProjectLibrary.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.DAL.Services
{
    public class UserProfileService : IUserProfileRepository<UserProfile>
    {
        //La connectionString est renseignée dans appsettings.json
        //Ajouter SQLConnection dans les services dans program.cs du MVC
        private readonly SqlConnection _connection;
        public UserProfileService(SqlConnection connection)
        {
            _connection = connection;
        }


        public IEnumerable<UserProfile> Get()
        {

            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_UserProfile_Get_All";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                _connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.ToUserProfile();
                    }

                    _connection.Close();
                }
            }

        }


        public UserProfile Get(Guid userProfileId)
        {

            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_UserProfile_Get_ById";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(userProfileId), userProfileId);
                UserProfile data;

                _connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    //Normalement on utiliserait un Execute + command.invoke () VOIR COURS ADO
                    {
                        data = reader.ToUserProfile();

                    }
                    else
                    {

                        throw new ArgumentOutOfRangeException(nameof(userProfileId));
                    }
                }

                //Normalement on utiliserait un Execute + command.invoke () VOIR COURS ADO
                _connection.Close();
                return data;
            }

        }


        public Guid Create(UserProfile entity)
        {

            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_UserProfile_Insert";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue(nameof(UserProfile.LastName), entity.LastName);
                command.Parameters.AddWithValue(nameof(UserProfile.FirstName), entity.FirstName);
                command.Parameters.AddWithValue(nameof(UserProfile.BirthDate), entity.BirthDate);
                command.Parameters.AddWithValue(nameof(UserProfile.Biography), (object?)entity.Biography ?? DBNull.Value);
                command.Parameters.AddWithValue(nameof(UserProfile.ReadingSkill), (object?)entity.ReadingSkill ?? DBNull.Value);
                command.Parameters.AddWithValue(nameof(UserProfile.NewsLetterSubscribed), entity.NewsLetterSubscribed);

                _connection.Open();
                return (Guid)command.ExecuteScalar();
                ;
                _connection.Close();
            }
                ;

        }


        public void Update(Guid userProfileId, UserProfile newData)
        {

            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_UserProfile_Update";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //Bien penser que l'ID reste celui de l'entity d'avant (mis en parametre de la fonction Update)
                command.Parameters.AddWithValue(nameof(UserProfile.UserProfileId), userProfileId);
                command.Parameters.AddWithValue(nameof(UserProfile.Biography), (object?)newData.Biography ?? DBNull.Value);
                command.Parameters.AddWithValue(nameof(UserProfile.ReadingSkill), (object?)newData.ReadingSkill ?? DBNull.Value);
                command.Parameters.AddWithValue(nameof(UserProfile.NewsLetterSubscribed), newData.NewsLetterSubscribed);

                _connection.Open();
                command.ExecuteNonQuery();
                ;
                _connection.Close();
            }
                ;


        }


        public void Delete(Guid userProfileId)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_UserProfile_Delete";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(userProfileId), userProfileId);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
               ;

        }
    }
}
