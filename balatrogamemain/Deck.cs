using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogamemain
{
    class Deck // Beheert alle speelkaarten
    {
        private List<Card> cards; // Alle kaarten in het deck

        // Constructor - maakt deck met 52 kaarten
        public Deck()
        {
            cards = new List<Card>();
            InitializeDeck();
            Shuffle();
        }

        // Maakt alle 52 kaarten
        private void InitializeDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    this.cards.Add(new Card(value, suit));
                }
            }
        }

        // Mengt kaarten door elkaar
        public void Shuffle()
        {
            this.cards = this.cards.Shuffle().ToList();
        }

        // Trek 1 kaart en verwijder uit deck
        public Card TakeCard()
        {
            if (cards.Count == 0)
                return null!;
            
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
        public List<Card> GetCards() => cards;
    }
}
