using System.Collections.Generic;
using System.Linq;

namespace Problem6
{
    public static class Problem6
    {
        public static int Solve()
        {
            const int number = 100;
            IEnumerable<int> sequence = Enumerable.Range(1, number);

            // ReSharper disable once PossibleMultipleEnumeration
            int sumOfTerms = sequence.Sum(n => n);
            // ReSharper disable once PossibleMultipleEnumeration
            int sumOfTermsSquared = sequence.Sum(n => n * n);

            int difference = sumOfTerms * sumOfTerms - sumOfTermsSquared;

            return difference;
        }
    }
}