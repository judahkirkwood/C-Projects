using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee with an Id of 1
            Employee employee = new Employee("Sample", "Student", 1);

            // Call the SayName method on the Employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
