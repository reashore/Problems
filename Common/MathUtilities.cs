using System;

namespace Common
{
    public static class MathUtilities
    {
        public static bool IsPrime(long number)
        {
            // Algorithm fails if number < 0, so take absolute value
            number = Math.Abs(number);

            if ((number & 1) == 0)
            {
                return number == 2;
            }

            for (long i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return number != 1;
        }

        public static bool IsPandigital(long number, int n = 9)
        {
            // Contains every digit from 1 to n exactly once
            string numberString = number.ToString();
            return IsPandigital(numberString, n);
        }

        public static bool IsPandigital(string numberString, int n = 9)
        {
            if (numberString.Length != n)
            {
                return false;
            }

            const string allDigits = "123456789";
            string digits = allDigits.Substring(0, n);

            foreach (char digit in digits)
            {
                if (!numberString.Contains(digit))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
