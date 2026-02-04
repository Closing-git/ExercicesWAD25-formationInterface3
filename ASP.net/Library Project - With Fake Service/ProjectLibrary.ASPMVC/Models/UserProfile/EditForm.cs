using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.ASPMVC.Models.UserProfile
{
    public class EditForm
    {


        [DisplayName("Biographie :")]
        [MaxLength(512, ErrorMessage = "La biographie doit faire moins de 512 caractères.")]
        public string? Biography { get; set; }

        [DisplayName("Niveau de lecture :")]
        [Range(1,6)]
        public uint? ReadingSkill { get; set; }

        [DisplayName("Inscription à la newsletter :")]
        public bool NewsLetterSubscribed { get; set; }
    }
}
