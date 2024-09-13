using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
            
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Nick\Documents\TechAcademy\C-Sharp-Projects\TwentyOne\TwentyOne", text);
            /************* Notes ***************
            A nameed parameter of calling a function might look like this
            deck = Shuffle(deck: deck, times: 3);

            Object initialization makes it easier to assign values
            Card card = new Card() { Face = "King", Suit = "Spades" };
            The above does the exact same thing as
            Card card = new Card();
            Card.Face = "King";
            Card.Suit = "Spades";

            operator overloading
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player() { Name = "Nick" };
            game += player;

            ******Lamda Expressions
            int count = deck.Cards.Count(x => x.Face == Face.Ace);
            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            */
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "yeh" || answer == "yea" || answer == "yup")
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
