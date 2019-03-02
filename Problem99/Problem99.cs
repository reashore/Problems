using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace Problem99
{
    public static class Problem99
    {
        public static int Solve()
        {
            List<BaseExponentPair> baseExponentList = ReadBaseExponentPairs();
            BigInteger maximumNumber = 0;
            int lineNumber = 1;
            int lineNumberOfMaximumNumber = 0;

            foreach (BaseExponentPair baseExponentPair in baseExponentList)
            {
                Console.WriteLine($"lineNumber = {lineNumber}");

                int numberBase = baseExponentPair.Base;
                int numberExponent = baseExponentPair.Exponent;
                BigInteger numberPower = BigInteger.Pow(numberBase, numberExponent);

                if (numberPower > maximumNumber)
                {
                    maximumNumber = numberPower;
                    lineNumberOfMaximumNumber = lineNumber;
                    Console.WriteLine($"lineNumberOfMaximumNumber = {lineNumberOfMaximumNumber}");
                }

                lineNumber++;
            }

            return lineNumberOfMaximumNumber;
        }

        private static List<BaseExponentPair> ReadBaseExponentPairs()
        {
            const string fileName = "BaseExponents.txt";
            string[] baseExponentLines = File.ReadAllLines(fileName);
            List<BaseExponentPair> baseExponentList = new List<BaseExponentPair>();

            foreach (string line in baseExponentLines)
            {
                string[] lineArray = line.Split(',');
                BaseExponentPair baseExponentPair = new BaseExponentPair
                {
                    Base = Convert.ToInt32(lineArray[0]),
                    Exponent = Convert.ToInt32(lineArray[1])
                };

                baseExponentList.Add(baseExponentPair);
            }

            return baseExponentList;
        }

        private class BaseExponentPair
        {
            public int Base { get; set; }
            public int Exponent { get; set; }
        }
    }
}