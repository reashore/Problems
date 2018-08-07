using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem22
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 22");

            const string fileName = "Names.txt";
            List<string> namesList = ReadNamesFromFile(fileName);
            long sumNamesScores = Solve(namesList);

            Console.WriteLine($"sumNamesScores = {sumNamesScores}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        private static List<string> ReadNamesFromFile(string fileName)
        {
            string namesString = File.ReadAllText(fileName);
            namesString = namesString.Replace("\"", "");

            List<string> namesArray = namesString.Split(new[] { ',' }).ToList();
            List<string> sortedNamesList = namesArray.OrderBy(n => n).ToList();

            return sortedNamesList;
        }

        private static long Solve(IEnumerable<string> namesList)
        {
            long scoreSum = 0;
            int rank = 1;

            foreach (string name in namesList)
            {
                int alphabeticalValue = GetAlphabeticalValue(name);
                long score = alphabeticalValue * rank;
                scoreSum += score;
                rank++;
            }

            return scoreSum;
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
