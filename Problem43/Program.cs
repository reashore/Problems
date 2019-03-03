using static System.Console;

namespace Problem43
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 43");

            long sum = Problem43.Solve();
            WriteLine($" sum = {sum}");     // 16695334890
        }
    }
}
