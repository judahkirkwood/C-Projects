using System;

namespace AbstractClass
{
    public class Employee : Person
    {
        // Implement the abstract SayName method
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}

