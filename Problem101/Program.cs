using static System.Console;

namespace Problem101
{
    public class Program
    {
        public static void Main()
        {
            //Problem101.Test();

            WriteLine("Problem 101");
            int n = 3;
            long answer = Problem101.Solve(n);
            WriteLine($"answer = {answer}");            // 27
        }
    }
}
