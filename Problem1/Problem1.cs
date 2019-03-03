using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    public static class Problem1
    {
        public static int Solve()
        {
            const int upperLimit = 1000;
            List<int> factors = new List<int>();

            for (int n = 3; n < upperLimit; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    factors.Add(n);
                }
            }

            int answer = factors.Sum();

            return answer;
        }
    }
}