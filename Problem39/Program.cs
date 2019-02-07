using static Common.Utilities;
using static System.Console;

namespace Problem39
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 39");

            Test();
            WriteLine("Tests Done");

            const int perimeterUpperBound = 1000;
            (int, int) result = Solve(perimeterUpperBound);
            int maxPerimeter = result.Item1;
            int numberTriangles = result.Item2;

            // maxPerimeter = 840, numberTriangles = 8
            WriteLine($"maxPerimeter = {maxPerimeter}, numberTriangles = {numberTriangles}");

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            const int perimeter = 120;
            int triangleCount = GetNumberIntegralTriangleWithPerimeter(perimeter);
            Assert(triangleCount == 3);
        }

        private static (int, int) Solve(int perimeterUpperBound)
        {
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

            return (maxPerimeter, maxTriangleCount);
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
