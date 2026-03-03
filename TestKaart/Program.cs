using balatrogame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> deck = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))  //dit wordt 4 keer uitgvoerd
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue))) //per keer wordt dit 13 keer uitgevoerd
                {
                    Card card = new Card(value, suit);
                    card.Suit = suit;
                    card.Value = value;
                    deck.Add(card);
                }
            }

            foreach (Card card in deck)
            {
                Console.Write(card.Suit.ToString());
                Console.WriteLine(card.Value.ToString());
            }

            Console.ReadLine();
        }
    }
}

