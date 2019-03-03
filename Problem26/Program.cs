using static System.Console;

namespace Problem26
{
    // https://www.mathblog.dk/project-euler-26-find-the-value-of-d-1000-for-which-1d-contains-the-longest-recurring-cycle/

    // https://www.xarg.org/puzzle/project-euler/problem-26/

    // https://eli.thegreenplace.net/2009/02/25/project-euler-problem-26

    // https://codeshelter.wordpress.com/2011/01/19/project-euler-26/

    // http://thecprojectt.blogspot.com/2014/10/reciprocal-cycles-problem-26-project.html

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 26");

            //Test();

            var (maxDenominator, maxDigitStringLength, maxDigitString) = Problem26.Solve();

            WriteLine($"maxDenominator = {maxDenominator}, maxDigitStringLength = {maxDigitStringLength}, maxDigitString = {maxDigitString}");
        }
    }
}
