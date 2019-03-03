using static System.Console;

namespace Problem35
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 35");

            long count = Problem35.Solve();
            WriteLine($"count = {count}");      // 55
        }
    }
}
