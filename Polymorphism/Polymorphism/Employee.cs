using System;

namespace Polymorphism
{
    public class Employee : Person, IQuittable
    {
        // Add constructor
        public Employee()
        {
        }

        // Add a constructor with parameters to set first and last names
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Abstract SayName method
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} has quit.");
        }
    }
}
