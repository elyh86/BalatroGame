using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogamemain
{
    class Card
    {
        public CardValue Value; // Waarde van de kaart
        public Suit Suit; // Type kaart

        // Constructor - maakt een kaart
        public Card(CardValue value, Suit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        // Print de kaartwaarde
        public void PrintMe()
        {
            Console.WriteLine(this.Value);
        }

        // Zet kaart om naar tekst
        public string MakeAsString()
        {
            return Value.ToString();
        }
    }
}
