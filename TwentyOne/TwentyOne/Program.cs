using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int unerlyingValue = (int)Suit.Diamonds;

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Judah";
            //game += player;
            //game -= player;

            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            int sum = numberList.Where(x => x > 20).Sum();
            Console.WriteLine(sum);
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            ////deck.Shuffle(3);

            ////foreach (Card card in deck.Cards)
            ////{
            ////    Console.WriteLine(card.Face + " of " + card.Suit);
            ////}

            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
