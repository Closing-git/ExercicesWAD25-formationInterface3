using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.ASPMVC.Models.UserProfile
{
    public class DetailsViewModel
    {
        [ScaffoldColumn(false)]
        public Guid UserProfileId { get; set; }

        [DisplayName("Nom :")]
        public string LastName { get; set; }

        [DisplayName("Prénom :")]
        public string FirstName { get; set; }

        [DisplayName("Age :")]
        public ushort YearsOld { get; set; }

        [DisplayName("Biographie :")]
        public string? Biography { get; set; }

        [DisplayName("Niveau de lecture :")]
        public ushort? ReadingSkill { get; set; }

        [DisplayName("Nombre de jours depuis affiliation :")]
        public uint RegisterDaysCounter { get; set; }

        [DisplayName("Inscription NewsLetter :")]
        public bool NewsLetterSubscribed { get; set; }
    }
}
