using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem33
{
    public static class Problem33
    {
        public static long Solve()
        {
            List<Fraction> cancellingFactionsList = new();

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

                    // ReSharper disable once InvertIf
                    if (num * denominator == numerator * den)
                    {
                        Fraction fraction = new(num, den);
                        cancellingFactionsList.Add(fraction);
                        Console.WriteLine($"fraction = {num}/{den}");
                    }
                }
            }

            int answer = FindDenominatorOfProductInLowestTerms(cancellingFactionsList);

            return answer;
        }

        private static int FindDenominatorOfProductInLowestTerms(IEnumerable<Fraction> cancellingFactionsList)
        {
            int numeratorProducts = 1;
            int denominatorProducts = 1;

            foreach (Fraction fraction in cancellingFactionsList)
            {
                int fractionNum = fraction.Numerator;
                int fractionDen = fraction.Denominator;

                numeratorProducts *= fractionNum;
                denominatorProducts *= fractionDen;
            }

            List<int> numeratorPrimeFactors = Utilities.GetPrimeFactors(numeratorProducts);
            List<int> denominatorPrimeFactors = Utilities.GetPrimeFactors(denominatorProducts);
            IEnumerable<int> commonFactors = GetCommonFactors(numeratorPrimeFactors, denominatorPrimeFactors);

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

        private static IEnumerable<int> GetCommonFactors(IEnumerable<int> numeratorPrimeFactors, IEnumerable<int> denominatorPrimeFactors)
        {
            List<int> commonFactors = new();
            List<int> denominatorPrimeFactorsCopy = CopyList(denominatorPrimeFactors);

            foreach (var factor in numeratorPrimeFactors)
            {
                // ReSharper disable once InvertIf
                if (denominatorPrimeFactorsCopy.Contains(factor))
                {
                    commonFactors.Add(factor);
                    denominatorPrimeFactorsCopy.Remove(factor);
                }
            }

            return commonFactors;
        }

        private static List<int> CopyList(IEnumerable<int> originalList)
        {
            List<int> copyList = new(0);

            foreach (int item in originalList)
            {
                copyList.Add(item);
            }

            return copyList;
        }
    }
}