using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {// Print program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get details for Person 1 from user input
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate? ");
            double hourlyRatePerson1 = GetValidInput();
            Console.Write("Hours worked per week? ");
            double hoursWorkedPerson1 = GetValidInput();

            // Calculate annual salary for Person 1
            double annualSalaryPerson1 = CalculateAnnualSalary(hourlyRatePerson1, hoursWorkedPerson1);

            // Get details for Person 2 from user input
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate? ");
            double hourlyRatePerson2 = GetValidInput();
            Console.Write("Hours worked per week? ");
            double hoursWorkedPerson2 = GetValidInput();

            // Calculate annual salary for Person 2
            double annualSalaryPerson2 = CalculateAnnualSalary(hourlyRatePerson2, hoursWorkedPerson2);

            // Print annual salaries
            Console.WriteLine($"Annual salary of Person 1: {annualSalaryPerson1}");
            Console.WriteLine($"Annual salary of Person 2: {annualSalaryPerson2}");

            // Compare salaries and print the result
            bool person1EarnsMore = annualSalaryPerson1 > annualSalaryPerson2;
            Console.WriteLine($"Does Person 1 make more money than Person 2? {person1EarnsMore}");

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }

        // Function to get valid numeric input from the user
        static double GetValidInput()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return result;
        }

        // Function to calculate annual salary based on hourly rate and hours worked per week
        static double CalculateAnnualSalary(double hourlyRate, double hoursWorkedPerWeek)
        {
            // Assuming 52 weeks in a year
            return hourlyRate * hoursWorkedPerWeek * 52;
        }
    }
}
