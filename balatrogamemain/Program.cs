using balatrogamemain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogamemain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Maak nieuw deck met 52 kaarten
            Deck deck = new Deck();

            // Trek 5 kaarten uit het deck
            List<Card> myHand = deck.TakeCards(5);

            // Toon de getrokken kaarten
            Console.WriteLine("Je hebt deze 5 kaarten gekregen:");
            foreach (Card card in myHand)
            {
                Console.WriteLine($"{card.Value} van {card.Suit}");
            }

            Console.WriteLine($"\nEr zitten nog {deck.GetCards().Count} kaarten in het deck");

            // Trek nog 3 kaarten
            Console.WriteLine("\nJe trekt nog 3 extra kaarten:");
            List<Card> moreCards = deck.TakeCards(3);
            foreach (Card card in moreCards)
            {
                Console.WriteLine($"{card.Value} van {card.Suit}");
            }

            Console.WriteLine($"\nEr zitten nog {deck.GetCards().Count} kaarten in het deck");

            Console.ReadLine();
        }
    }
}

