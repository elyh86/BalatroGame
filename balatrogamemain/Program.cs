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

            // Maak een speler
            Player player = new Player();

            // Trek 5 kaarten uit het deck en geef aan speler
            for (int i = 0; i < 5; i++)
            {
                Card card = deck.TakeCard();
                if (card != null)
                {
                    player.AddCard(card);
                }
            }

            // Toon de hand van de speler
            player.ShowHand();

            Console.WriteLine("\nEr zitten nog " + deck.GetCards().Count + " kaarten in het deck");

            // Trek nog 3 kaarten
            Console.WriteLine("\nJe trekt nog 3 extra kaarten:");
            for (int i = 0; i < 3; i++)
            {
                Card card = deck.TakeCard();
                if (card != null)
                {
                    Console.WriteLine(card.Value + " van " + card.Suit);
                }
            }

            Console.WriteLine("\nEr zitten nog " + deck.GetCards().Count + " kaarten in het deck");

            Console.ReadLine();
        }
    }
}

