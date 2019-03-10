using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

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
            
            if (pokerHandType1 < pokerHandType2)
            {
                return false;
            }
            
            return IsHand1WinnerWhereBothHandsHaveSamePokerType(pokerHandType1);
        }

        private bool IsHand1WinnerWhereBothHandsHaveSamePokerType(PokerHandType pokerHandType)
        {
            switch (pokerHandType)
            {
                case PokerHandType.HighCard:
                    return IsHand1WithHighCardWinner();
                    
                case PokerHandType.OnePair:
                    return IsHand1WithOnePairWinner();

                case PokerHandType.TwoPair:
                case PokerHandType.ThreeOfKind:
                case PokerHandType.Straight:
                case PokerHandType.Flush:
                case PokerHandType.FullHouse:
                case PokerHandType.FourOfKind:
                case PokerHandType.StraightFlush:
                case PokerHandType.RoyalFlush:
                    throw new Exception("There are no deals where both hands have this poker type");
                    
                default:
                    throw new Exception("Should not get here");
            }
        }

        public bool IsHand1WithOnePairWinner()
        {
            PokerHandType pokerHandType1 = Hand1.GetPokerHandType();

            if (pokerHandType1 != PokerHandType.OnePair)
            {
                throw new Exception("Hands should both be one pair");
            }

            Rank hand1HighRank = Rank.C2;
            List<Rank> sortedHand1Ranks= Hand1.GetSortedRanks();
            
            foreach (Rank rank in sortedHand1Ranks)
            {
                if (Hand1.NumberCardsOfRank(rank) == 2)
                {
                    hand1HighRank = rank;
                    break;
                }
            }
            
            Rank hand2HighRank = Rank.C2;
            List<Rank> sortedHand2Ranks = Hand2.GetSortedRanks();
            
            foreach (Rank rank in sortedHand2Ranks)
            {
                if (Hand2.NumberCardsOfRank(rank) == 2)
                {
                    hand2HighRank = rank;
                    break;
                }
            }

            if ((int) hand1HighRank > (int) hand2HighRank)
            {
                return true;
            }
            
            if ((int) hand1HighRank < (int) hand2HighRank)
            {
                return false;
            }

            sortedHand1Ranks.Remove(hand1HighRank);
            sortedHand1Ranks.Remove(hand1HighRank);
            
            sortedHand2Ranks.Remove(hand2HighRank);
            sortedHand2Ranks.Remove(hand2HighRank);
            
            for (int n = 0; n <sortedHand1Ranks.Count; n++)
            {
                int value1 = (int) sortedHand1Ranks[n];
                int value2 = (int) sortedHand2Ranks[n];
                
                if (value1 != value2)
                {
                    return (value1 > value2);
                }
            }
            
            return false;
        }

        public bool IsHand1WithHighCardWinner()
        {
            List<Rank> sortedHand1Ranks = Hand1.GetSortedRanks();
            List<Rank> sortedHand2Ranks = Hand2.GetSortedRanks();

            for (int n = 0; n < 5; n++)
            {
                int value1 = (int) sortedHand1Ranks[n];
                int value2 = (int) sortedHand2Ranks[n];
                
                if (value1 != value2)
                {
                    return (value1 > value2);
                }
            }
            
            return false;
        }
 
        //-----------------------------------------------------------------------------------------------
        
        public static void GetDealsWhereBothHandsAreSamePokerType()
        {
            List<Deal> bothHandsAreRoyalFlush = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.RoyalFlush);
            List<Deal> bothHandsAreStraightFlush = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.StraightFlush);
            List<Deal> bothHandsAreFourOfKind = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.FourOfKind);
            List<Deal> bothHandsAreFullHouse = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.FullHouse);
            List<Deal> bothHandsAreFlush = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.Flush);
            List<Deal> bothHandsAreStraight = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.Straight);
            List<Deal> bothHandsAreThreeOfKind = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.ThreeOfKind);
            List<Deal> bothHandsAreTwoPair = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.TwoPair);
            List<Deal> bothHandsAreOnePair = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.OnePair);
            List<Deal> bothHandsAreHighCard = GetDealsWhereBothHandsAreSamePokerType(PokerHandType.HighCard);

            WriteLine($"bothHandsAreRoyalFlush    = {bothHandsAreRoyalFlush.Count}");
            WriteLine($"bothHandsAreStraightFlush = {bothHandsAreStraightFlush.Count}");
            WriteLine($"bothHandsAreFourOfKind    = {bothHandsAreFourOfKind.Count}");
            WriteLine($"bothHandsAreFullHouse     = {bothHandsAreFullHouse.Count}");
            WriteLine($"bothHandsAreFlush         = {bothHandsAreFlush.Count}");
            WriteLine($"bothHandsAreStraight      = {bothHandsAreStraight.Count}");
            WriteLine($"bothHandsAreThreeOfKind   = {bothHandsAreThreeOfKind.Count}");
            WriteLine($"bothHandsAreTwoPair       = {bothHandsAreTwoPair.Count}");
            WriteLine($"bothHandsAreOnePair       = {bothHandsAreOnePair.Count}");
            WriteLine($"bothHandsAreHighCard      = {bothHandsAreHighCard.Count}");
            
            // Therefore it is only necessary to break ties for High-Card and One-Pair
        }
                
        private static List<Deal> GetDealsWhereBothHandsAreSamePokerType(PokerHandType pokerhandType)
        {
            List<Deal> deals = ReadDeals();
            List<Deal> bothHandsAreSamePokerTypeList = new List<Deal>();

            foreach (Deal deal in deals)
            {
                bool areHandsSamePokerType = deal.AreHand1AndHand2TheSamePokerType();

                if (areHandsSamePokerType && deal.Hand1.GetPokerHandType() == pokerhandType)
                {
                    bothHandsAreSamePokerTypeList.Add(deal);
                }
            }

            return bothHandsAreSamePokerTypeList;
        }

        private bool AreHand1AndHand2TheSamePokerType()
        {
            PokerHandType pokerHandType1 = Hand1.GetPokerHandType();
            PokerHandType pokerHandType2 = Hand2.GetPokerHandType();

            return pokerHandType1 == pokerHandType2;
        }
    }
}