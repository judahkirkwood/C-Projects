using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    public class MathOperation
    {
        // Void method that takes two integers, adds 5 to the first integer, and displays the second integer
        public void Operation1(int number1, int number2)
        {
            // Add 5 to the first number
            int result = number1 + 5;

            // Displaying the second integer to the screen
            Console.WriteLine($"Result: {result}. Number: {number2}");
        }
    }
}
