using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathOperations
    {
        // Method to add to an integer
        public int PerformOperation(int number)
        {
            // Adding 10 to the integer
            return number + 5;
        }

        // Method to multiply a decimal
        public int PerformOperation(decimal number)
        {
            // Multiply the decimal by 2 and converting the result to an integer
            return (int)(number * 2);
        }

        // Method to subtract a string and converted to an integer
        public int PerformOperation(string input)
        {
            // Convert the string to an integer
            if (int.TryParse(input, out int parsedNumber))
            {
                // Subtracting 5 from the integer
                return parsedNumber - 5;
            }
            else
            {
                // Return -1 if conversion fails
                return -1;
            }
        }
    }
}
