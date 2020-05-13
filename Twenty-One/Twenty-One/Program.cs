using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Bilbo", "Frodo", "Gandalf" };
            game.Name = "BlackJack";
            game.ListPlayers();

            Deck deck = new Deck();
        
            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
           
            Console.ReadLine();
        }

       
    }
}
