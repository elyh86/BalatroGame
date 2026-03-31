using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogamemain
{
    class PlayerHand // beheert kaarten van speler
    {
        private List<Card> cards; // kaarten in hand van speler

        // constructor maakt lege hand
        public PlayerHand()
        {
            this.cards = new List<Card>();
        }

        // voeg kaart toe aan hand
        public void AddCard(Card card)
        {
            this.cards.Add(card);
        }

        // bereken totale score van alle kaarten
        public int GetScore()
        {
            int score = 0;
            for (int i = 0; i < this.cards.Count; i++)
            {
                score += this.cards[i].GetValue(); // tel waarde op
            }
            return score;
        }

        // toon alle kaarten in hand met nummers
        public void ShowHand()
        {
            Console.WriteLine("Jouw hand:");
            for (int i = 0; i < this.cards.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + this.cards[i].MakeAsString() + " " + this.cards[i].Suit);
            }
            Console.WriteLine("Score: " + GetScore()); // toon totale score
        }

        // geef lijst terug van kaarten
        public List<Card> GetCards() => cards;

        // laat speler kaarten selecteren voor pokerhand
        public List<Card> SelectCards()
        {
            Console.WriteLine("Welke kaarten wil je kiezen? (bijv: 1,3,5)");
            string input = Console.ReadLine();
            
            List<Card> selected = new List<Card>();
            if (!string.IsNullOrEmpty(input))
            {
                string[] numbers = input.Split(',');
                
                foreach (string num in numbers)
                {
                    int index;
                    if (int.TryParse(num.Trim(), out index) && index > 0 && index <= this.cards.Count)
                    {
                        selected.Add(this.cards[index - 1]);
                    }
                }
            }
            
            return selected;
        }

        // analyseer geselecteerde kaarten voor pokerhand
        public void AnalyzeHand(List<Card> selectedCards)
        {
            HandType handType = PokerHand.GetHandType(selectedCards);
            int points = PokerHand.GetPoints(handType);
            Console.WriteLine("Hand type: " + handType);
            Console.WriteLine("Punten: " + points);
        }
    }
}
