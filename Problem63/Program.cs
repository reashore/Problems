using System.Numerics;
using static System.Console;

namespace Problem63
{
    // https://www.mathblog.dk/project-euler-63-n-digit-nth-power/

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 63");

            int count = Solve();
            WriteLine($"Number powerful digits = {count}");        // 49

            WriteLine("Done");
            ReadKey();
        }

        private static int Solve()
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
                        WriteLine(message);
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
