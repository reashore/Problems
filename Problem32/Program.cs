using static System.Console;

namespace Problem32
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 32");

            long answer = Problem32.Solve();
            WriteLine($"productSum = {answer}");    // 45228
        }
    }
}
