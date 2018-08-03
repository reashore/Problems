using System;
using System.Diagnostics;

namespace Problem39
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 39");

            Test();
            Console.WriteLine("Tests Done");

            int perimeterUpperBound = 1000;
            (int, int) result = Solve(perimeterUpperBound);
            int maxPerimeter = result.Item1;
            int numberTriangles = result.Item2;

            // maxPerimeter = 840, numberTriangles = 8
            Console.WriteLine($"maxPerimeter = {maxPerimeter}, numberTriangles = {numberTriangles}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            int perimeter = 120;
            int triangleCount = GetNumberIntegralTriangleWithPerimeter(perimeter);
            Debug.Assert(triangleCount == 3);
        }

        private static (int, int) Solve(int perimeterUpperBound)
        {
            int maxTriangleCount = 0;
            int maxPerimeter = 0;

            for (int perimeter = 3; perimeter <= perimeterUpperBound; perimeter++)
            {
                int triangleCount = GetNumberIntegralTriangleWithPerimeter(perimeter);

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
                    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
                }
            }

            return count;
        }
    }
}
