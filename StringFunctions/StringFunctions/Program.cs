using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Judah ";
            string greeting = "Hello, ";
            string sentence = "it is a good day to code.";
            string combineStrings = greeting + name + sentence;
            string sentence1 = "This is my first sentence.\n";
            string sentence2 = "This is my second sentence.\n";
            string sentence3 = "This is my third sentence.\n";


            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;
            //converts sting to UPPER CASE
            combineStrings = combineStrings.ToUpper();

            Console.WriteLine(combineStrings);
            

            StringBuilder sb = new StringBuilder();

            sb.Append (sentence1 + sentence2 + sentence3);

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
