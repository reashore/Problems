using static System.Console;

namespace Problem100
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 100");

            WriteLine(int.MaxValue);                    // 2147483647
                                                        // 5000000058

            int row = 6;
            int col = 3;
            long answer = Problem100.Solve(row, col);
            WriteLine($"answer = {answer}");            // 25

            row = 1000000011;
            col = 5;
            answer = Problem100.Solve(row, col);
            WriteLine($"answer = {answer}");            // 5000000058

            //Problem100.Test();
        }
    }
}
