using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class CarInsuranceApprovalApplication
    {
        static void Main()
        {
            // Ask the applicant their age
            Console.Write("What is your age? ");
            int age = GetValidInput();

            // Ask if they have had a DUI
            Console.Write("Have you ever had a DUI? (true/false) ");
            bool hasDUI = GetBoolInput();

            // Ask how many speeding tickets they have had
            Console.Write("How many speeding tickets do you have? ");
            int speedingTickets = GetValidInput();

            // Check qualifications
            bool qualifications = (age > 15) && !hasDUI && (speedingTickets <= 3);

            // Print the result
            if (qualifications)
            {
                Console.WriteLine("Congratulations, you have qualified!");
            }
            else
            {
                Console.WriteLine("Sorry, you do not qualify for car insurance.");
            }
            Console.ReadLine();
        }

        // Function to get valid integer input from the user
        static int GetValidInput()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return result;
        }

        // Function to get valid boolean input from the user
        static bool GetBoolInput()
        {
            bool result;
            while (!bool.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            }
            return result;
        }
    }
}
