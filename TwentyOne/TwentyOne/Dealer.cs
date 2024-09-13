using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            //string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            /*using (StreamWriter file = new StreamWriter(@"C:\Users\Nick\logs\logs.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }*/
            Deck.Cards.RemoveAt(0); 
        }

    }
}
