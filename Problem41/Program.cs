using static System.Console;

namespace Problem41
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 41");

            long answer = Problem41.Solve();
            WriteLine($"maxPandigitalPrime = {answer}");    // 7652413
        }
    }
}
