namespace Problem5
{
    public static class Problem5
    {
        public static int Solve()
        {
            const int upperBound = 20;
            int number = 1;

            while (true)
            {
                if (IsNumberEvenlyDivisible(number, upperBound))
                {
                    return number;
                }

                number++;
            }
        }

        private static bool IsNumberEvenlyDivisible(int number, int upperBound)
        {
            for (int n = 1; n <= upperBound; n++)
            {
                if (number % n != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}