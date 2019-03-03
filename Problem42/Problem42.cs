using System.Collections.Generic;
using Common;

namespace Problem42
{
    public static class Problem42
    {
        public static long Solve()
        {
            const string fileName = "Words.txt";
            IEnumerable<string> words = Utilities.ReadCsvFile(fileName);
            long numberTriangularWords = 0;

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (string word in words)
            {
                int wordValue = GetAlphabeticalValue(word);
                bool isTriangular = IsTriangularNumber(wordValue);

                if (isTriangular)
                {
                    numberTriangularWords++;
                }
            }

            return numberTriangularWords;
        }

        private static long GetTriangleNumber(long number)
        {
            long triangleNumber = number * (number + 1) / 2;

            return triangleNumber;
        }

        private static bool IsTriangularNumber(long number)
        {
            long n = 1;

            while (true)
            {
                long triangularNumber = GetTriangleNumber(n);

                if (number == triangularNumber)
                {
                    return true;
                }

                if (triangularNumber > number)
                {
                    break;
                }

                n++;
            }

            return false;
        }

        private static int GetAlphabeticalValue(string name)
        {
            int alphabeticalvalue = 0;
            name = name.ToUpper();

            foreach (char character in name)
            {
                int value = character - 'A' + 1;
                alphabeticalvalue += value;
            }

            return alphabeticalvalue;
        }
    }
}