using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem33
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 33");

            long result = Solve();
            Console.WriteLine($"result = {result}");    // 100

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static long Solve()
        {
            List<Tuple<int, int>> cancellingFactionsList = new List<Tuple<int, int>>();

            for (int num = 10; num < 100; num++)
            {
                for (int den = 10; den < 100; den++)
                {
                    if (den <= num)
                    {
                        continue;
                    }

                    List<int> numDigits = Utilities.ConvertNumericStringToList(num.ToString());
                    List<int> denDigits = Utilities.ConvertNumericStringToList(den.ToString());

                    // ignore trivial cases like 30/50 = 3/5
                    if (numDigits[1] == 0 && denDigits[1] == 0)
                    {
                        continue;
                    }

                    // find common digit
                    List<int> commonDigitsList = numDigits.Intersect(denDigits).ToList();
                    int numberCommonDigits = commonDigitsList.Count;

                    // if there are no digits in common then continue
                    if (numberCommonDigits == 0)
                    {
                        continue;
                    }

                    int commonDigit = commonDigitsList[0];

                    // remove common digit from lists
                    numDigits.Remove(commonDigit);
                    denDigits.Remove(commonDigit);

                    int numerator = numDigits[0];
                    int denominator = denDigits[0];

                    // num/den = numerator/denominator

                    if (num * denominator == numerator * den)
                    {
                        Tuple<int, int> fraction = Tuple.Create(num, den);
                        cancellingFactionsList.Add(fraction);
                        Console.WriteLine($"fraction = {num}/{den}");
                    }
                }
            }

            int answer = FindDenominatorOfProductInLowestTerms(cancellingFactionsList);

            return answer;
        }

        // ReSharper disable once ParameterTypeCanBeEnumerable.Local
        private static int FindDenominatorOfProductInLowestTerms(List<Tuple<int, int>> cancellingFactionsList)
        {
            int numeratorProducts = 1;
            int denominatorProducts = 1;

            foreach (Tuple<int, int> fraction in cancellingFactionsList)
            {
                int fractionNum = fraction.Item1;
                int fractionDen = fraction.Item2;

                numeratorProducts *= fractionNum;
                denominatorProducts *= fractionDen;
            }

            List<int> numeratorPrimeFactors = Utilities.GetPrimeFactors(numeratorProducts);
            List<int> denominatorPrimeFactors = Utilities.GetPrimeFactors(denominatorProducts);
            List<int> commonFactors = GetCommonFactors(numeratorPrimeFactors, denominatorPrimeFactors);

            foreach (int factor in commonFactors)
            {
                denominatorPrimeFactors.Remove(factor);
            }

            int productOfDenominatorFactors = 1;

            foreach (int factor in denominatorPrimeFactors)
            {
                productOfDenominatorFactors *= factor;
            }

            return productOfDenominatorFactors;
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once ParameterTypeCanBeEnumerable.Local
        private static List<int> GetCommonFactors(List<int> numeratorPrimeFactors, List<int> denominatorPrimeFactors)
        {
            List<int> commonFactors = new List<int>();
            List<int> denominatorPrimeFactorsCopy = CopyList(denominatorPrimeFactors);

            foreach (var factor in numeratorPrimeFactors)
            {
                if (denominatorPrimeFactorsCopy.Contains(factor))
                {
                    commonFactors.Add(factor);
                    denominatorPrimeFactorsCopy.Remove(factor);
                }
            }

            return commonFactors;
        }

        // ReSharper disable once ParameterTypeCanBeEnumerable.Local
        private static List<int> CopyList(List<int> originalList)
        {
            List<int> copyList = new List<int>(0);

            foreach (int item in originalList)
            {
                copyList.Add(item);
            }

            return copyList;
        }
    }
}
