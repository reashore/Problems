using System;
using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem7
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 7");

            int answer = Solve();
            WriteLine($"answer = {answer}");

            WriteLine("Done");
            ReadKey();
        }

        public static int Solve()
        {
            const int topPrime = 1001;
            if (topPrime < 2)
            {
                throw new ArgumentException(nameof(topPrime));
            }

            List<int> primesList = new List<int>();

            for (int n = 2; ; n++)
            {
                bool isPrime = IsPrime(n);

                if (isPrime)
                {
                    primesList.Add(n);
                }

                if (primesList.Count == topPrime)
                {
                    break;
                }
            }
            
            int answer = primesList.Last();

            return answer;
        }
    }
}

