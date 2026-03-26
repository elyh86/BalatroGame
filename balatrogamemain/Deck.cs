using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogamemain
{
    class Deck // beheert alle kaarten in het spel
    {
        private List<Card> cards; // lijst met alle 52 kaarten

        // constructor maakt deck en shuffelt
        public Deck()
        {
            cards = new List<Card>();
            InitializeDeck(); // maak alle kaarten
            Shuffle(); // schud ze door elkaar
        }

        // maak alle 52 kaarten (4 soorten x 13 waardes)
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

        // schud kaarten random door elkaar
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(cards.Count); // kies random plek
                Card temp = cards[i]; // wissel kaarten
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        // trek 1 kaart van boven en verwijder
        public Card TakeCard()
        {
            if (cards.Count == 0) // check of deck niet leeg is
                return null;
            
            Card card = cards[0]; // pak eerste kaart
            cards.RemoveAt(0); // verwijder uit deck
            return card;
        }

        // geef lijst terug van alle kaarten in deck
        public List<Card> GetCards() => cards;
    }
}
