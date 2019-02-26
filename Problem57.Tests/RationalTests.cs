using NUnit.Framework;

namespace Problem57.Tests
{
    public class RationalTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddRationalNumbersTest()
        {
            // Arrange
            const long a = 3;
            const long b = 4;
            Rational rational1 = new Rational(a, b);
            
            const long c = 5;
            const long d = 6;
            Rational rational2 = new Rational(c, d);

            const long expectedNumerator = a * d + b * c;
            const long expectedDenominator = b * d;
            
            // Act
            Rational sum = Rational.Add(rational1, rational2);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(sum.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(sum.Denominator, Is.EqualTo(expectedDenominator));
            });
        }

        [Test]
        public void DivideRationalNumbersTest()
        {
            // Arrange
            const long a = 3;
            const long b = 4;
            Rational rational1 = new Rational(a, b);
            
            const long c = 5;
            const long d = 6;
            Rational rational2 = new Rational(c, d);

            const long expectedNumerator = a * d;
            const long expectedDenominator = b * c;
            
            // Act
            Rational quotient = Rational.Divide(rational1, rational2);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(quotient.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(quotient.Denominator, Is.EqualTo(expectedDenominator));
            });
        }

        [Test]
        public void ReduceRationalNumbersTest()
        {
            // Arrange
            const long a = 2 * 3 * 5 * 7;
            const long b = 5 * 7 * 11 * 13;
            Rational rational = new Rational(a, b);
            
            const long expectedNumerator = 2 * 3;
            const long expectedDenominator = 11 * 13;
            
            // Act
            Rational reducedRational = Rational.Reduce(rational);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(reducedRational.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(reducedRational.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
    }
}