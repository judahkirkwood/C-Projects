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
            // If the user entered only the first number it returns the same
            return number1 * number2;
        }
    }
}
