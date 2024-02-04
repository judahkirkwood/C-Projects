using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee class and add values to properties
            Employee employee1 = new Employee { ID = 1, FirstName = "Judah", LastName = "Kirkwood" };
            Employee employee2 = new Employee { ID = 2, FirstName = "Luke", LastName = "Skywalker" };

            // Compare the 2 Employees using overload operators
            bool Equal = employee1 == employee2;

            // Results
            Console.WriteLine($"Are the employees equal? { Equal}");

            Console.ReadLine();
        }
    }
}
