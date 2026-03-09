using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Fake.Entities
{
    public class Evenement
    {
        public DateOnly Date {  get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool DressCode { get; set; }
    }
}
