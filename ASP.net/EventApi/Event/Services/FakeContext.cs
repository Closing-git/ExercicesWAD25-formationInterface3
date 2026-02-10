using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event.Fake.Entities;

namespace Event.Fake.Services
{
    public class FakeContext : IContext
    {
        private static Evenement _evenement;
        private static List<Guest> _guests;

        public FakeContext()
        {
            _evenement = new Evenement()
            {
                Date = new DateOnly(2026, 11, 03),
                StartTime = new TimeOnly(14, 00),
                EndTime = new TimeOnly(20, 30),
                Title = "Goûter d'anniversaire",
                Description = null,
                DressCode = false,
            };
            _guests = new List<Guest>()
            {
                new Guest() { Id = 1, ForName = "Marc", LastName ="Dupont", IsComing = false},
                new Guest() { Id = 2, ForName = "Sophie", LastName ="Hünger", IsComing = true},
                new Guest() { Id = 3, ForName = "Maria", LastName ="Bellocci", IsComing = true},
                new Guest() { Id = 4, ForName = "Rachid", LastName ="ElAmhed", IsComing = false},
                new Guest() { Id = 5, ForName = "Luis", LastName ="Mariano", IsComing = true},
            };
                
        }

        public Evenement Evenement
        {
            get => _evenement;
            set => _evenement = value;
        }
        public List<Guest> Guests
        {
            get => _guests;
            set => _guests = value;
        }
    }
}
