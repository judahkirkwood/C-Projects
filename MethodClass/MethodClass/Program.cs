using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperation mathOps = new MathOperation();

            // Call the method, and pass two numbers
            Console.WriteLine("Result 1");
            mathOps.Operation1(10, 20);

            // Call the method, specifying the parameters by name
            Console.WriteLine("\nResult 2 adding 5");
            mathOps.Operation1(number1: 7, number2: 15);

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
