using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectProduct.ASPMVC.Models.Product
{
    public class ListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [DisplayName("Nom :")]
        public string Name { get; set; }

    }
}
