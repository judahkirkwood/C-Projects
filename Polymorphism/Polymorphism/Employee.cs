using System;

namespace Polymorphism
{
    public class Employee : Person, IQuittable
    {
        // Add a parameterless constructor
        public Employee()
        {
        }

        // Add a constructor with parameters to set the first and last names
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Implement the abstract SayName method
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} has quit.");
        }
    }
}
