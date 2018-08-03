using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Problem42
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 42");

            Test();
            Console.WriteLine("Tests done");

            const string fileName = "Words.txt";
            List<string> words = ReadWordsFromFile(fileName);
            long numberTriangularWords = Solve(words);
            Console.WriteLine($"numberTriangularWords = {numberTriangularWords}");      // 162

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            const string word = "SKY";
            int value = GetAlphabeticalValue(word);
            Debug.Assert(value == 55);

            for (int n = 1; n < 1000; n++)
            {
                long triangularNumber = GetTriangleNumber(n);
                bool isTriangularNumber = IsTriangularNumber(triangularNumber);

                Debug.Assert(isTriangularNumber);
            }
        }

        private static List<string> ReadWordsFromFile(string fileName)
        {
            string wordsString = File.ReadAllText(fileName);
            wordsString = wordsString.Replace("\"", "");

            List<string> wordsArray = wordsString.Split(new[] { ',' }).ToList();
            List<string> sortedWordsList = wordsArray.OrderBy(n => n).ToList();

            return sortedWordsList;
        }

        private static long Solve(IEnumerable<string> words)
        {
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
