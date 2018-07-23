using System;
using System.Collections.Generic;

namespace Problem14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 14");

            int lowerBound = 2;
            int upperBound = 10000;

            (int, List<int>) result = GetLongestCollatzChain(lowerBound, upperBound);
            int start = result.Item1;
            List<int> longestCollatzChain = result.Item2;
            int chainLength = longestCollatzChain.Count;

            Console.WriteLine($"Start = {start}, Length = {chainLength}");
            longestCollatzChain.ForEach(Console.WriteLine);

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static (int, List<int>) GetLongestCollatzChain(int lowerBound, int upperBound)
        {            
            List<int> longestCollatzChain = new List<int>();
            int maxLength = 0;
            int maxChainStart = 0;

            for (int n = lowerBound; n <= upperBound; n++)
            {
                //if (n % 1000 == 0)
                //{
                //    Console.WriteLine(n);
                //}

                List<int> collatzChain = GenerateCollatzChain(n);
                int chainLength = collatzChain.Count;

                if (chainLength > maxLength)
                {
                    maxChainStart = n;
                    maxLength = chainLength;
                    longestCollatzChain = CloneList(collatzChain);
                }
            }

            return (maxChainStart, longestCollatzChain);
        }

        private static List<int> GenerateCollatzChain(int start)
        {
            List<int> collatzChain = new List<int>();
            int n = start;
            collatzChain.Add(n);

            while (true)
            {
                int next = GetNextCollatzNumber(n);
                collatzChain.Add(next);

                if (next == 1)
                {
                    break;
                }

                n = next;
            }

            return collatzChain;
        }

        private static int GetNextCollatzNumber(int n)
        {
            if (n % 2 == 0)
            {
                return n / 2;
            }

            return 3 * n + 1;
        }

        private static List<int> CloneList(List<int> list)
        {
            List<int> clonedList = new List<int>();

            foreach(int n in list)
            {
                clonedList.Add(n);
            }

            return clonedList;
        }
    }
}
