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
            ReadKey();
        }

        private static int Solve()
        {
            int winningHands = 0;
            List<Deal> deals = Deal.ReadDeals().ToList();

            foreach (Deal deal in deals)
            {
                if (deal.IsHand1Winner())
                {
                    winningHands++;
                }
            }

            return winningHands;
        }
    }
}