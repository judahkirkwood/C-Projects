using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Judah"; // Created a constant string
            var myNumber = 21; // Creating a variable using 'var'

            Console.WriteLine("Hello, my name is {0} and my favorite number is {1}.", myName, myNumber); // Print and concatenate myName and myNumber

            DefaultName name = new DefaultName(); // Constructor 1 instance
            Console.WriteLine(name.Name); // Output: DefaultName

            DefaultName name2 = new DefaultName("Kirkwood"); // Creating another instance using a different constructor
            Console.WriteLine(name2.Name); 

            Console.ReadLine();
        }
    }
}


