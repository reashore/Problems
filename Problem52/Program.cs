using static System.Console;

namespace Problem52
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 52");

            ulong answer = Problem52.Solve();
            WriteLine($"answer = {answer}");    // 142857
        }
    }
}
