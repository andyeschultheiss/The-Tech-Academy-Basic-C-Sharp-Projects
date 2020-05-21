using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace Twenty_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            Console.WriteLine("Welcome to the Blackjack table. How many players today?");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Please enter your name:");
                string playerName = Console.ReadLine();
                Console.WriteLine("How much money would you like to put up?");
                int bank = Convert.ToInt32(Console.ReadLine());
                Player newPlayer = new Player(playerName, bank);
                newPlayer.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\andye\logs\cardlog.txt", true))
                {
                    file.WriteLine(newPlayer.Id);
                }
                game += newPlayer;
                newPlayer.IsActive = true;
            }

            while (game.Players.Count > 0 && game.Players.Sum(x => x.Balance) > 0)
            {
                game.Play();
            }

            
            Console.WriteLine("Thank you for playing. Come again soon!");
            Console.Read();

        }

       
    }
}
