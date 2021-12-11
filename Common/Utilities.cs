using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Console;

namespace Common
{
    public static class Utilities
    {
        public static void Assert(bool condition, string failureMessage = "Assertion failed")
        {
            if (!condition)
            {
                WriteLine(failureMessage);
            }
        }

        public static (T2, TimeSpan) TimeFunction<T1, T2>(Func<T1, T2> functionToTime, T1 value)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            T2 result = functionToTime(value);
            TimeSpan timeSpan = stopwatch.Elapsed;

            return (result, timeSpan);
        }

        // ReSharper disable once UnusedMember.Global
        public static (T, TimeSpan) TimeFunction<T>(Func<T> functionToTime)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            T result = functionToTime();
            TimeSpan timeSpan = stopwatch.Elapsed;

            return (result, timeSpan);
        }

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

        public static bool IsPalindrome(string value)
        {
            for (int left = 0, right = value.Length - 1; left <= right; left++, right--)
            {
                int leftChar = value[left];
                int rightChar = value[right];

                if (leftChar != rightChar)
                {
                    return false;
                }
            }

            return true;
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
            string digits = allDigits[..n];

            foreach (char digit in digits)
            {
                if (!numberString.Contains(digit))
                {
                    return false;
                }
            }

            return true;
        }

        public static IEnumerable<long> GetPrimeFactors(long number)
        {
            List<long> primeFactors = new();

            for (long divisor = 2; divisor <= number; divisor++)
            {
                while (number % divisor == 0)
                {
                    primeFactors.Add(divisor);
                    number /= divisor;
                }
            }

            return primeFactors;
        }

        public static List<int> GetPrimeFactors(int number)
        {
            List<int> primeFactors = new();

            for (int divisor = 2; divisor <= number; divisor++)
            {
                while (number % divisor == 0)
                {
                    primeFactors.Add(divisor);
                    number /= divisor;
                }
            }

            return primeFactors;
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        public static List<int> ConvertNumericStringToList(string numericString)
        {
            List<int> digitsList = new();

            foreach (char character in numericString)
            {
                int digit = Convert.ToInt32(character.ToString());
                digitsList.Add(digit);
            }

            return digitsList;
        }

        public static string ConvertListToString(IEnumerable<int> list)
        {
            string result = "";

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (int n in list)
            {
                result += n.ToString();
            }

            return result;
        }

        public static string ConvertListToStringFast(IEnumerable<int> list)
        {
            StringBuilder stringBuilder = new();

            foreach (int n in list)
            {
                stringBuilder.Append(n);
            }

            return stringBuilder.ToString();
        }

        // ReSharper disable once UnusedMember.Local
        public static void InitializeMatrixToZeros(int size, int[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = 0;
                }
            }
        }

        // ReSharper disable once UnusedMember.Local
        public static void PrintMatrix(int size, int[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                string matrixRow = "";

                for (int col = 0; col < size; col++)
                {
                    matrixRow += $"{matrix[row, col],4}, ";
                }

                WriteLine(matrixRow);
            }

            WriteLine();
        }

        public static void PrintList<T>(IEnumerable<T> list)
        {
            string line = "";

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (T item in list)
            {
                line += $"{item}, ";
            }

            WriteLine(line);
        }

        public static IEnumerable<string> ReadCsvFile(string fileName)
        {
            string wordsString = File.ReadAllText(fileName);
            wordsString = wordsString.Replace("\"", "");

            List<string> wordsArray = wordsString.Split(new[] { ',' }).ToList();
            List<string> sortedWordsList = wordsArray.OrderBy(n => n).ToList();

            return sortedWordsList;
        }

        public static string Reverse(string valueString)
        {
            string reversedValueString = "";
            int length = valueString.Length;

            for (int n = length - 1; n >= 0; n--)
            {
                reversedValueString += valueString[n];
            }

            return reversedValueString;
        }
        
        public static BigInteger Fibonacci(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("Argument cannot be negative");
            }

            if (n == 1 || n == 2)
            {
                return new(1);
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
