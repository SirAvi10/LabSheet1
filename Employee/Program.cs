using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.name = "Jane Doe";

            Employee employee2 = employee1;
            employee1.name = "James Doe";

            Employee employee3 = new Employee();
            employee1.name = "James Doe";
        }
    }
}
