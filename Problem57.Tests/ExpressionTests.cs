using System.Numerics;
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
            BigRational two = new(2);
            
            BigInteger expectedNumerator = 5;
            BigInteger expectedDenominator = 2;
            
            // Act
            BigRational innerExpression = Problem57.CalculateInnerExpression(two);
            
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
            BigRational two = new(2);
            
            BigInteger expectedNumerator = 3;
            BigInteger expectedDenominator = 2;
            
            // Act
            BigRational innerExpression = Problem57.CalculateOuterExpression(two);
            
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
            BigRational two = new(2);
            
            BigInteger expectedNumerator = 7;
            BigInteger expectedDenominator = 5;
            
            // Act
            BigRational innerExpression = Problem57.CalculateInnerExpression(two);
            BigRational outerExpression = Problem57.CalculateOuterExpression(innerExpression);
            
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
            BigRational two = new(2);
            
            BigInteger expectedNumerator = 17;
            BigInteger expectedDenominator = 12;
            
            // Act
            BigRational innerExpression1 = Problem57.CalculateInnerExpression(two);
            BigRational innerExpression2 = Problem57.CalculateInnerExpression(innerExpression1);
            BigRational outerExpression = Problem57.CalculateOuterExpression(innerExpression2);
            
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
            BigRational two = new(2);
            
            BigInteger expectedNumerator = 41;
            BigInteger expectedDenominator = 29;
            
            // Act
            BigRational innerExpression1 = Problem57.CalculateInnerExpression(two);
            BigRational innerExpression2 = Problem57.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Problem57.CalculateInnerExpression(innerExpression2);
            BigRational outerExpression = Problem57.CalculateOuterExpression(innerExpression3);
            
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
            BigRational two = new(2);
            
            BigInteger expectedNumerator = 99;
            BigInteger expectedDenominator = 70;
            
            // Act
            BigRational innerExpression1 = Problem57.CalculateInnerExpression(two);
            BigRational innerExpression2 = Problem57.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Problem57.CalculateInnerExpression(innerExpression2);
            BigRational innerExpression4 = Problem57.CalculateInnerExpression(innerExpression3);
            BigRational outerExpression = Problem57.CalculateOuterExpression(innerExpression4);
            
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
            BigRational two = new(2);
            
            BigInteger expectedNumerator = 239;
            BigInteger expectedDenominator = 169;
            
            // Act
            BigRational innerExpression1 = Problem57.CalculateInnerExpression(two);
            BigRational innerExpression2 = Problem57.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Problem57.CalculateInnerExpression(innerExpression2);
            BigRational innerExpression4 = Problem57.CalculateInnerExpression(innerExpression3);
            BigRational innerExpression5 = Problem57.CalculateInnerExpression(innerExpression4);
            BigRational outerExpression = Problem57.CalculateOuterExpression(innerExpression5);
            
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
            BigRational two = new(2);
            
            BigInteger expectedNumerator = 577;
            BigInteger expectedDenominator = 408;
            
            // Act
            BigRational innerExpression1 = Problem57.CalculateInnerExpression(two);
            BigRational innerExpression2 = Problem57.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Problem57.CalculateInnerExpression(innerExpression2);
            BigRational innerExpression4 = Problem57.CalculateInnerExpression(innerExpression3);
            BigRational innerExpression5 = Problem57.CalculateInnerExpression(innerExpression4);
            BigRational innerExpression6 = Problem57.CalculateInnerExpression(innerExpression5);
            BigRational outerExpression = Problem57.CalculateOuterExpression(innerExpression6);
            
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
            BigRational two = new(2);
            
            BigInteger expectedNumerator = 1393;
            BigInteger expectedDenominator = 985;
            
            // Act
            BigRational innerExpression1 = Problem57.CalculateInnerExpression(two);
            BigRational innerExpression2 = Problem57.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Problem57.CalculateInnerExpression(innerExpression2);
            BigRational innerExpression4 = Problem57.CalculateInnerExpression(innerExpression3);
            BigRational innerExpression5 = Problem57.CalculateInnerExpression(innerExpression4);
            BigRational innerExpression6 = Problem57.CalculateInnerExpression(innerExpression5);
            BigRational innerExpression7 = Problem57.CalculateInnerExpression(innerExpression6);
            BigRational outerExpression = Problem57.CalculateOuterExpression(innerExpression7);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(outerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(outerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }

    }
}