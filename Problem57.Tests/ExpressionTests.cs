using NUnit.Framework;

namespace Problem57.Tests
{
    [TestFixture]
    public class ExpressionTests
    {
        [Test]
        public void InnerExpressionTest()
        {
            // Arrange
            Rational two = new Rational(2);
            
            const long expectedNumerator = 5;
            const long expectedDenominator = 2;
            
            // Act
            Rational innerExpression = Program.CalculateInnerExpression(two);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(innerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(innerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
        
        [Test]
        public void OuterExpressionTest()
        {
            // Arrange
            Rational two = new Rational(2);
            
            const long expectedNumerator = 3;
            const long expectedDenominator = 2;
            
            // Act
            Rational innerExpression = Program.CalculateOuterExpression(two);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(innerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(innerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
        
        [Test]
        public void Iteration1Test()
        {
            // Arrange
            Rational two = new Rational(2);
            
            const long expectedNumerator = 7;
            const long expectedDenominator = 5;
            
            // Act
            Rational innerExpression = Program.CalculateInnerExpression(two);
            Rational outerExpression = Program.CalculateOuterExpression(innerExpression);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(outerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(outerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
        
        [Test]
        public void Iteration2Test()
        {
            // Arrange
            Rational two = new Rational(2);
            
            const long expectedNumerator = 17;
            const long expectedDenominator = 12;
            
            // Act
            Rational innerExpression1 = Program.CalculateInnerExpression(two);
            Rational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            Rational outerExpression = Program.CalculateOuterExpression(innerExpression2);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(outerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(outerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
        
        [Test]
        public void Iteration3Test()
        {
            // Arrange
            Rational two = new Rational(2);
            
            const long expectedNumerator = 41;
            const long expectedDenominator = 29;
            
            // Act
            Rational innerExpression1 = Program.CalculateInnerExpression(two);
            Rational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            Rational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            Rational outerExpression = Program.CalculateOuterExpression(innerExpression3);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(outerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(outerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
        
        [Test]
        public void Iteration4Test()
        {
            // Arrange
            Rational two = new Rational(2);
            
            const long expectedNumerator = 99;
            const long expectedDenominator = 70;
            
            // Act
            Rational innerExpression1 = Program.CalculateInnerExpression(two);
            Rational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            Rational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            Rational innerExpression4 = Program.CalculateInnerExpression(innerExpression3);
            Rational outerExpression = Program.CalculateOuterExpression(innerExpression4);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(outerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(outerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
        
        [Test]
        public void Iteration5Test()
        {
            // Arrange
            Rational two = new Rational(2);
            
            const long expectedNumerator = 239;
            const long expectedDenominator = 169;
            
            // Act
            Rational innerExpression1 = Program.CalculateInnerExpression(two);
            Rational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            Rational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            Rational innerExpression4 = Program.CalculateInnerExpression(innerExpression3);
            Rational innerExpression5 = Program.CalculateInnerExpression(innerExpression4);
            Rational outerExpression = Program.CalculateOuterExpression(innerExpression5);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(outerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(outerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
        
        [Test]
        public void Iteration6Test()
        {
            // Arrange
            Rational two = new Rational(2);
            
            const long expectedNumerator = 577;
            const long expectedDenominator = 408;
            
            // Act
            Rational innerExpression1 = Program.CalculateInnerExpression(two);
            Rational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            Rational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            Rational innerExpression4 = Program.CalculateInnerExpression(innerExpression3);
            Rational innerExpression5 = Program.CalculateInnerExpression(innerExpression4);
            Rational innerExpression6 = Program.CalculateInnerExpression(innerExpression5);
            Rational outerExpression = Program.CalculateOuterExpression(innerExpression6);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(outerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(outerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }
        
        [Test]
        public void Iteration7Test()
        {
            // Arrange
            Rational two = new Rational(2);
            
            const long expectedNumerator = 1393;
            const long expectedDenominator = 985;
            
            // Act
            Rational innerExpression1 = Program.CalculateInnerExpression(two);
            Rational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            Rational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            Rational innerExpression4 = Program.CalculateInnerExpression(innerExpression3);
            Rational innerExpression5 = Program.CalculateInnerExpression(innerExpression4);
            Rational innerExpression6 = Program.CalculateInnerExpression(innerExpression5);
            Rational innerExpression7 = Program.CalculateInnerExpression(innerExpression6);
            Rational outerExpression = Program.CalculateOuterExpression(innerExpression7);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(outerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(outerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }

    }
}