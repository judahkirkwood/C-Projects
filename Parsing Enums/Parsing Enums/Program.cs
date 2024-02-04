using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    enum DayOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask user to input day of the week
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                // Convert the user input to enum
                DayOfTheWeek currentDay;

                // Parse user input/assign it to enum
                if (!Enum.TryParse(userInput, true, out currentDay))
                {
                    // If parse fails, exception
                    throw new ArgumentException("Please enter a day of the week. ");
                }

                // Print input day of the week
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (ArgumentException ex)
            {
                // Exception if fail
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
