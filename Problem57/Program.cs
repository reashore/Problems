using System.Numerics;
using static System.Console;

namespace Problem57
{
    public static class Program
    {
        public static void Main()
        {
            WriteLine("Problem 57");

            int answer = Solve();
            WriteLine($"answer = {answer}");            // 153
            
            WriteLine("Done");
            ReadKey();
        }
        
        public static int Solve()
        {
            const int maxIterations = 1000;
            BigRational two = new BigRational(2);
            BigRational start = two;
            int count = 0;

            int iteration = 1;
            BigRational iteratedSquareRoot = CalculateOuterExpression(two);
            WriteLine($"Iteration = {iteration, 5}, {iteratedSquareRoot}");

            for (iteration = 2; iteration <= maxIterations; iteration++)
            {
                BigRational end = CalculateInnerExpressionFast(start);
                iteratedSquareRoot = CalculateOuterExpressionFast(end);
                iteratedSquareRoot = BigRational.Reduce(iteratedSquareRoot);
                start = end;
                WriteLine($"Iteration = {iteration, 5}, {iteratedSquareRoot}");
                
                BigInteger numerator = iteratedSquareRoot.Numerator;
                BigInteger denominator = iteratedSquareRoot.Denominator;

                string numeratorString = numerator.ToString();
                string denominatorString = denominator.ToString();

                if (numeratorString.Length > denominatorString.Length)
                {
                    count++;
                    WriteLine($"count = {count}");
                }
            }

            return count;
        }

        public static BigRational CalculateInnerExpression(BigRational rational)
        {
            BigRational expression = CalculateInnerExpressionFast(rational);
            BigRational reducedExpression = BigRational.Reduce(expression);
            
            return reducedExpression;
        }

        public static BigRational CalculateOuterExpression(BigRational rational)
        {
            BigRational expression = CalculateOuterExpressionFast(rational);
            BigRational reducedExpression = BigRational.Reduce(expression);

            return reducedExpression;
        }

        private static BigRational CalculateInnerExpressionFast(BigRational rational)
        {
            BigRational one = new BigRational(1);
            BigRational two = new BigRational(2);

            BigRational expression1 = BigRational.DivideFast(one, rational);
            BigRational expression2 = BigRational.AddFast(two, expression1);
           
            return expression2;
        }

        private static BigRational CalculateOuterExpressionFast(BigRational rational)
        {
            BigRational one = new BigRational(1);

            BigRational expression1 = BigRational.DivideFast(one, rational);
            BigRational expression2 = BigRational.AddFast(one, expression1);

            return expression2;
        }
    }
}













