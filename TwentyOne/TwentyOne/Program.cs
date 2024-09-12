using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            */
            Deck deck = new Deck();
            deck.Shuffle();
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
