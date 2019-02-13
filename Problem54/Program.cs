using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Problem54
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 54");

            int answer = Solve();
            WriteLine($"answer = {answer}");

            WriteLine("Done");
        }

        public static int Solve()
        {
            int winningHands = 0;
            List<Deal> deals = Deal.ReadDeals().ToList();
            // todo remove count
            int count = 0;
            int dealNumber = 1;

            foreach (Deal deal in deals)
            {
                PokerHandType pokerhandType1 = deal.Hand1.GetPokerHandType();
                PokerHandType pokerhandType2 = deal.Hand2.GetPokerHandType();
                
                bool hand1Wins = deal.IsHand1Winner();
                
                WriteLine("----------------------------------------------------------");
                WriteLine($"Deal Number = {dealNumber}");
                WriteLine($"{deal}");
                WriteLine($"hand1Type = {pokerhandType1}, hand2Type = {pokerhandType2}");
                WriteLine($"Poker hand 1 wins = {hand1Wins}");

                if (hand1Wins)
                {
                    winningHands++;
                }

                dealNumber++;
                count++;

                if (count > 10)
                {
                    break;
                }
            }

            return winningHands;
        }
    }
}