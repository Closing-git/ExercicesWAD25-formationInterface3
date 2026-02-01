using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExerciceASP01.Models.Profile
{
    public class EditForm
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [DisplayName("Nom :")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Le nom doit comporter uniquement des lettres.")]
        [Required(ErrorMessage = "Le nom est obligatoire")]
        [MinLength(2, ErrorMessage = "La taille minimale du Nom est de 2 caractères.")]
        [MaxLength(32, ErrorMessage = "La taille maximale du Nom est de 32 caractères.")]
        public string Nom { get; set; }

        [DisplayName("Prénom :")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Le prénom doit comporter uniquement des lettres.")]
        [Required(ErrorMessage = "Le prénom est obligatoire")]
        [MinLength(2, ErrorMessage = "La taille minimale du prénom est de 2 caractères.")]
        [MaxLength(32, ErrorMessage = "La taille maximale du prénom est de 32 caractères.")]
        public string Prenom { get; set; }

        [DisplayName("Ville de résidence :")]
        [DataType(DataType.Text)]
        [MinLength(2, ErrorMessage = "La taille minimale de la ville est de 2 caractères.")]
        [MaxLength(32, ErrorMessage = "La taille maximale de la ville est de 32 caractères.")]
        public string? VilleDeResidence { get; set; }


        [DisplayName("Description:")]
        [DataType(DataType.MultilineText)]
        [MinLength(24, ErrorMessage = "La taille minimale de la description est de 24 caractères.")]
        [MaxLength(256, ErrorMessage = "La taille maximale de la description est de 256 caractères.")] public string? Description { get; set; }

        [DisplayName("Inscription newsletter:")]
        public bool InscriptionNewsLetter { get; set; }

    }
}
