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
        // Part 4
        bool isFound = false;
        List<string> otherName = new List<string> { "Science", "Japanese", "Spanish", "Physica Education", "Art", "Choir" };
        Console.WriteLine("Please input the Class Name.");
        string searchInput1 = Console.ReadLine();
        for (int i = 0; i < otherName.Count; i++)
        {
            if (otherName[i] == searchInput1)
            {
                Console.WriteLine($"Found '{searchInput1}' at index: {i}");
                isFound = true;
                break;
            }
        }

        // Check if user's input is not on the list
        if (!isFound)
        {
            Console.WriteLine($"'{searchInput1}' is not found in the list.");
        }


        // List of class names (Part 5)
        List<string> className = new List<string>() { "Algebra", "English", "History", "Biology", "English" };
        Console.WriteLine("List of class names:");

        foreach (string name in className)
        {
            Console.WriteLine(name);
        }

        isFound = false;
        // Ask the user to input text to search the list for
        Console.WriteLine("Enter text to search in the list:");
        string searchInput2 = Console.ReadLine();

        // Loop that iterates through the list and displays the index of the list item that contains matching text
        for (int i = 0; i < className.Count; i++)
        {
            if (className[i] == searchInput2)
            {
                Console.WriteLine($"Found '{searchInput2}' at index: {i}");
                isFound = true;
            }
        }

        // Check if user's input is not on the list
        if (!isFound)
        {
            Console.WriteLine($"'{searchInput2}' is not found in the list.");
        }


        // Part 6
        List<string> className2 = new List<string>() { "Algebra", "English", "History", "Biology", "English" };
        List<string> dupList = new List<string>();
        Console.WriteLine("List of class names:");
        foreach (string name in className2)
        {
            if (dupList.Contains(name))
            {
                Console.WriteLine($"{name} is a duplicate.");
            }
            else
            {
                Console.WriteLine($"{name} is unique.");
                dupList.Add(name);
            }
        }


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

            // Check if user's input is a duplicate in the list
            if (Array.IndexOf(attendance, userInput) != -1)
            {
                Console.WriteLine($"{userInput} - This name is a duplicate.");
            }
            else
            {
                // Update attendance with user's input
                Array.Resize(ref attendance, attendance.Length + 1);
                attendance[attendance.Length - 1] = userInput;

                // Output updated 
                Console.WriteLine("Updated attendance:");
                foreach (string name in attendance)
                {
                    Console.WriteLine(name);
                }
            }
        }

        // Loop where the comparison using "<=" 
        int count = 1;
        while (count <= 5) // Loop will iterate 5 times
        {
            Console.WriteLine("Iteration: " + count);
            count++;
        }

        // Keep the console window open until the user presses Enter
        Console.ReadLine();
    }
}
