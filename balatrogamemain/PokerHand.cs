using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatrogamemain
{
    enum HandType
    {
        HighCard, Pair, TwoPair, ThreeOfAKind, Straight, Flush,
        FullHouse, FourOfAKind, StraightFlush, RoyalFlush
    }

    class PokerHand
    {
        public static HandType GetHandType(List<Card> cards)
        {
            if (cards.Count < 5) return HandType.HighCard;

            if (IsFourOfAKind(cards)) return HandType.FourOfAKind;
            if (IsFullHouse(cards)) return HandType.FullHouse;
            if (IsFlush(cards)) return HandType.Flush;
            if (IsStraight(cards)) return HandType.Straight;
            if (IsThreeOfAKind(cards)) return HandType.ThreeOfAKind;
            if (IsTwoPair(cards)) return HandType.TwoPair;
            if (IsPair(cards)) return HandType.Pair;
            return HandType.HighCard;
        }

        public static int GetPoints(HandType handType)
        {
            switch (handType)
            {
                case HandType.FourOfAKind: return 600;
                case HandType.FullHouse: return 500;
                case HandType.Flush: return 400;
                case HandType.Straight: return 300;
                case HandType.ThreeOfAKind: return 200;
                case HandType.TwoPair: return 50;
                case HandType.Pair: return 20;
                default: return 5;
            }
        }

        private static bool IsFourOfAKind(List<Card> cards)
        {
            var groups = cards.GroupBy(c => c.Value).ToList();
            return groups.Any(g => g.Count() == 4);
        }

        private static bool IsFullHouse(List<Card> cards)
        {
            var groups = cards.GroupBy(c => c.Value).ToList();
            return groups.Any(g => g.Count() == 3) && groups.Any(g => g.Count() == 2);
        }

        private static bool IsFlush(List<Card> cards)
        {
            var groups = cards.GroupBy(c => c.Suit).ToList();
            return groups.Any(g => g.Count() >= 5);
        }

        private static bool IsStraight(List<Card> cards)
        {
            var values = cards.Select(c => (int)c.Value).Distinct().OrderBy(x => x).ToList();
            if (values.Count < 5) return false;
            
            for (int i = 0; i <= values.Count - 5; i++)
            {
                bool isStraight = true;
                for (int j = 0; j < 4; j++)
                {
                    if (values[i + j + 1] - values[i + j] != 1)
                    {
                        isStraight = false;
                        break;
                    }
                }
                if (isStraight) return true;
            }
            return false;
        }

        private static bool IsThreeOfAKind(List<Card> cards)
        {
            var groups = cards.GroupBy(c => c.Value).ToList();
            return groups.Any(g => g.Count() == 3);
        }

        private static bool IsTwoPair(List<Card> cards)
        {
            var groups = cards.GroupBy(c => c.Value).ToList();
            int pairCount = 0;
            foreach (var group in groups)
            {
                if (group.Count() >= 2)
                {
                    pairCount++;
                }
            }
            return pairCount >= 2;
        }

        private static bool IsPair(List<Card> cards)
        {
            var groups = cards.GroupBy(c => c.Value).ToList();
            return groups.Any(g => g.Count() == 2);
        }
    }
}
