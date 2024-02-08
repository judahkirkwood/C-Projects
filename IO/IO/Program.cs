using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for a number
            Console.WriteLine("Please enter a number here: ");

            // Check input from user
            string input = Console.ReadLine();

            // Writing the input to the selected text file
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Judah Kirkwood\\OneDrive\\Desktop\\Logs.txt"))
            {
                writer.WriteLine(input);
            }

            Console.WriteLine("The number has been logged as: {input}");
            using (StreamReader reader = new StreamReader("C:\\Users\\Judah Kirkwood\\OneDrive\\Desktop\\Logs.txt"))
            {
                string content = reader.ReadToEnd();

                Console.WriteLine(content);
            }

            Console.ReadKey();
        }
    }
}
