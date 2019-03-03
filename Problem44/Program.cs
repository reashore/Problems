using static System.Console;

namespace Problem44
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 44");

            long answer = Problem44.Solve();
            WriteLine($"minimalDifference = {answer}");      // 5482660
        }
    }
}
