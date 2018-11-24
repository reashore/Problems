using System.Collections.Generic;
using static System.Console;
using static Common.Utilities;

namespace Problem22
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            WriteLine("Problem 22");

            const string fileName = "Names.txt";
            IEnumerable<string> namesList = ReadCsvFile(fileName);
            long sumNamesScores = Solve(namesList);

            WriteLine($"sumNamesScores = {sumNamesScores}");

            WriteLine("Done");
            ReadKey();
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
