using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.ASPMVC.Models.UserProfile
{
    public class CreateForm
    {
        [DisplayName("Nom :")]
        [Required(ErrorMessage = "Le nom est obligatoire")]
        [MaxLength(32, ErrorMessage = "Le nom doit faire moins de 32 caractères.")]
        public string LastName { get; set; }

        [DisplayName("Prénom :")]
        [Required(ErrorMessage = "Le prénom est obligatoire")]
        [MaxLength(32, ErrorMessage = "Le prénom doit faire moins de 32 caractères.")]

        public string FirstName { get; set; }

        [DisplayName("Date de naissance :")]
        [Required(ErrorMessage = "La date de naissance est obligatoire")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DisplayName("Inscription à la newsletter :")]
        public bool NewsLetterSubscribed { get; set; }
    }
}
