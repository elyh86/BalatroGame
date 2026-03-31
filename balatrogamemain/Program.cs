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
            Deck deck = new Deck();
            PlayerHand hand = new PlayerHand();

            for (int i = 0; i < 5; i++)
            {
                Card card = deck.TakeCard();
                if (card != null)
                {
                    hand.AddCard(card);
                }
            }

            Console.Clear();
            hand.ShowHand();

        SelecteerKaarten:
            Console.WriteLine("\nDruk op Enter om kaarten te kiezen...");
            Console.ReadLine();
            
            Console.Clear();
            hand.ShowHand();
            
            List<Card> selectedCards = hand.SelectCards();
            Console.WriteLine("\nGeselecteerde kaarten:");
            foreach (Card card in selectedCards)
            {
                Console.WriteLine(card.MakeAsString() + " " + card.Suit);
            }

            hand.AnalyzeHand(selectedCards);

            Console.WriteLine("\nNieuwe kaarten trekken...");
            foreach (Card selectedCard in selectedCards)
            {
                hand.GetCards().Remove(selectedCard);
                
                Card newCard = deck.TakeCard();
                if (newCard != null)
                {
                    hand.AddCard(newCard);
                    Console.WriteLine("Nieuwe kaart: " + newCard.MakeAsString() + " " + newCard.Suit);
                }
            }

            Console.WriteLine("\nDruk op Enter voor nieuwe hand...");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Nieuwe hand:");
            hand.ShowHand();

            Console.WriteLine("\nNog een keer kaarten kiezen? (j/n)");
            string antwoord = Console.ReadLine();
            
            if (antwoord.ToLower() == "j")
            {
                Console.Clear();
                Console.WriteLine("Nieuwe ronde...");
                goto SelecteerKaarten;
            }

            Console.WriteLine("\nDruk op Enter om te stoppen...");
            Console.ReadLine();
        }
    }
}

