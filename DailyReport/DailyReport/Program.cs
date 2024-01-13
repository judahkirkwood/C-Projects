using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            Console.ReadLine();
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();

            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

            // Ask for the page number
            Console.Write("What page number? ");
            // Read and parse the page number as an integer
            if (int.TryParse(Console.ReadLine(), out int pageNumber))
            {
                // Successfully parsed as an integer
                // Ask if the user needs help
                Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");

                // Read and parse the help status as a boolean
                if (bool.TryParse(Console.ReadLine(), out bool needsHelp))
                {
                    // Successfully parsed as a boolean
                    // Ask for positive experiences
                    Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
                    string positiveExperiences = Console.ReadLine();

                    // Ask for additional feedback
                    Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
                    string additionalFeedback = Console.ReadLine();

                    // Ask for the number of hours studied
                    Console.Write("How many hours did you study today? ");

                    // Read and parse the hours studied as a double
                    if (double.TryParse(Console.ReadLine(), out double hoursStudied))
                    {
                        // Successfully parsed as a double

                        // Display a closing message
                        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
                    }



                    // Display a personalized greeting
                    Console.WriteLine($"Have a great day, {userName}!");

                    Console.ReadLine();
                    }
                }
            }
        }
    }
