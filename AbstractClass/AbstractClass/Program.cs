using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee("Sample", "Student");

            
            

            // Call the SayName method on the Employee object
            employee.SayName();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
