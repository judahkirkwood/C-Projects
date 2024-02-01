using System;

namespace AbstractClass
{
    public class Employee : Person
    {
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
    }
}

