using System.Collections.Generic;
using System.ComponentModel;

namespace Problem57
{
    public class Rational
    {
        private readonly long _numerator;
        private readonly long _denominator;
        
        public Rational(long numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        public Rational(long numerator, long denominator)
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

        public static Rational Add(Rational lhs, Rational rhs)
        {
            Rational sum = AddFast(lhs, rhs);
            Rational reducedSum = Reduce(sum);
            
            return reducedSum;
        }

        public static Rational AddFast(Rational lhs, Rational rhs)
        {
            // a/b + c/d = (a*d + b*c)/bd
            long a = lhs.Numerator;
            long b = lhs.Denominator;

            long c = rhs.Numerator;
            long d = rhs.Denominator;

            long sumNumerator = a * d + b * c;
            long sumDenominator = b * d;

            Rational sum = new Rational(sumNumerator, sumDenominator);
            
            return sum;
        }

        public static Rational Divide(Rational lhs, Rational rhs)
        {
            Rational quotient = DivideFast(lhs, rhs);
            Rational reducedQuotient = Reduce(quotient);

            return reducedQuotient;
        }

        public static Rational DivideFast(Rational lhs, Rational rhs)
        {
            // (a/b)/(c/d) = (a*d)/(b*c)
            long a = lhs.Numerator;
            long b = lhs.Denominator;

            long c = rhs.Numerator;
            long d = rhs.Denominator;

            long quotientNumerator = a * d;
            long quotientDenominator = b * c;
                
            Rational quotient = new Rational(quotientNumerator, quotientDenominator);

            return quotient;
        }

        public static Rational Reduce(Rational rational)
        {
            long numerator = rational.Numerator;
            long denominator = rational.Denominator;

            long gcd = GreatestCommonDivisor(numerator, denominator);

            long reducedNumerator = numerator / gcd;
            long reducedDenominator = denominator / gcd;
            
            Rational reducedRational = new Rational(reducedNumerator, reducedDenominator);

            return reducedRational;
        }
        
        private static long GreatestCommonDivisor(long number1, long number2)
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


        private static long GetProductOfListElements(IEnumerable<long> numberList)
        {
            long product = 1;

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

        public double ToDouble()
        {
            double rationalDouble = _numerator / (double) _denominator;
            return rationalDouble;
        }

        public long Numerator => _numerator;
        public long Denominator => _denominator;
    }
}