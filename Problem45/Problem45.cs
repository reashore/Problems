using System;

namespace Problem45
{
    public static class Problem45
    {
        public static long Solve()
        {
            const int upperBound = 100000;
            long specialTriangularNumber = 0;

            for (int n = 1; n <= upperBound; n++)
            {
                long triangularNumber = GetTriangularNumber(n);

                for (int m = 1; m <= upperBound; m++)
                {
                    long pentagonalNumber = GetPentagonalNumber(m);

                    if (pentagonalNumber == triangularNumber)
                    {
                        for (int p = 1; p <= upperBound; p++)
                        {
                            long hexagonalNumber = GetHexagonalNumber(p);

                            if (triangularNumber == hexagonalNumber)
                            {
                                if (triangularNumber > specialTriangularNumber)
                                {
                                    specialTriangularNumber = triangularNumber;
                                }

                                Console.WriteLine($"({n, 5}, {m, 5}, {p, 5}) = {specialTriangularNumber}");
                            }
                            else if (hexagonalNumber > triangularNumber)
                            {
                                break;
                            }
                        }
                    }
                    else if (pentagonalNumber > triangularNumber)
                    {
                        break;
                    }
                }
            }

            return specialTriangularNumber;
        }

        // https://en.wikipedia.org/wiki/Polygonal_number

        private static long GetTriangularNumber(long number) => number * (number + 1) / 2;

        private static long GetPentagonalNumber(long number) => number * (3 * number - 1) / 2;

        private static long GetHexagonalNumber(long number) => number * (2 * number - 1);
    }
}