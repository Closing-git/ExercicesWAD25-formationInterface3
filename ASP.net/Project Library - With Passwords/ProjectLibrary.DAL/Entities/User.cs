using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.DAL.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }

        //Le password qu'on récupère de l'utilisateur (donc au format string),
        //mais on va lui appliquer un traitement par la suite
        //ET ON NE MET JAMAIS LE SALT
        public string Password { get; set; }

        public DateTime RegisteredDate { get; set; }
        public DateTime? DisabledDate { get; set; }



    }
}
