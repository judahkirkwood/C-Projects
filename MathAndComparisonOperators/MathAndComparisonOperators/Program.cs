using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine("Ten times Five = " + product.ToString());
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine("One Hundred divided by Five = " + quotient.ToString());
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine("Ten divided by Two has a remainder of " + remainder.ToString());
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 72;

            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

        }
    }
}
