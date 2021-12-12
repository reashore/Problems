using static System.Console;

namespace Problem102
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 102");
            int n = 2;
            long answer = Problem102.Solve(n);
            WriteLine($"answer = {answer}");            // 3

            n = 3;
            answer = Problem102.Solve(n);
            WriteLine($"answer = {answer}");            // 7

            n = 663;
            answer = Problem102.Solve(n);
            WriteLine($"answer = {answer}");            // 4447
        }
    }
}
