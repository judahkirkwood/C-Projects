using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee("Sample", "Student");

            // Call the SayName method on the Employee object
            employee.SayName();
            Console.WriteLine();

            // Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = employee;

            // Call the Quit method on the IQuittable object
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
