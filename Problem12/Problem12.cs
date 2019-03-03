namespace Problem12
{
    public static class Problem12
    {
        public static long Solve()
        {
            const int maxDivisors = 500;
            var triangleNumber = GetTriangleNumberWithDivisors(maxDivisors);
            return triangleNumber;

        }

        private static long GetTriangleNumberWithDivisors(long maxDivisors)
        {
            long number = 1;
            long triangleNumber;

            while (true)
            {
                long divisorCount;
                checked
                {
                    triangleNumber = GetTriangleNumber(number);
                    divisorCount = GetDivisorsCount(triangleNumber);
                }

                if (maxDivisors < divisorCount)
                {
                    break;
                }

                number++;
            }

            return triangleNumber;
        }

        private static long GetTriangleNumber(long number)
        {
            long sum = 0;

            for (long n = 1; n <= number; n++)
            {
                sum += n;
            }

            return sum;
        }

        private static long GetDivisorsCount(long number)
        {
            long divisorsCount = 0;

            for (long n = 1; n <= number; n++)
            {
                if (number % n == 0)
                {
                    divisorsCount++;
                }
            }

            return divisorsCount;
        }
    }
}