using System;
using System.Collections.Generic;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee with int type
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int> { 2, 4, 5, 6, 8, 9, 12 };

            Console.WriteLine("List of Numbered Employees: ");
            PrintThings(employeeInt.Things);

            // Instantiate Employee with string type
            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string> { "Judah", "John", "Mary", "Luke" };

            Console.WriteLine("List of Named Employees: ");
            PrintThings(employeeString.Things);
        }

        // Method to print the elements of the Things list
        static void PrintThings<T>(List<T> things)
        {
            foreach (var item in things)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}