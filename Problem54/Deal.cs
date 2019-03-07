using System;
using System.Collections.Generic;
using System.IO;

namespace Problem54
{
    public class Deal
    {
        public Deal(Hand hand1, Hand hand2)
        {
            Hand1 = hand1;
            Hand2 = hand2;
        }
        
        public Hand Hand1 { get; }
        public Hand Hand2 { get; }
        
        public static List<Deal> ReadDeals()
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

                Deal deal = new Deal(hand1, hand2);
                dealList.Add(deal);
            }

            return dealList;
        }

        public override string ToString()
        {
            string hand1String = Hand1.ToString();
            string hand2String = Hand2.ToString();
            string dealString = $"{hand1String} {hand2String}";

            return dealString;
        }

        public bool IsHand1Winner()
        {
            PokerHandType pokerHandType1 = Hand1.GetPokerHandType();
            PokerHandType pokerHandType2 =  Hand2.GetPokerHandType();

            if (pokerHandType1 > pokerHandType2)
            {
                return true;
            }
            
            if (pokerHandType1 == pokerHandType2)
            {
                return IsHand1WinnerOfTie();
            }
            
            return false;
        }

        private bool IsHand1WinnerOfTie()
        {
            int pokerHandType1 = (int) Hand1.GetPokerHandType();
            int pokerHandType2 = (int) Hand2.GetPokerHandType();

            if (pokerHandType1 != pokerHandType2)
            {
                throw new Exception("Hands should be tied");
            }

            switch (pokerHandType1)
            {
                case (int) PokerHandType.RoyalFlush:
                case (int) PokerHandType.StraightFlush:
                case (int) PokerHandType.FourOfKind:
                case (int) PokerHandType.FullHouse:
                case (int) PokerHandType.Flush:
                case (int) PokerHandType.Straight:
                case (int) PokerHandType.ThreeOfKind:
                case (int) PokerHandType.TwoPair:
                    throw new Exception("These poker hand types are not tied");
                    
                case (int) PokerHandType.OnePair:
                    return Hand1WithOnePairWinsTie();
                    
                case (int) PokerHandType.HighCard:
                    return Hand1WithHighCardWinsTie();
                    
                default:
                    throw new Exception("Should not get here");
            }
        }

        public bool Hand1WithOnePairWinsTie()
        {
            PokerHandType pokerHandType1 = Hand1.GetPokerHandType();

            if (pokerHandType1 != PokerHandType.OnePair)
            {
                throw new Exception("Hands should both be one pair");
            }

            Rank hand1HighRank = Rank.C2;
            List<Rank> sortedHand1Ranks= Hand1.GetSortedCardRanks();
            
            foreach (Rank rank in sortedHand1Ranks)
            {
                if (Hand1.NumberCardsOfRank(rank) == 2)
                {
                    hand1HighRank = rank;
                    break;
                }
            }
            
            Rank hand2HighRank = Rank.C2;
            List<Rank> sortedHand2Ranks = Hand2.GetSortedCardRanks();
            
            foreach (Rank rank in sortedHand2Ranks)
            {
                if (Hand2.NumberCardsOfRank(rank) == 2)
                {
                    hand2HighRank = rank;
                    break;
                }
            }

            if (hand1HighRank > hand2HighRank)
            {
                return true;
            }
            
            for (int n = 0; n < 5; n++)
            {
                if (sortedHand1Ranks[n] > sortedHand2Ranks[n])
                {
                    return true;
                }
            }
            
            return false;
        }

        public bool Hand1WithHighCardWinsTie()
        {
            List<Rank> sortedCardRanksForHand1 = Hand1.GetSortedCardRanks();
            List<Rank> sortedCardRanksForHand2 = Hand2.GetSortedCardRanks();

            for (int n = 0; n < 5; n++)
            {
                if (sortedCardRanksForHand1[n] > sortedCardRanksForHand2[n])
                {
                    return true;
                }
            }
            
            return false;
        }

//        public bool IsHand1TiedWithHand2()
//        {
//            PokerHandType pokerHandType1 = Hand1.GetPokerHandType();
//            PokerHandType pokerHandType2 = Hand2.GetPokerHandType();
//
//            return pokerHandType1 == pokerHandType2;
//        }
 
//        private static void GetDealsWithTies()
//        {
//            GetTiedHands(PokerHandType.RoyalFlush);
//            GetTiedHands(PokerHandType.StraightFlush);
//            GetTiedHands(PokerHandType.FourOfKind);
//            GetTiedHands(PokerHandType.FullHouse);
//            GetTiedHands(PokerHandType.Flush);
//            GetTiedHands(PokerHandType.Straight);
//            GetTiedHands(PokerHandType.ThreeOfKind);
//            GetTiedHands(PokerHandType.TwoPair);
//            GetTiedHands(PokerHandType.OnePair);
//            GetTiedHands(PokerHandType.HighCard);
//        }
//        
//                
//        private static void GetTiedHands(PokerHandType pokerhandType)
//        {
//            List<Deal> deals = ReadDeals();
//
//            foreach (Deal deal in deals)
//            {
//                PokerHandType pokerhandType1 = deal.Hand1.GetPokerHandType();
//                PokerHandType pokerhandType2 = deal.Hand2.GetPokerHandType();
//
//                bool isTie = (int) pokerhandType1 == (int) pokerhandType2;
//
//                if (isTie && pokerhandType1 == pokerhandType)
//                {
//                    Console.WriteLine($"{deal}");
//                }
//            }
//        }
    }
}