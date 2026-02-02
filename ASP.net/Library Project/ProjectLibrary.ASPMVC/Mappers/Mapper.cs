namespace ProjectLibrary.ASPMVC.Mappers
{
    // /!\STATIC
    public static class Mapper
    {

        #region Book
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

        #endregion
    }
}

