using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class MathOperations
    {
        // Adds ten to the number
        public int Add(int number)
        {
            return number + 10;
        }
        // Subtracts ten from the number
        public int Subtract(int number)
        {
            return number - 10;
        }
        // Multiplies the number by ten
        public int Multiply(int number) 
        {
            return number * 10;
        }
    }
}
