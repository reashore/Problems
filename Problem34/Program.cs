using static System.Console;

namespace Problem34
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 34");

            long sum = Problem34.Solve();
            WriteLine($"sum = {sum}");      // 40730
        }
    }
}
