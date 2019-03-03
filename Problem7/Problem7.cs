using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem7
{
    public static class Problem7
    {
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
                bool isPrime = Utilities.IsPrime(n);

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