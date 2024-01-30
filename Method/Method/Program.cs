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
            // Creating the "MathOps" class instance
            MathOps mathOps = new MathOps();

            // Asking the user to input the first number
            Console.Write("Please enter the first number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.Write("Please enter the second number: (This number is optional):");
                int input2 = Convert.ToInt32(Console.ReadLine());

                //Call the method, passing in the one or two numbers entered
                int result = mathOps.Operation(input1, input2);

                // Display the result
                Console.WriteLine($"Result of the operation: {result}");
            }

            catch
            {
                int result = mathOps.Operation(input1);

                // Display the result
                Console.WriteLine($"Result of the operation: {result}");
            }

            //if (int.TryParse(Console.ReadLine(), out int input1))
            //{
            //    // Asking the user to input the second number
            //    Console.Write("Please enter the second number: (This number is optional):");
            //    string input2String = Console.ReadLine();

            //    // See if user entered a second number
            //    int input2 = string.IsNullOrEmpty(input2String) ? 1 : int.Parse(input2String);

            //    // Call the method, passing in the one or two numbers entered
            //    int result = mathOps.Operation(input1, input2);

            //    // Display the result
            //    Console.WriteLine($"Result of the operation: {result}");
            //}
            //else
            //{
            //    // Display an error message if the first input is not a valid integer
            //    Console.WriteLine("Invalid input. Please enter valid integers.");
            //}

            //// Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
