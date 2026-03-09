using Event.Fake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Fake
{
    public interface IContext
    {
        public Evenement Evenement { get; set; }
        public List<Guest> Guests { get; set; }
    }
}
