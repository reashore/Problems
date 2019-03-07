using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem54
{
    public static class Problem54
    {
        public static int Solve()
        {
            int winningHands = 0;
            int dealNumber = 1;
            List<Deal> deals = Deal.ReadDeals().ToList();

            foreach (Deal deal in deals)
            {
                PokerHandType pokerhandType1 = deal.Hand1.GetPokerHandType();
                PokerHandType pokerhandType2 = deal.Hand2.GetPokerHandType();
                
                bool hand1Wins = deal.IsHand1Winner();
                
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"Deal Number = {dealNumber}");
                Console.WriteLine($"{deal}");
                Console.WriteLine($"hand1Type = {pokerhandType1}, hand2Type = {pokerhandType2}");
                Console.WriteLine($"Poker hand 1 wins = {hand1Wins}");

                if (hand1Wins)
                {
                    winningHands++;
                }

                dealNumber++;
            }

            return winningHands;
        }
        
        public static void GetTiedHands(PokerHandType pokerhandType)
        {
            List<Deal> deals = Deal.ReadDeals().ToList();

            foreach (Deal deal in deals)
            {
                PokerHandType pokerhandType1 = deal.Hand1.GetPokerHandType();
                PokerHandType pokerhandType2 = deal.Hand2.GetPokerHandType();

                bool isTie = (int) pokerhandType1 == (int) pokerhandType2;

                if (isTie && pokerhandType1 == pokerhandType)
                {
                    Console.WriteLine($"{deal}");
                }
            }
        }
    }
}