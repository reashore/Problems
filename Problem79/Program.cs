using static System.Console;

namespace Problem79
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 79");

            string answer = Problem79.Solve();
            WriteLine($"answer = {answer}");        // 73162890

            WriteLine("Done");
            ReadKey();
        }

    }
}