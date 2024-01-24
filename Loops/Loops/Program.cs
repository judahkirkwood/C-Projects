using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Guardian class is best?");
            string guardian = Convert.ToString(Console.ReadLine());
            bool isGuessed = guardian == "Hunter";
            int countNumber = 1;

            // Remove the semicolon after the while statement
            while (countNumber <= 5)
            {
                Console.WriteLine("Count: " + countNumber);
                countNumber++;
            }
            Console.ReadLine();

            do
            {
                switch (guardian)
                {
                    case "Titan":
                        Console.WriteLine("You are literally the worst. May the Traveler have mercy on your poor soul. Stop eating crayons and try again.");
                        Console.WriteLine("Which class is best?");
                        guardian = Convert.ToString(Console.ReadLine());
                        break;
                    case "Warlock":
                        Console.WriteLine("You guessed Warlock... they are great, but drop that rift and try again.");
                        Console.WriteLine("Which class is best?");
                        guardian = Convert.ToString(Console.ReadLine());
                        break;
                    case "Hunter":
                        Console.WriteLine("You guessed Hunter. That is correct! Hunters are THE BEST! You are the Traveler's Chosen!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess again?");
                        guardian = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.Read();
        }
    }
}


