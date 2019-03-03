using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem3
{
    public static class Problem3
    {
        public static long Solve()
        {
            const long number = 600851475143;
            IEnumerable<long> primeFactors = Utilities.GetPrimeFactors(number);
            long largestPrimeFactor = primeFactors.Max(n => n);
            return largestPrimeFactor;
        }
    }
}