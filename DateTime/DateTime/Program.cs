using System;

namespace TimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // The current date and time
            Console.WriteLine("The current date and time is: " + DateTime.Now);

            // Ask the user to input a number
            Console.WriteLine("Please enter a number of hours:");

            // Read the number input from the user
            string input = Console.ReadLine();

            // Parse the input into an integer
            if (int.TryParse(input, out int hours))
            {
                // Calculate the future time by adding the input hours to the current time
                DateTime futureTime = DateTime.Now.AddHours(hours);

                // Future time printed
                Console.WriteLine("In " + hours + " hours it will be: " + futureTime);
            }
            Console.ReadKey();
        }
    }
}
