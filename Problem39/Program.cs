using static System.Console;

namespace Problem39
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 39");

            int answer = Solve();

            WriteLine($"maxPerimeter = {answer}");        // 840

            WriteLine("Done");
            ReadKey();
        }

        public static int Solve()
        {
            const int perimeterUpperBound = 1000;
            int maxTriangleCount = 0;
            int maxPerimeter = 0;

            for (int perimeter = 3; perimeter <= perimeterUpperBound; perimeter++)
            {
                int triangleCount = GetNumberIntegralTriangleWithPerimeter(perimeter);

                // ReSharper disable once InvertIf
                if (triangleCount > maxTriangleCount)
                {
                    maxTriangleCount = triangleCount;
                    maxPerimeter = perimeter;
                }
            }

            return maxPerimeter;
        }

        private static int GetNumberIntegralTriangleWithPerimeter(int perimeter)
        {
            int upperBound = perimeter + 1;
            int count = 0;

            for (int a = 1; a < upperBound; a++)
            {
                for (int b = 1; b < upperBound; b++)
                {
                    if (a < b)
                    {
                        continue;
                    }

                    int c = perimeter - a - b;

                    if (c <= 0)
                    {
                        continue;
                    }

                    if (a * a + b * b != c * c)
                    {
                        continue;
                    }

                    count++;
                    WriteLine($"a = {a}, b = {b}, c = {c}");
                }
            }

            return count;
        }
    }
}
