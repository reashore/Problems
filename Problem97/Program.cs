using System.Numerics;
using static System.Console;

namespace Problem97
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 97");

            string answer = Solve();
            WriteLine($"answer = {answer}");            // 8739992577
            
            WriteLine("Done");
        }

        public static string Solve()
        {
            BigInteger factor = 28433;
            const int exponent = 7830457;
            BigInteger power = BigInteger.Pow(2, exponent);
            BigInteger result = factor * power + 1;
            string resultString = result.ToString();
            int length = resultString.Length;
            string last10Digits = resultString.Substring(length -10);
            //WriteLine($"resultString = {resultString}");
            
            return last10Digits;
        }
    }
}