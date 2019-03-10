using System.Collections.Generic;
using static System.Console;


namespace Problem54
{
    
    // https://www.mathblog.dk/project-euler-54-poker-hands/

    public static class Problem54
    {
        public static int Solve()
        {
            int hand1Wins = 0;
            int dealNumber = 1;
            List<Deal> deals = Deal.ReadDeals();

            foreach (Deal deal in deals)
            {
                PokerHandType pokerhandType1 = deal.Hand1.GetPokerHandType();
                PokerHandType pokerhandType2 = deal.Hand2.GetPokerHandType();
                
                bool isHand1Winner = deal.IsHand1Winner();
                
                WriteLine("----------------------------------------------------------");
                WriteLine($"Deal Number = {dealNumber}");
                WriteLine($"{deal}");
                WriteLine($"hand1Type = {pokerhandType1}, hand2Type = {pokerhandType2}");
                WriteLine($"Hand 1 wins = {isHand1Winner}");

                if (isHand1Winner)
                {
                    hand1Wins++;
                }

                dealNumber++;
            }

            return hand1Wins;
        }
    }
}