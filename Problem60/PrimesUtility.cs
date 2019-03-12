using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace Problem60
{
    // https://stackoverflow.com/questions/1801391/what-is-the-best-algorithm-for-checking-if-a-number-is-prime
    
    public class PrimesUtility
    {
        private readonly int _upperBound;
        private readonly BitArray _primeBitArray;

        public PrimesUtility(int upperBound)
        {
            _upperBound = upperBound;
            _primeBitArray = new BitArray(_upperBound);
            Primes = new List<int>();
            CreatePrimeLookupArray();
        }
        
        public readonly List<int> Primes;

        public  bool IsPrimeFast(int number)
        {
            return _primeBitArray[number];
        }
        
        private void CreatePrimeLookupArray()
        {
            for (int number = 1; number <= _upperBound; number++)
            {
                bool isPrime = IsPrime1(number);

                if (isPrime)
                {
                    _primeBitArray[number] = true;
                    Primes.Add(number);
                }
            }
        }

        // Fastest IsPrime algorithm
        private static bool IsPrime1(int number)
        {
            if (number == 2)
            {
                return true;
            }

            if (number == 3)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }
            
            if (number % 3 == 0)
            {
                return false;
            }

            int i = 5;
            int w = 2;

            while (i * i <= number)
            {
                if (number % i == 0)
                {
                    return false;
                }

                i += w;
                w = 6 - w;
            }

            return true;
        }
        
        private static bool IsPrime2(int number)
        {
            // Algorithm fails if number < 0, so take absolute value
            number = Math.Abs(number);

            if ((number & 1) == 0)
            {
                return number == 2;
            }

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return number != 1;
        }

        private static bool IsPrime3(int number) {
            // Sieve of Eratosthenes.
            if (number < 2)
            {
                return false;
            }

            // Reserve place for val + 1 and set with true.
            bool[] mark = new bool[number + 1];
            
            for (int i = 2; i <= number; i++)
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
        
        public static void CompareIsPrimeAlgorithms()
        {
            const int upperBound = 100_000;
            
            for (int number = 1; number < upperBound; number++)
            {
                bool isPrime1 = IsPrime1(number);
                bool isPrime2 = IsPrime2(number);
                bool isPrime3 = IsPrime3(number);

                if (isPrime1 != isPrime2 && isPrime2 != isPrime3)
                {
                    WriteLine("Algorithms differ");
                }

                if (number % 1000 == 0)
                {
                    WriteLine($"number = {number}");
                }
            }
        }

        public static void TimeIsPrimeAlgorithms()
        {
            const int numberIterations = 100_000;

            TimeSpan timeSpan1 = TimeIsPrimeAlgorithm(IsPrime1, numberIterations);
            WriteLine($"timeSpan1 = {timeSpan1}");
            
            TimeSpan timeSpan2 = TimeIsPrimeAlgorithm(IsPrime2, numberIterations);
            WriteLine($"timeSpan2 = {timeSpan2}");
            
            TimeSpan timeSpan3 = TimeIsPrimeAlgorithm(IsPrime3, numberIterations);
            WriteLine($"timeSpan3 = {timeSpan3}");
        }
        
        private static TimeSpan TimeIsPrimeAlgorithm(Func<int, bool> isPrimeAlgorithm, int numberIterations)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int number = 1; number < numberIterations; number++)
            {
                // ReSharper disable once UnusedVariable
                bool isPrime = isPrimeAlgorithm(number);
            }
            
            TimeSpan timeSpan = stopwatch.Elapsed;

            return timeSpan;
        }
    }
}













