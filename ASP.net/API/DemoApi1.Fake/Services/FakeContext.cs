using DemoApi1.Fake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApi1.Fake.Services
{
    public class FakeContext : IContext
    {
        private static List<Employee> _employees;

        public FakeContext()
        {
            _employees ??= new List<Employee>()
            {
                new Employee() {Id = 1, FirstName = "Johnson", LastName="Mike"},
                new Employee() {Id = 2, FirstName = "Fitzgerald", LastName="Karin"},
                new Employee() {Id = 3, FirstName = "Pier", LastName="Natacha"},
                new Employee() {Id = 4, FirstName = "Stevenson", LastName="Gary"},
                new Employee() {Id = 5, FirstName = "Gris", LastName="André"},
            };

        }
        public List<Employee> Employees
        {
            get => _employees;
            set => _employees = value;
        }
    }
}
