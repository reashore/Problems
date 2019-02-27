using System.Numerics;
using NUnit.Framework;

namespace Problem57.Tests
{
    public class BigRationalTests
    {
        [Test]
        public void ReduceBigRationalNumberTest()
        {
            // Arrange
            const long a = 2 * 3 * 5 * 7;
            const long b = 5 * 7 * 11 * 13;
            BigRational rational = new BigRational(a, b);
            
            BigInteger expectedNumerator = 6;
            BigInteger expectedDenominator = 143;
            
            // Act
            BigRational reducedRational = BigRational.Reduce(rational);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(reducedRational.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(reducedRational.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
        
        [Test]
        public void ReduceIrreducableBigRationalNumberTest()
        {
            // Arrange
            const long a = 12;
            const long b = 5 ;
            BigRational rational = new BigRational(a, b);
            
            BigInteger expectedNumerator = a;
            BigInteger expectedDenominator = b;
            
            // Act
            BigRational reducedRational = BigRational.Reduce(rational);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(reducedRational.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(reducedRational.Denominator, Is.EqualTo(expectedDenominator));
            });
        }

        [Test]
        public void AddBigRationalNumbersTest()
        {
            // Arrange
            const long a = 3;
            const long b = 4;
            BigRational rational1 = new BigRational(a, b);
            
            const long c = 5;
            const long d = 6;
            BigRational rational2 = new BigRational(c, d);
           
            BigInteger expectedNumerator = a * d + b * c;
            BigInteger expectedDenominator = b * d;
            
            BigRational expectedSum = new BigRational(expectedNumerator, expectedDenominator);
            BigRational reducedExpectedSum = BigRational.Reduce(expectedSum);

            BigInteger reducedExpectedNumerator = reducedExpectedSum.Numerator;
            BigInteger reducedExpectedDenominator = reducedExpectedSum.Denominator;
            
            // Act
            BigRational sum = BigRational.Add(rational1, rational2);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(sum.Numerator, Is.EqualTo(reducedExpectedNumerator));
                Assert.That(sum.Denominator, Is.EqualTo(reducedExpectedDenominator));
            });
        }

        [Test]
        public void DivideBigRationalNumbersTest()
        {
            // Arrange
            const long a = 3;
            const long b = 4;
            BigRational rational1 = new BigRational(a, b);
            
            const long c = 5;
            const long d = 6;
            BigRational rational2 = new BigRational(c, d);

            BigInteger expectedNumerator = a * d;
            BigInteger expectedDenominator = b * c;
            
            BigRational expectedQuotient = new BigRational(expectedNumerator, expectedDenominator);
            BigRational reducedExpectedQuotient = BigRational.Reduce(expectedQuotient);

            BigInteger reducedExpectedNumerator = reducedExpectedQuotient.Numerator;
            BigInteger reducedExpectedDenominator = reducedExpectedQuotient.Denominator;
            
            // Act
            BigRational quotient = BigRational.Divide(rational1, rational2);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(quotient.Numerator, Is.EqualTo(reducedExpectedNumerator));
                Assert.That(quotient.Denominator, Is.EqualTo(reducedExpectedDenominator));
            });
        }
    }
}