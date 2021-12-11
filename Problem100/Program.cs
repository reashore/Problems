using static System.Console;

namespace Problem100
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 100");
            int row = 6;
            int col = 3;
            int answer = Problem100.Solve(row, col);
            WriteLine($"answer = {answer}");            // 25

            //Problem100.TestRowPair();
            //Problem100.Test();
        }
    }
}
