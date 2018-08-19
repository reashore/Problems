using System;

namespace Problem28
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 28");

            const int size = 1001;
            long sumBothDiagonals = Solve(size);
            Console.WriteLine($"sumBothDiagonals = {sumBothDiagonals}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static long Solve(int size)
        {
            int[,] matrix = new int[size, size];

            matrix = CreateMatrixSpiral(size, matrix);
            //PrintMatrix(size, matrix);
            long sumBothDiagonals = SumBothDiagonals(size, matrix);

            return sumBothDiagonals;
        }

        private static int[,] CreateMatrixSpiral(int size, int[,] matrix)
        {
            if (size % 2 == 0)
            {
                throw new ArgumentException("Matrix size must be odd");
            }

            int middle = (size - 1) / 2;
            int nextValue = 1;
            matrix[middle, middle] = nextValue++;

            // boxSize, iterations
            // 3, 2
            // 5, 4
            // 7, 6
            // boxSize => boxSize - 1

            for (int boxSize = 3; boxSize <= size; boxSize += 2)
            {
                // boxSize, rowOffset
                // 3, 0
                // 5, -1
                // 7, -2
                // boxSize => -boxSize / 2 + 1

                // boxSize, colOffset
                // 3, 1
                // 5, 2
                // 7, 3
                // boxSize = boxSize / 2

                int numIterations = boxSize - 1;

                // top -> bottom
                for (int n = 0; n < numIterations; n++)
                {
                    int rowOffset = -boxSize / 2 + 1;
                    int colOffset = boxSize / 2;

                    int row = middle + rowOffset + n;
                    int col = middle + colOffset;

                    matrix[row, col] = nextValue++;
                }

                // boxSize, rowOffset
                // 3, -1
                // 5, -2
                // 7, -3
                // boxSize => -boxSize / 2

                // boxSize, colOffset
                // 3, 0
                // 5, 1
                // 7, 2
                // 9, 3
                // boxSize -> boxSize / 2 - 1

                // right -> left
                for (int n = 0; n < numIterations; n++)
                {
                    int rowOffset = boxSize / 2;
                    int colOffset = boxSize / 2 - 1;

                    int row = middle + rowOffset;
                    int col = middle + colOffset - n;

                    matrix[row, col] = nextValue++;
                }

                // boxSize, rowOffset
                // 3, 0
                // 5, 1
                // 7, 2
                // 9, 3
                // boxSize => boxSize / 2 - 1

                // boxSize, colOffset
                // 3, -1
                // 5, -2
                // 7, -3
                // boxSize => -boxSize / 2

                // bottom -> top
                for (int n = 0; n < numIterations; n++)
                {
                    int rowOffset = boxSize / 2 - 1;
                    int colOffset = -boxSize / 2;

                    int row = middle + rowOffset - n;
                    int col = middle + colOffset;

                    matrix[row, col] = nextValue++;
                }

                // boxSize, rowOffset
                // 3, -1
                // 5, -2
                // 7, -3
                // boxSize => -boxSize / 2

                // boxSize, colOffset
                // 3, 0
                // 5, -1
                // 7, -2
                // boxSize => -boxSize / 2 + 1

                // left -> right
                for (int n = 0; n < numIterations; n++)
                {
                    int rowOffset = -boxSize / 2;
                    int colOffset = -boxSize / 2 + 1;

                    int row = middle + rowOffset;
                    int col = middle + colOffset + n;

                    matrix[row, col] = nextValue++;
                }
            }

            return matrix;
        }

        private static long SumBothDiagonals(int size, int[,] matrix)
        {
            long sumDiagonal1 = SumDiagonal1(size, matrix);
            long sumDiagonal2 = SumDiagonal2(size, matrix);
            long sumBothDiagonals = sumDiagonal1 + sumDiagonal2 - 1;

            return sumBothDiagonals;
        }

        private static long SumDiagonal1(int size, int[,] matrix)
        {
            long sum = 0;

            for (int row = 0; row < size; row++)
            {
                sum += matrix[row, row];
            }

            return sum;
        }

        private static long SumDiagonal2(int size, int[,] matrix)
        {
            long sum = 0;

            for (int n = 0; n < size; n++)
            {
                 sum += matrix[n, size - 1 - n];
            }

            return sum;
        }
    }
}
