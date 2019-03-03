using static System.Console;

namespace Problem40
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 40");

            long answer = Problem40.Solve();
            WriteLine($"product = {answer}");      // 210
        }
    }
}
