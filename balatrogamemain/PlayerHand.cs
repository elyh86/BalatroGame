using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogamemain
{
    class PlayerHand // Beheert de kaarten en score van een spelerhand
    {
        private List<Card> cards; // Kaarten in de hand

        public PlayerHand()
        {
            this.cards = new List<Card>();
        }

        // Voegt kaart toe aan hand
        public void AddCard(Card card)
        {
            this.cards.Add(card);
        }

        // Bereken totale score van hand
        public int GetScore()
        {
            int score = 0;
            foreach (Card card in this.cards)
            {
                score += card.GetValue();
            }
            return score;
        }

        // Toon kaarten in hand
        public void ShowHand()
        {
            Console.WriteLine("Jouw hand:");
            foreach (Card card in this.cards)
            {
                Console.WriteLine(card.MakeAsString() + " " + card.Suit);
            }
            Console.WriteLine("Score: " + GetScore());
        }

        public List<Card> GetCards() => cards;
    }
}
