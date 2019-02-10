using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem3
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public  class Program
    {
        public static void Main()
        {
            WriteLine("Problem 3");

            long answer = Solve();
            WriteLine($"largestPrimeFactor = {answer}");    //  6857

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            const long number = 600851475143;
            IEnumerable<long> primeFactors = GetPrimeFactors(number);
            long largestPrimeFactor = primeFactors.Max(n => n);
            return largestPrimeFactor;
        }
    }
}
