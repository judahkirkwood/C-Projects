using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Method1 class
            Method1 method1 = new Method1();
            SquaredAndCubed.SquareCube(5, out int squareResult, out int cubeResult);

            // Ask user to input a number
            Console.Write("Please input a whole number: ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                // Divides user input by 2
                method1.Half(ref userInput);

                // Call method for user input number
                Console.WriteLine($"This number divided by two is: {userInput}");
            }
            else
            {
                // If invalid input is entered, error message is given
                Console.WriteLine("Invalid input. Please enter a valid whole number in integer form:");
            }
            Console.ReadLine();
        }
    }
}
