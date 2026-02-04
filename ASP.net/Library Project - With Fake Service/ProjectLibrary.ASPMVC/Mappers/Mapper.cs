namespace ProjectLibrary.ASPMVC.Mappers
{
    // /!\STATIC
    public static class Mapper
    {

        //Mapper d'un book BLL vers un Book qu'on pourra utiliser dans le MVC, ici sous forme de ListItem

        // /!\ PENSER A AJOUTER DANS PROGRAM.CS (de MVC) l'ajout de Service /!\
        public static Models.Book.ListItemViewModel ToListItem(this BLL.Entities.Book entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new Models.Book.ListItemViewModel()
            {
                BookId = entity.BookId,
                Title = entity.Title,
                Author = entity.Author,
                ISBN = entity.ISBN,
            };

        }

        public static Models.UserProfile.ListItemViewModel ToListItem(this BLL.Entities.UserProfile entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new Models.UserProfile.ListItemViewModel()
            {
                UserProfileId = entity.UserProfileId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
            };

        }

        public static Models.Book.DetailsViewModel ToDetails(this BLL.Entities.Book entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new Models.Book.DetailsViewModel()
            {
                BookId = entity.BookId,
                Title = entity.Title,
                Author = entity.Author,
                ISBN = entity.ISBN,
                ReleaseDate = entity.ReleaseDate,

            };

        }

        public static Models.UserProfile.DetailsViewModel ToDetails(this BLL.Entities.UserProfile entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new Models.UserProfile.DetailsViewModel()
            {
                UserProfileId = entity.UserProfileId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                YearsOld = entity.YearsOld,
                Biography = entity.Biography,
                ReadingSkill = entity.ReadingSkill,
                RegisterDaysCounter = entity.RegisterDaysCounter,
                NewsLetterSubscribed = entity.NewsLetterSubscribed,

            };

        }

        public static BLL.Entities.Book ToBLL(this Models.Book.CreateForm entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new BLL.Entities.Book(
                entity.Title, entity.Author, entity.ISBN, entity.ReleaseDate
                );
        }
        public static BLL.Entities.UserProfile ToBLL(this Models.UserProfile.CreateForm entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new BLL.Entities.UserProfile(
                entity.LastName, entity.FirstName, entity.BirthDate, entity.NewsLetterSubscribed
                );
        }

        public static Models.Book.EditForm ToEdit(this BLL.Entities.Book entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new Models.Book.EditForm
            {
                Title = entity.Title,
                Author = entity.Author,
                ISBN = entity.ISBN,
                ReleaseDate = entity.ReleaseDate,
            };
        }
        public static Models.UserProfile.EditForm ToEdit(this BLL.Entities.UserProfile entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new Models.UserProfile.EditForm
            {
            Biography = entity.Biography,
            NewsLetterSubscribed = entity.NewsLetterSubscribed,
            ReadingSkill = entity.ReadingSkill,
            };
        }
        
        public static BLL.Entities.Book ToBLL(this Models.Book.EditForm entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new BLL.Entities.Book(
                entity.Title, entity.Author, entity.ISBN, entity.ReleaseDate
                );
        }
        public static BLL.Entities.UserProfile ToBLL(this Models.UserProfile.EditForm entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new BLL.Entities.UserProfile
                (new Guid(),
                "aa",
                "bb",
                new DateTime(), 
                entity.Biography, 
                entity.NewsLetterSubscribed, 
                new DateTime(), 
                null, 
                (byte?)entity.ReadingSkill
                );
        }





        public static Models.Book.DeleteViewModel ToDelete(this BLL.Entities.Book entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new Models.Book.DeleteViewModel
            {
                Title = entity.Title,
                ReleaseDate = entity.ReleaseDate,
            };
        }

        public static Models.UserProfile.DeleteViewModel ToDelete(this BLL.Entities.UserProfile entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new Models.UserProfile.DeleteViewModel
            {
                LastName = entity.LastName,
                FirstName = entity.FirstName,
            };
        }
    }
}

