using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.ASPMVC.Models.Book
{
    public class DetailsViewModel
    {
        //Pour ne pas l'afficher de base dans la view quand on fait une view "scaffoldée"
        [ScaffoldColumn(false)]
        public Guid BookId { get; set; }

        [DisplayName("Titre :")]
        public string Title { get; set; }

        [DisplayName("Auteur :")]
        public string? Author { get; set; }

        [DisplayName("ISBN :")]
        public string? ISBN { get; set; }

        [DisplayName("Date de sortie :")]
        public DateTime ReleaseDate { get; set; }

    }
}
