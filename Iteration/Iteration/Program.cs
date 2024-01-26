using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for(int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);

        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Judah", "Gabe", "Tabitha", "Jesse" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score:" + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Judah", "Gabe", "Tabitha", "Jesse" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}

        // List of class names
        List<string> className = new List<string>() { "Algebra", "English", "History", "Biology", "English" };
        Console.WriteLine("List of class names:");

        foreach (string name in className)
        {
            Console.WriteLine(name);
        }

        // Loop to evaluate each item in the list and check for duplicates
        foreach (string name in className)
        {
            if (HasDuplicate(className, name))
            {
                Console.WriteLine($"{name} - This class is a duplicate.");
            }
            else
            {
                Console.WriteLine($"{name} - This class is unique.");
            }
        }

        // Get user input after the first set of operations
        string searchInput = Console.ReadLine();

        bool isFound = false;

        // Loop to search the class name and display its indices to the user
        for (int i = 0; i < className.Count; i++)
        {
            if (className[i].Contains(searchInput))
            {
                Console.WriteLine($"Found '{searchInput}' at index: {i}");
                isFound = true;
            }
        }

        // Check if the user's input is not on the list
        if (!isFound)
        {
            Console.WriteLine($"'{searchInput}' is not found in the list.");
        }

        // Continue with the rest of your code...

        // String array containing the current attendants
        string[] attendance = { "JUDAH", "GABE", "TABITHA", "JESSE" };

        Console.WriteLine("Please enter your first name (type 'exit' to quit):");

        while (true) // Infinite loop
        {
            string userInput = Console.ReadLine().ToUpper(); // Get user input and convert to uppercase

            if (userInput == "EXIT")
            {
                // Exit the loop if the user enters "exit"
                break;
            }

            // Loop to update each array element by appending the user's input
            for (int i = 0; i < attendance.Length; i++)
            {
                attendance[i] += userInput;
            }

            // Output the updated array elements
            Console.WriteLine("Updated attendance:");
            foreach (string name in attendance)
            {
                Console.WriteLine(name);
            }
        }

        // Loop where the comparison is a "<=" operator
        int count = 1;
        while (count <= 5) // Loop will iterate 5 times
        {
            Console.WriteLine("Iteration: " + count);
            count++;
        }

        // Keep the console window open until the user presses Enter
        Console.ReadLine();
    }

    // Function to check if a string has duplicates in a list
    static bool HasDuplicate(List<string> list, string value)
    {
        int count = 0;
        foreach (string item in list)
        {
            if (item == value)
            {
                count++;
                if (count > 1)
                {
                    return true; // Found duplicate
                }
            }
        }
        return false; // Duplicate not found
   


        string searchInput = Console.ReadLine(); // Gets input from the user
        bool isFound = false;

            // Check if the user's input is not on the list
            if (!isFound)
            {
                Console.WriteLine($"'{searchInput}' is not found in the list.");
            }

            Console.ReadLine();


            // String array containing the current attendants
            string[] attendance = { "JUDAH", "GABE", "TABITHA", "JESSE" };

            Console.WriteLine("Please enter your first name (type 'exit' to quit):");

            while (true) // Infinite loop
            {

                string userInput = Console.ReadLine().ToUpper(); // Get user input and convert to uppercase

                if (userInput == "EXIT")
                {
                    // Exit the loop if the user enters "exit"
                    break;
                }

                // Loop to update each array element by appending the user's input
                for (int i = 0; i < attendance.Length; i++)
                {
                    attendance[i] += userInput;
                }

                // Output the updated array elements
                Console.WriteLine("Updated attendance:");
                foreach (string name in attendance)
                {
                    Console.WriteLine(name);
                }
            }

            // Loop where the comparison is a "<=" operator
            int Count = 1;
            while (count <= 5) // Loop will iterate 5 times
            {
                Console.WriteLine("Iteration: " + count);
                count++;
            }

            // Keep the console window open until the user presses Enter
            Console.ReadLine();

        }
    }

