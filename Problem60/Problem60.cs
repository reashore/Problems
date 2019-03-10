using System;
using Common;

namespace Problem60
{
    public static class Problem60
    {
        public static int Solve()
        {
            const int upperBound = 10_000;
            
            for (int n = 1; n <= upperBound; n++)
            {
                bool isPrime1 = IsPrime(n);
                bool isPrime2 = Utilities.IsPrime(n);
                
                Console.WriteLine($"{n, 5} {isPrime1}");
            }
            
            return 0;
        }
        
        private static bool IsPrime(int number) {
            // Sieve of Eratosthenes.
            if (number < 2)
            {
                return false;
            }

            // Reserve place for val + 1 and set with true.
            bool[] mark = new bool[number + 1];
            
            for(int i = 2; i <= number; i++)
            {
                mark[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (mark[i])
                {
                    // Cross out every i-th number in the places after i (all the multiples of i).
                    for (int j = (i * i); j <= number; j += i)
                    {
                        mark[j] = false;
                    }
                }
            }

            return mark[number];
        }
    }
}