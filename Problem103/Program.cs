using System.Collections.Generic;
using static System.Console;

namespace Problem103
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 103");
            List<int> tempList = new List<int>()
            {
                4, -2, 6, 2, -2, -4, 3
            };
            long answer = Problem103.Solve(tempList);
            WriteLine($"answer = {answer}");            // 2
        }
    }
}

