using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Fake.Entities
{
    public class Guest
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string ForName { get; set; }
        public bool IsComing { get; set; }
    }
}
