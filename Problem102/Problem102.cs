namespace Problem102
{
    public class Problem102
    {
        public static long Solve(int n)
        {
            checked
            {
                long power = 1;

                for (int i = 1; i <= n; i++)
                {
                    power *= 2;
                    power %= 100_000;
                }

                long answer = power - 1;

                return answer;
            }
        }
    }
}
