using System.Collections.Generic;
using System.IO;

namespace Problem54
{
    public class Deal
    {
        public Hand Hand1 { get; set; }
        public Hand Hand2 { get; set; }
        
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

        public bool IsHand1Winner()
        {
            PokerHandType pokerhand1 = Hand1.GetPokerHandType();
            PokerHandType pokerhand2 = Hand2.GetPokerHandType();
            
            
            
            return true;
        }
    }
}