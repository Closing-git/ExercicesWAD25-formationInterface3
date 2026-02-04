using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.BLL.Mappers
{
    internal static class Mapper
    {
        #region Book

        //Penser à mettre en static
        public static BLL.Entities.Book ToBLL(this DAL.Entities.Book entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));

            return new BLL.Entities.Book(
                //Ne pas oublier l'ID
                entity.BookId,
                entity.Title,
                entity.Author,
                entity.ISBN,
                entity.ReleaseDate,
                entity.RegisteredDate,
                entity.DisabledDate);
        }

        public static DAL.Entities.Book ToDAL(this BLL.Entities.Book entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));

            return new DAL.Entities.Book()
            {
                //Ne pas oublier l'ID
                BookId = entity.BookId,
                Title = entity.Title,
                Author = entity.Author,
                ISBN = entity.ISBN,
                ReleaseDate = entity.ReleaseDate,
                RegisteredDate = entity.RegisteredDate,
                //Je ne mets pas disabledDate,
                //parce qu'elle est privée ET non nécéssaire dans l'utilisation de la DAL
                //Mais on peut travailler avec la propriété IsActive
                //DisabledDate = (entity.IsActive) ? null : (DateTime?)DateTime.Now
            };
        }

        #endregion

        #region UserProfile

        //Penser à mettre en static
        public static BLL.Entities.UserProfile ToBLL(this DAL.Entities.UserProfile entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));

            return new BLL.Entities.UserProfile(
                //Ne pas oublier l'ID
                entity.UserProfileId,
                entity.LastName,
                entity.FirstName,
                entity.BirthDate,
                entity.Biography,
                entity.NewsLetterSubscribed,
                entity.RegisteredDate,
                entity.DisabledDate,
                entity.ReadingSkill);
        }

        public static DAL.Entities.UserProfile ToDAL(this BLL.Entities.UserProfile entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));

            return new DAL.Entities.UserProfile()
            {
                //Ne pas oublier l'ID
                UserProfileId = entity.UserProfileId,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                BirthDate = entity.BirthDate,
                Biography = entity.Biography,
                ReadingSkill = (byte?)entity.ReadingSkill,
                NewsLetterSubscribed = entity.NewsLetterSubscribed,
                RegisteredDate = entity.RegisteredDate,
                DisabledDate = entity.DisabledDate,


            };
        }

        #endregion
    }
}
