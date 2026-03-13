using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogamemain
{
    class Player // Beheert de kaarten van een speler
    {
        private List<Card> hand; // Kaarten in de hand van de speler

        // Constructor - maakt een nieuwe speler
        public Player()
        {
            this.hand = new List<Card>();
        }

        // Voegt een kaart toe aan de hand
        public void AddCard(Card card)
        {
            this.hand.Add(card);
        }

        // Toont alle kaarten in de hand
        public void ShowHand()
        {
            Console.WriteLine("Jouw hand:");
            foreach (Card card in this.hand)
            {
                Console.WriteLine(card.MakeAsString() + " " + card.Suit);
            }
        }

        public List<Card> GetHand() => hand;
    }
}
