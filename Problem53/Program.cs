using System.Numerics;
using static System.Console;

namespace Problem53
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 53");
            int answer = Problem53.Solve();
            WriteLine($"answer = {answer}");
        }
    }

    public static class Problem53
    {
        public static int Solve()
        {
            const int upperBound = 100;
            
            for (int n = 1; n <= upperBound; n++)
            {
                for (int r = 1; r <= n; r++)
                {
                    BigInteger combinator = GetCombinatoric(n, r);
                }
                
            }

            return 0;
        }

        private static BigInteger GetCombinatoric(int n, int r)
        {
            
            return new BigInteger(0);
        }
        
        private static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
        
        private static BigInteger Factorial2(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i < n; i++)
            {
                BigInteger value = new BigInteger(i);
                factorial *= value;
            }

            return factorial;
        }

    }
}