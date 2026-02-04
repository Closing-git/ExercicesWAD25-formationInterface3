using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.ASPMVC.Models.UserProfile
{
    public class ListItemViewModel
    {
        [ScaffoldColumn(false)]
        public Guid UserProfileId { get; set; }

        [DisplayName("Nom :")]
        public string LastName { get; set; }


        [DisplayName("Prénom :")]
        public string FirstName { get; set; }
    }
}
