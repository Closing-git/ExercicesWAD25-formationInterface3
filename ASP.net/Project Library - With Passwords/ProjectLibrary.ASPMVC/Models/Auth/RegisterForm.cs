using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.ASPMVC.Models.Auth
{
    public class RegisterForm
    {
        [DisplayName("E-mail : ")]
        [EmailAddress(ErrorMessage ="Format invalide ")]
        [Required(ErrorMessage ="L'e-mail est obligatoire")]
        public string Email { get; set; }

        [DisplayName("Mot de passe : ")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{8,}$", 
            ErrorMessage = "Le mot de passe doit comporter au moins 8 caractères, une majuscule, une minuscule, un chiffre et un caractère spécial.")]
        public string Password { get; set; }
        
        [DisplayName("Confirmation du mot de passe : ")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "La confirmation du mot de passe est obligatoire.")]
        [Compare(nameof(Password), ErrorMessage = "Le mdp ne correspond pas")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Accepter les conditions d'utilisation ")]
        public bool AgreeTerms { get; set; }
    }
}
