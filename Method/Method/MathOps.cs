using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class MathOps
    {
        public int Operation(int number1, int number2 = 1)
        {
            // Check if the user entered a second number
            if (number2 != 1)
            {
                //If so, the first number is multiplied by the second number that has been input
                return number1 * number2;
            }
            else
            {
                // If the user entered only the first number it returns the same
                return number1 * 1;
            }
        }
    }
}
