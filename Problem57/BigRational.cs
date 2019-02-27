using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

namespace Problem57
{
    public class BigRational
    {
        private readonly BigInteger _numerator;
        private readonly BigInteger _denominator;
        
        public BigRational(BigInteger numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        private BigRational(BigInteger numerator, BigInteger denominator)
        {
            _numerator = numerator;

            if (denominator != 0)
            {
                _denominator = denominator;
            }
            else
            {
                const string message = "Denominator cannot be zero.";
                throw new InvalidEnumArgumentException(message);
            }
        }

        public static BigRational Add(BigRational lhs, BigRational rhs)
        {
            BigRational sum = AddFast(lhs, rhs);
            BigRational reducedSum = Reduce(sum);
            
            return reducedSum;
        }

        public static BigRational AddFast(BigRational lhs, BigRational rhs)
        {
            // a/b + c/d = (a*d + b*c)/bd
            BigInteger a = lhs.Numerator;
            BigInteger b = lhs.Denominator;

            BigInteger c = rhs.Numerator;
            BigInteger d = rhs.Denominator;

            BigInteger sumNumerator = a * d + b * c;
            BigInteger sumDenominator = b * d;

            BigRational sum = new BigRational(sumNumerator, sumDenominator);
            
            return sum;
        }

        public static BigRational Divide(BigRational lhs, BigRational rhs)
        {
            BigRational quotient = DivideFast(lhs, rhs);
            BigRational reducedQuotient = Reduce(quotient);

            return reducedQuotient;
        }

        public static BigRational DivideFast(BigRational lhs, BigRational rhs)
        {
            // (a/b)/(c/d) = (a*d)/(b*c)
            BigInteger a = lhs.Numerator;
            BigInteger b = lhs.Denominator;

            BigInteger c = rhs.Numerator;
            BigInteger d = rhs.Denominator;

            BigInteger quotientNumerator = a * d;
            BigInteger quotientDenominator = b * c;
                
            BigRational quotient = new BigRational(quotientNumerator, quotientDenominator);

            return quotient;
        }

        public static BigRational Reduce(BigRational rational)
        {
            BigInteger numerator = rational.Numerator;
            BigInteger denominator = rational.Denominator;

            BigInteger gcd = GreatestCommonDivisor(numerator, denominator);

            BigInteger reducedNumerator = BigInteger.Divide(numerator, gcd);
            BigInteger reducedDenominator = BigInteger.Divide(denominator, gcd);
            
            BigRational reducedRational = new BigRational(reducedNumerator, reducedDenominator);

            return reducedRational;
        }
        
        
        private static BigInteger GreatestCommonDivisor(BigInteger number1, BigInteger number2)
        {
            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                    number1 %= number2;
                else
                    number2 %= number1;
            }

            return number1 == 0 ? number2 : number1;
        }

        private static IEnumerable<long> GetPrimeFactors(BigInteger number)
        {
            List<long> primeFactors = new List<long>();

            for (long divisor = 2; divisor <= number; divisor++)
            {
                while (number % divisor == 0)
                {
                    primeFactors.Add(divisor);
                    number = number / divisor;
                }
            }

            return primeFactors;
        }

        private static BigInteger GetProductOfListElements(IEnumerable<long> numberList)
        {
            BigInteger product = 1;

            foreach (long number in numberList)
            {
                product *= number;
            }

            return product;
        }

        public override string ToString()
        {
             return $"{_numerator}/{_denominator}";
        }

        public BigInteger Numerator => _numerator;
        public BigInteger Denominator => _denominator;
    }
}