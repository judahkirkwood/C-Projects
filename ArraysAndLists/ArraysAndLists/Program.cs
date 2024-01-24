using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //  Array of strings
        string[] stringArray = { "This", "is", "my", "string", "array." };

        //  Array of integers
        int[] numArray = { 20, 45, 10, 35, 58, 65, 72 };

        // List of strings
        List<string> stringList = new List<string> { "This", "is", "my", "list", "of", "stings." };

        // Ask the user to select an index of the Array of strings
        Console.Write("Enter an index for the Array of strings: ");
        int stringIndex = GetValidIndex(stringArray.Length);

        // Display the string at the specified index
        Console.WriteLine($"String at index {stringIndex}: {stringArray[stringIndex]}");

        // Ask the user to select an index of the Array of integers
        Console.Write("Enter an index for the Array of integers: ");
        int numIndex = GetValidIndex(numArray.Length);

        // Display the integer at the specified index
        Console.WriteLine($"Integer at index {numIndex}: {numArray[numIndex]}");

        // Ask the user to select an index of the List of strings
        Console.Write("Enter an index for the List of strings: ");
        int listIndex = GetValidIndex(stringList.Count);

        // Display the content at the specified index in the List
        Console.WriteLine($"Content at index {listIndex}: {stringList[listIndex]}");

        Console.ReadLine(); // Keep the console window open until the user presses Enter
    }

    // Function to get valid index input from the user
    static int GetValidIndex(int arrayLength)
    {
        int index;
        Console.WriteLine($"Enter an index from 0 to {arrayLength - 1}: ");

        // Validate input
        while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= arrayLength)
        {
            Console.WriteLine($"Invalid index. Please enter a valid index from 0 to {arrayLength - 1}: ");
        }
        return index;


        //List<int> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("World");
        //intList.Remove("World");


        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //byte[] byteArray = new byte[5000];

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();


    }
}

