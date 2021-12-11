using System;
using System.Collections.Generic;
using static System.Console;

namespace Problem60
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Problem60
    {
        public static int Solve()
        {
            const int upperBound = 1_000_000;
            PrimesUtility primesUtility = new(upperBound);
            
            //int answer = SolvePrime4Problem(primesUtility);
            int answer = SolvePrime5Problem(primesUtility);

            return answer;
        }

        public static int SolvePrime4Problem(PrimesUtility primesUtility)
        {
            int maxPrimeIndex = primesUtility.Primes.Count;

            for (int n1 = 1; n1 < maxPrimeIndex; n1++)
            {
                for (int n2 = n1 + 1; n2 < maxPrimeIndex; n2++)
                {
                    for (int n3 = n2 + 1; n3 < maxPrimeIndex; n3++)
                    {
                        for (int n4 = n3 + 1; n4 < maxPrimeIndex; n4++)
                        {
                            int prime1 = primesUtility.Primes[n1];
                            int prime2 = primesUtility.Primes[n2];
                            int prime3 = primesUtility.Primes[n3];
                            int prime4 = primesUtility.Primes[n4];

                            List<int> candidatePrimes = new() {prime1, prime2, prime3, prime4};
                            bool areConcatenatedPrimesPrime = AreConcatenatedPrimesPrime(candidatePrimes, primesUtility);

                            if (areConcatenatedPrimesPrime)
                            {
                                WriteLine($"n1 = {n1}, n2 = {n2}, n3 = {n3}, n4 = {4}");
                                return n1 + n2 + n3 + n4;
                            }
                        }
                    }
                }
            }

            return 0;
        }
        
        private static int SolvePrime5Problem(PrimesUtility primesUtility)
        {
            int maxPrimeIndex = primesUtility.Primes.Count;

            for (int n1 = 1; n1 < maxPrimeIndex; n1++)
            {
                for (int n2 = n1 + 1; n2 < maxPrimeIndex; n2++)
                {
                    for (int n3 = n2 + 1; n3 < maxPrimeIndex; n3++)
                    {
                        for (int n4 = n3 + 1; n4 < maxPrimeIndex; n4++)
                        {
                            for (int n5 = n4 + 1; n5 < maxPrimeIndex; n5++)
                            {
                                int prime1 = primesUtility.Primes[n1];
                                int prime2 = primesUtility.Primes[n2];
                                int prime3 = primesUtility.Primes[n3];
                                int prime4 = primesUtility.Primes[n4];
                                int prime5 = primesUtility.Primes[n5];

                                List<int> candidatePrimes = new() {prime1, prime2, prime3, prime4, prime5};
                                bool areConcatenatedPrimesPrime = AreConcatenatedPrimesPrime(candidatePrimes, primesUtility);

                                if (areConcatenatedPrimesPrime)
                                {
                                    WriteLine($"n1 = {n1}, n2 = {n2}, n3 = {n3}, n4 = {4}, n5 = {n5}");
                                    return n1 + n2 + n3 + n4 + n5;
                                }
                            }
                        }
                    }
                }
            }

            return 0;
        }

        public static bool AreConcatenatedPrimesPrime(IReadOnlyCollection<int> primes, PrimesUtility primesUtility)
        {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (int prime1 in primes)
            {
                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (int prime2 in primes)
                {
                    if (prime1 >= prime2)
                    {
                        continue;
                    }

                    string prime1String = prime1.ToString();
                    string prime2String = prime2.ToString();

                    string prime12String = prime1String + prime2String;
                    string prime21String = prime2String + prime1String;

                    int prime12 = Convert.ToInt32(prime12String);
                    int prime21 = Convert.ToInt32(prime21String);

                    bool isPrime12 = primesUtility.IsPrimeFast(prime12);
                    bool isPrime21 = primesUtility.IsPrimeFast(prime21);

                    bool bothPrime = isPrime12 && isPrime21;

                    if (!bothPrime)
                    {
                        //WriteLine($"prime1 = {prime1}, prime2 = {prime2}");
                        return false;
                    }
                }
            }

            return true;
        }
    }
}