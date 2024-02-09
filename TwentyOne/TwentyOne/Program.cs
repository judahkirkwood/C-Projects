using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime yearOfBirth = new DateTime(1985, 4, 11, 8, 32, 6);
            DateTime yearOfGraduation = new DateTime(2024, 4, 10, 16, 25, 6);

            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
            
            Console.WriteLine(ageAtGraduation);

            string text = "Here is some text for the text file.";
            File.WriteAllText(@"C:\\Users\\Judah Kirkwood\\OneDrive\\Desktop\\Logs.txt", text);

            Console.WriteLine("Welcome to the Kirkwood Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}
