using System.Collections.Generic;
using System.IO;
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
            IEnumerable<Deal> deals = ReadDeals();

            return deals.Count();
        }

        private static IEnumerable<Deal> ReadDeals()
        {
            const string fileName = "PokerHands.txt";
            string[] dealStrings = File.ReadAllLines(fileName);
            List<Deal> dealList = new List<Deal>();

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var dealString in dealStrings)
            {
                string[] hands = dealString.Split(' ');

                Hand hand1 = GetHand(hands[0], hands[1], hands[2], hands[3], hands[4]);
                Hand hand2 = GetHand(hands[5], hands[6], hands[7], hands[8], hands[9]);

                Deal deal = new Deal
                {
                    Hand1 = hand1,
                    Hand2 = hand2
                };

                dealList.Add(deal);
            }

            return dealList;
        }

        private static Hand GetHand(string card0String, string card1String, string card2String, string card3String, string card4String)
        {
            Card card0 = new Card(card0String);
            Card card1 = new Card(card1String);
            Card card2 = new Card(card2String);
            Card card3 = new Card(card3String);
            Card card4 = new Card(card4String);

            Hand hand = new Hand(card0, card1, card2, card3, card4);
            return hand;
        }
    }
}