using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main()
        {
            // Ask the user to input a number
            Console.WriteLine("Please enter a number: ");
            // Reads input as a string
            string userInput = Console.ReadLine();

            // Converts string to an integer
            if (int.TryParse(userInput, out int userNumber)) 
            {
                // Instance of MathOperations created
                MathOperations mathOps = new MathOperations();

                // Call the Add method
                Console.WriteLine($"Result of adding: {mathOps.Add(userNumber)}");

                // Call the Subtract method
                Console.WriteLine($"Result of subtracing: {mathOps.Subtract(userNumber)}");

                // Call the Multiply method 
                Console.WriteLine($"Result of multiplying: {mathOps.Multiply(userNumber)}");
            }
            else 
            {
                // Error displayed if not a proper input
                Console.WriteLine("Invalid number. Please enter a valid number in integer form: ");
            }
            Console.ReadLine();
        }
    }
}
