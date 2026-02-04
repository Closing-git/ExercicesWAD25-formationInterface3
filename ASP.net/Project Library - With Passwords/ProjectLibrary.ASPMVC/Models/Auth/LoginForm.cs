using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.ASPMVC.Models.Auth
{
    public class LoginForm
    {

        [DisplayName("E-mail : ")]
        [EmailAddress(ErrorMessage = "Format invalide ")]
        [Required(ErrorMessage = "L'e-mail est obligatoire")]
        public string Email { get; set; }

        [DisplayName("Mot de passe : ")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{8,}$",
            ErrorMessage = "Le mot de passe doit comporter au moins 8 caractères, une majuscule, une minuscule, un chiffre et un caractère spécial.")]
        public string Password { get; set; }

    }
}
