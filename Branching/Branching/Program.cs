using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight
        Console.Write("Please enter the package weight: ");
        double packageWeight = GetValidInput();

        // Check if the package weight is greater than 50
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Program terminated.");
        }
        else
        {
            // Prompt the user for the package length
            Console.Write("Please enter the package length: ");
            double packageLength = GetValidInput();

            // Prompt the user for the package height
            Console.Write("Please enter the package height: ");
            double packageHeight = GetValidInput();

            // Prompt the user for the package width
            Console.Write("Please enter the package width: ");
            double packageWidth = GetValidInput();

            // Total size of the package
            double packageSize = packageHeight + packageLength + packageWidth;

            // Check if the dimensions total is greater than 50
            if (packageSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Program terminated.");
            }
            else
            {
                // Total cost to ship the package to the customer
                double shippingQuote = (packageHeight * packageLength * packageWidth * packageWeight / 100);

                // Display the shipping cost to the customer
                Console.WriteLine($"Your shipping cost is: ${shippingQuote}. Thanks for choosing Package Express!");
            }
        }

        // Keep the console window open until the user presses Enter
        Console.ReadLine();
    }

    // Function to get valid numeric input from the user
    static double GetValidInput()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result) || result <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
            Console.Write("Please enter the package information: ");
        }
        return result;
    }
}

