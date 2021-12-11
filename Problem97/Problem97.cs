using System.Numerics;

namespace Problem97
{
    public static class Problem97
    {
        public static string Solve()
        {
            BigInteger factor = 28433;
            const int exponent = 7830457;
            BigInteger power = BigInteger.Pow(2, exponent);
            BigInteger result = factor * power + 1;
            string resultString = result.ToString();
            int length = resultString.Length;
            string last10Digits = resultString.Substring(length - 10);
            //WriteLine($"resultString = {resultString}");
            
            return last10Digits;
        }
    }
}