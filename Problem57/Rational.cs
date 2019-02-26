using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Common;

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
            // a/b + c/d = (a*d + b*c)/bd
            long a = lhs.Numerator;
            long b = lhs.Denominator;

            long c = rhs.Numerator;
            long d = rhs.Denominator;

            long sumNumerator = a * d + b * c;
            long sumDenominator = b * d; 
            
            return new Rational(sumNumerator, sumDenominator);
        }

        public static Rational Divide(Rational lhs, Rational rhs)
        {
            // (a/b)/(c/d) = (a*d)/(b*c)
            long a = lhs.Numerator;
            long b = lhs.Denominator;

            long c = rhs.Numerator;
            long d = rhs.Denominator;

            long quotientNumerator = a * d;
            long quotientDenominator = b * c;
                
            return new Rational(quotientNumerator, quotientDenominator);
        }

        public static Rational Reduce(Rational rational)
        {
            long numerator = rational.Numerator;
            long denominator = rational.Denominator;

            List<long> primeFactorsOfNumeratorList = Utilities.GetPrimeFactors(numerator).ToList();
            List<long> primeFactorsOfDenominatorList = Utilities.GetPrimeFactors(denominator).ToList();

            List<long> commonPrimeFactors = primeFactorsOfNumeratorList.Intersect(primeFactorsOfDenominatorList).ToList();

            List<long> simplifiedNumeratorList = primeFactorsOfNumeratorList.Except(commonPrimeFactors).ToList();
            List<long> simplifiedDenominatorList = primeFactorsOfDenominatorList.Except(commonPrimeFactors).ToList();

            long simplifiedNumerator = GetProductOfListElements(simplifiedNumeratorList);
            long simplifiedDenominator = GetProductOfListElements(simplifiedDenominatorList);

            return new Rational(simplifiedNumerator, simplifiedDenominator);
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

        public long Numerator => _numerator;
        public long Denominator => _denominator;
    }
}