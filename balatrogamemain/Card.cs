using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogamemain
{
    class Card
    {
        public CardValue Value; // waarde van kaart (2,3,4...K,Q,J,A)
        public Suit Suit; // soort kaart (hearts, diamonds, spades, clovers)

        // constructor om kaart te maken
        public Card(CardValue value, Suit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        // print alleen de waarde van kaart
        public void PrintMe()
        {
            Console.WriteLine(this.Value);
        }

        // zet kaart om naar tekst
        public string MakeAsString()
        {
            return Value.ToString();
        }

        // geef numerieke waarde terug voor score
        public int GetValue()
        {
            return (int)Value;
        }
    }
}
