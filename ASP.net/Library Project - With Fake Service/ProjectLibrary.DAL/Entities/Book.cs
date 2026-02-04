using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.DAL.Entities
{
    public class Book
    {
        //Objet POCO (pas de méthod, uniquement attributs)
        //DTO
        public Guid BookId { get; set; }

        public string Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime RegisteredDate { get; set; }
        public DateTime? DisabledDate { get; set; }


    }
}
