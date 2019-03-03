using static System.Console;

namespace Problem59
{
    public static class Program
    {
        public static void Main()
        {
            WriteLine("Problem 59");

            var (item1, item2) = Problem59.Solve();
            WriteLine($"answer = {item1}");        // 107359
            WriteLine(item2);
        }
    }
}
