using static System.Console;

namespace Problem38
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 38");

            long answer = Problem38.Solve();
            WriteLine($"maxConcatenatedProduct = {answer}");        // 932718654
        }
    }
}

