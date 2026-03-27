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

            // Maak een spelerhand
            PlayerHand hand = new PlayerHand();

            // Trek 5 kaarten uit het deck en geef aan speler
            for (int i = 0; i < 5; i++)
            {
                Card card = deck.TakeCard();
                if (card != null)
                {
                    hand.AddCard(card);
                }
            }

            // Toon de hand van de speler met score
            hand.ShowHand();

            // Laat speler kaarten selecteren
            List<Card> selectedCards = hand.SelectCards();
            Console.WriteLine("\nGeselecteerde kaarten:");
            foreach (Card card in selectedCards)
            {
                Console.WriteLine(card.MakeAsString() + " " + card.Suit);
            }

            // Analyseer de pokerhand
            hand.AnalyzeHand(selectedCards);

            // Vervang geselecteerde kaarten met nieuwe kaarten
            Console.WriteLine("\nNieuwe kaarten trekken...");
            foreach (Card selectedCard in selectedCards)
            {
                // Verwijder de geselecteerde kaart uit de hand
                hand.GetCards().Remove(selectedCard);
                
                // Trek een nieuwe kaart en voeg toe
                Card newCard = deck.TakeCard();
                if (newCard != null)
                {
                    hand.AddCard(newCard);
                    Console.WriteLine("Nieuwe kaart: " + newCard.MakeAsString() + " " + newCard.Suit);
                }
            }

            // Toon de bijgewerkte hand
            Console.WriteLine("\nBijgewerkte hand:");
            hand.ShowHand();

            Console.WriteLine("\nEr zitten nog " + deck.GetCards().Count + " kaarten in het deck");
            Console.WriteLine("\nDruk op Enter om te stoppen...");
            
            // Leeg de input buffer
            while (Console.KeyAvailable)
                Console.ReadKey(true);
                
            Console.ReadLine();
        }
    }
}

