using System.Collections.Generic;

namespace Problem103
{
    public class Problem103
    {
        public static int Solve(List<int> tempList)
        {
            int minTemp = int.MaxValue;

            foreach (int temp in tempList)
            {
                if (Abs(temp) < Abs(minTemp))
                {
                    minTemp = temp;
                }

                if (Abs(temp) == Abs(minTemp))
                {
                    if (temp > minTemp)
                    {
                        minTemp = temp;
                    }
                }
            }

            return minTemp;
        }

        private static int Abs(int x)
        {
            if (x < 0)
            {
                return -x;
            }

            return x;
        }
    }
}
