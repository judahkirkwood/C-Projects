using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number here: ");
            //Reads user input as a string
            string userInput = Console.ReadLine();
            //Parses the input to a long for the possibility of larger numbers
            if (int.TryParse(userInput, out int inputNumber))
            {
                //Multiply input number by 50
                int remainder = inputNumber % 7;
                //Print the results to the console
                Console.WriteLine($"Remainder: {remainder}");
                Console.ReadLine();
            }
        }
    }
}
