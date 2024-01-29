using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of integers
        List<int> IntList = new List<int>() { 124, 246, 346, 468, 570 };

        // Ask user for a number to divide by
        Console.WriteLine("Input a number greater than one to divide the integers by: ");
        int divisor = 0; // Initialize with a default value

        try
        {
            // Validate user input
            while (!int.TryParse(Console.ReadLine(), out divisor) || divisor == 0)
            {
                Console.WriteLine("Invalid input. Please enter a number larger than zero:");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            divisor = 1; // Assign a default value in case of an exception
        }
        finally
        {
            Console.WriteLine("Exited the try/catch block.");
        }

        // Write a loop to divide each integer in the list and display the result
        Console.WriteLine("Results after dividing each element in the list:");

        foreach (int number in IntList)
        {
            double result = (double)number / divisor;
            Console.WriteLine($"{number} / {divisor} = {result}");
        }

        // Keep the console window open until the user presses Enter
        Console.ReadLine();
    }
}




