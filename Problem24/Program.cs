using static System.Console;

namespace Problem24
{
    // https://stackoverflow.com/questions/2710713/algorithm-to-generate-all-possible-permutations-of-a-list

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 24");

            string answer = Problem24.Solve();
            WriteLine($"millionthPermutationString = {answer}");      // 2783915460
        }
    }
}
