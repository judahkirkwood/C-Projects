using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an instance of MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer parameter
            int result1 = mathOps.PerformOperation(15);
            Console.WriteLine($"Result of integer operation: {result1}");

            // Call the second method with a decimal parameter
            int result2 = mathOps.PerformOperation(7.5m);
            Console.WriteLine($"Decimal operation: {result2}");

            // Call the third method with a string parameter
            int result3 = mathOps.PerformOperation("15");
            Console.WriteLine($"String converted to integer: {result3}");

            Console.ReadLine();
        }
    }
}
