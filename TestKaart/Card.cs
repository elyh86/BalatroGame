using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogame
{
    class Card
    {
        public CardValue Value;
        public Suit Suit;
        public Card(CardValue value, Suit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        public void PrintMe()
        {
            Console.WriteLine(this.Value);
        }
        public string MakeAsString()
        {
            return Value.ToString();
        }

    }
}
