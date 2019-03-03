using System;
using System.Numerics;

namespace Problem63
{
    public static class Problem63
    {
        public static int Solve()
        {
            int count = 0;
            int exponent = 1;

            while (true)
            {
                var foundOne= false;
                
                for (int number = 9; 0 < number ; number--)
                {
                    BigInteger power = BigInteger.Pow(number, exponent);
                    int powerLength = power.ToString().Length;

                    if (powerLength == exponent)
                    {
                        count++;
                        foundOne = true;
                        string message = $"{number}^{exponent} = {power}";
                        Console.WriteLine(message);
                    }
                }

                if (!foundOne)
                {
                    break;
                }
                
                exponent++;
            }

            return count;
        }
    }
}