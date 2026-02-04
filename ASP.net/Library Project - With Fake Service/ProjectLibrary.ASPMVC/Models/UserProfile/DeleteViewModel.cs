using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.ASPMVC.Models.UserProfile
{
    public class DeleteViewModel
    {
        [DisplayName("Nom :")]
        public string LastName { get; set; }

        [DisplayName("Prénom :")]
        public string FirstName { get; set; }
    }
}
