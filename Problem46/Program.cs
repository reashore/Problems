using static System.Console;

namespace Problem46
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("problem 46");

            long answer = Problem46.Solve();

            if (answer > 0)
            {
                WriteLine($"Goldbach's conjecture failed for {answer}");
            }
        }
    }
}
