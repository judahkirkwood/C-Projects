using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Gibson";

            if (name == "Fender")
            {
                Console.WriteLine("This is a Fender guitar.");
            }
            else if (name == "Gibson")
            {
                Console.WriteLine("This is a Gibson guitar.");
            }
            else if (name != "Gibson" && name != "Fender")
            {
                Console.WriteLine("This guitar is not in our database. Please try again.");
            }
            Console.ReadLine();
        }
    }
}
