using System;
using System.Collections.Generic;

namespace Problem92
{
    public static class Problem92
    {
        public static int Solve()
        {
            const int upperBound = 10_000_000;
            int count = 0;

            for (int number = 1; number < upperBound; number++)
            {
                int chainTerminator = CreateSquareDigitSumChain(number);
                //WriteLine($"number = {number},  chainTerminator = {chainTerminator}");

                if (chainTerminator == 89)
                {
                    count++;
                }
            }
            
            return count;
        }
        public static int CreateSquareDigitSumChain(int number)
        {
            List<int> squareDigitSumList = new();
            int chainTerminator;

            while (true)
            {
                int squareDigitSum = GetSquareDigitSum(number);

                if (squareDigitSum == 1 || squareDigitSum == 89)
                {
                    chainTerminator = squareDigitSum;
                    break;
                }
                else
                {
                    squareDigitSumList.Add(squareDigitSum);
                }

                number = squareDigitSum;
            }

            return chainTerminator;
        }

        public static int GetSquareDigitSum(int number)
        {
            string numberString = number.ToString();
            List<int> digitList = ConvertNumericStringToDigitList(numberString);
            int sum = 0;
            
            foreach (int digit in digitList)
            {
                sum += digit * digit;
            }

            return sum;
        }
        
        private static List<int> ConvertNumericStringToDigitList(string numericString)
        {
            List<int> digitsList = new();

            foreach (char character in numericString)
            {
                int digit = Convert.ToInt32(character.ToString());
                digitsList.Add(digit);
            }

            return digitsList;
        }
    }
}