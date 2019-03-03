using System.Collections.Generic;
using Common;

namespace Problem22
{
    public static class Problem22
    {
        public static long Solve()
        {
            const string fileName = "Names.txt";
            IEnumerable<string> namesList = Utilities.ReadCsvFile(fileName);
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