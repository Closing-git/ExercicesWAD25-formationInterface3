using DemoApi1.Fake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApi1.Fake
{
    public interface IContext
    {
        public List<Employee> Employees { get; set; }
    }
}
