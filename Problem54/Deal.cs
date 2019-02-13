using System.Collections.Generic;
using System.IO;

namespace Problem54
{
    public enum Score
    {
        Win,
        Lose,
        Draw
    }
        
    public class Deal
    {
        public Hand Hand1 { get; private set; }
        public Hand Hand2 { get; private set; }
        
        public static IEnumerable<Deal> ReadDeals()
        {
            const string fileName = "PokerHands.txt";
            string[] dealStrings = File.ReadAllLines(fileName);
            List<Deal> dealList = new List<Deal>();

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var dealString in dealStrings)
            {
                string[] hands = dealString.Split(' ');

                Hand hand1 = new Hand(hands[0], hands[1], hands[2], hands[3], hands[4]);
                Hand hand2 = new Hand(hands[5], hands[6], hands[7], hands[8], hands[9]);

                Deal deal = new Deal
                {
                    Hand1 = hand1,
                    Hand2 = hand2
                };

                dealList.Add(deal);
            }

            return dealList;
        }

        public override string ToString()
        {
            string hand1String = Hand1.ToString();
            string han2String = Hand2.ToString();
            string dealString = $"{hand1String} | {han2String}";

            return dealString;
        }

        public bool IsHand1Winner()
        {
            int pokerHandTypeValue1 = (int) Hand1.GetPokerHandType();
            int pokerHandTypeValue2 = (int) Hand2.GetPokerHandType();

            if (pokerHandTypeValue1 > pokerHandTypeValue2)
            {
                return true;
            }
            else if (pokerHandTypeValue1 < pokerHandTypeValue2)
            {
                return false;
            }
            
            return IsHand1WinnerOfTie();
        }

        private bool IsHand1WinnerOfTie()
        {
            List<int> sortedCardRanksForHand1 = Hand1.GetSortedCardRanks();
            List<int> sortedCardRanksForHand2 = Hand1.GetSortedCardRanks();

            foreach (int rank1 in sortedCardRanksForHand1)
            {
                foreach (int rank2 in sortedCardRanksForHand2)
                {
                    if (rank1 > rank2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}