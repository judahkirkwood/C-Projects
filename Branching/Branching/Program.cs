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

        // Further instructions or processing can be added here based on the requirements
        // For now, let's just print the entered weight
        Console.WriteLine($"You entered the package weight: {packageWeight}");

        // Prompt the user for the package length
        Console.Write("Please enter the package length: ");
        double packageLength = GetValidInput();

        // Further instructions or processing can be added here based on the requirements
        // For now, let's just print the entered weight
        Console.WriteLine($"You entered the package length: {packageLength}");

        // Prompt the user for the package height
        Console.Write("Please enter the package height: ");
        double packageHeight = GetValidInput();

        // Further instructions or processing can be added here based on the requirements
        // For now, let's just print the entered weight
        Console.WriteLine($"You entered the package height: {packageHeight}");

        // Prompt the user for the package weight
        Console.Write("Please enter the package width: ");
        double packageWidth = GetValidInput();

        // Further instructions or processing can be added here based on the requirements
        // For now, let's just print the entered weight
        Console.WriteLine($"You entered the package width: {packageWidth}");

        double packageSize = (packageWeight + packageHeight + packageLength + packageWidth);
        double shippingQuote = (packageHeight * packageLength * packageWidth * packageWeight / 100);

        if (packageSize > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
        }
        else
        {
            Console.WriteLine("Your shipping cost is: $" + shippingQuote + " Thanks for choosing Package Express!");
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
