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
            Game game = new TwentyOneGame();
            /************* Notes ***************
            A nameed parameter of calling a function might look like this
            deck = Shuffle(deck: deck, times: 3);

            Object initialization makes it easier to assign values
            Card card = new Card() { Face = "King", Suit = "Spades" };
            The above does the exact same thing as
            Card card = new Card();
            Card.Face = "King";
            Card.Suit = "Spades";

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

        

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
