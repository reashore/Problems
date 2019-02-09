using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Problem6
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 6");

            int answer = Solve();
            WriteLine($"answer = {answer, 20}");

            WriteLine("Done");
            ReadKey();
        }

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
