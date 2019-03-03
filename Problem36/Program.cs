using static System.Console;

namespace Problem36
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 36");

            long sum = Problem36.Solve();
            WriteLine($"sum = {sum}");      // 872187
        }
    }
}
