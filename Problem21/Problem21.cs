using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem21
{
    public static class Problem21
    {
        public static int Solve()
        {
            const int upperBound = 10000;
            IEnumerable<int> amicableNumbers = GetAmicableNumbers(upperBound);
            int sumOfAmicableNumbers = amicableNumbers.Sum(n => n);
            return sumOfAmicableNumbers;
        }

        private static IEnumerable<int> GetAmicableNumbers(int upperBound)
        {
            List<int> amicableNumbers = new();

            for (int n = 1; n < upperBound; n++)
            {
                bool isAmicableNumber = IsAmicableNumber(n);

                // ReSharper disable once InvertIf
                if (isAmicableNumber)
                {
                    amicableNumbers.Add(n);
                    Console.WriteLine($"IsAmicableNumber({n}) = true, partner = {GetAmicableNumberPartner(n)}");
                }
            }

            return amicableNumbers;
        }

        private static IEnumerable<int> GetProperDivisors(int number)
        {
            List<int> divisors = new();

            for (int n = 1; n < number; n++)
            {
                if (number % n == 0)
                {
                    divisors.Add(n);
                }
            }

            return divisors;
        }

        private static int SumOfProperDivisors(int number)
        {
            IEnumerable<int> properDivisors = GetProperDivisors(number);
            int sumOfProperDivisors = properDivisors.Sum(n => n);

            return sumOfProperDivisors;
        }

        private static bool IsAmicableNumber(int number)
        {
            int sumOfProperDivisors1 = SumOfProperDivisors(number);
            int sumOfProperDivisors2 = SumOfProperDivisors(sumOfProperDivisors1);

            if (number == sumOfProperDivisors1)
            {
                return false;
            }

            return number == sumOfProperDivisors2;
        }

        private static int GetAmicableNumberPartner(int amicableNumber)
        {
            if (!IsAmicableNumber(amicableNumber))
            {
                throw new ArgumentException(" not an amicable number");
            }

            return SumOfProperDivisors(amicableNumber);
        }
    }
}