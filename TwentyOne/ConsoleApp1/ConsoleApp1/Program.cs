using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {



            ////DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 64, 22);
            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;


            //string text = "Here is some text";
            //File.WriteAllText("C:\\Users\\Miste\\OneDrive\\Desktop\\log.txt", text);

            //string text = File.ReadAllText("C:\\Users\\Miste\\OneDrive\\Desktop\\log.txt", text);


            //const string casinoName = "Grand hotel casino";

            Guid identifier = Guid.NewGuid();



            Console.WriteLine("Welcome to the Grand Hotel and Casino.  Lets start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}.  WOuld you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Miste\OneDrive\Documents\GitHub\C#\C#Projects\TwentyOne\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
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
            Console.WriteLine("Feel free to looka round the Casino, Bye for now!");
            Console.ReadLine();


            

            //Deck deck = new Deck();
             //// lamda example - int count = deck.Cards.Count(x => x.Face == Face.Ace);
             //deck.Shuffle(3);
            //foreach (Card card in deck.Cards)
            //{
            //   Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
        

    }
}
