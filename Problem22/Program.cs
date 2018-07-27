using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Problem22
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 22");

            List<string> namesList = ReadNamesFromFile();
            BigInteger sumNamesScores = Solve(namesList);
            Console.WriteLine($"sumNamesScores = {sumNamesScores.ToString()}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static List<string> ReadNamesFromFile()
        {
            const string namesFile = "Names.txt";
            string namesString = File.ReadAllText(namesFile);
            int length = namesString.Length;
            namesString = namesString.Replace("\"", "");
            length = namesString.Length;
            string[] namesArray = namesString.Split(new char[] { ',' });
            List<string> namesList = namesArray.ToList();
            List<string> sortedNamesList = namesList.OrderBy(n => n).ToList();

            return sortedNamesList;
        }

        private static BigInteger Solve(List<string> namesList)
        {
            BigInteger scoreSum = 0;
            int rank = 1;

            foreach (string name in namesList)
            {
                int alphabeticalValue = GetAlphabeticalValue(name);
                BigInteger score = alphabeticalValue * rank;
                scoreSum += score;

                if (name == "COLIN")
                {
                    Console.WriteLine($"name = {name}, rank = {rank}, alphabeticalValue = {alphabeticalValue}, score = {score}, scoreSum = {scoreSum}");
                }

                //Console.WriteLine($"name = {name}, rank = {rank}, alphabeticalValue = {alphabeticalValue}, score = {score}, scoreSum = {scoreSum}");
                rank++;
            }

            return scoreSum;
        }

        private static int GetAlphabeticalValue(string name)
        {
            int alphabeticalvalue = 0;
            name = "Colin";
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
