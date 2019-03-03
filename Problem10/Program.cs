using static System.Console;

namespace Problem10
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 10");

            long answer = Problem10.Solve();
            WriteLine($"sumAllPrimes = {answer}");
        }
    }
}
