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
            BigRational two = new BigRational(2);
            
            BigInteger expectedNumerator = 5;
            BigInteger expectedDenominator = 2;
            
            // Act
            BigRational innerExpression = Program.CalculateInnerExpression(two);
            
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
            BigRational two = new BigRational(2);
            
            BigInteger expectedNumerator = 3;
            BigInteger expectedDenominator = 2;
            
            // Act
            BigRational innerExpression = Program.CalculateOuterExpression(two);
            
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
            BigRational two = new BigRational(2);
            
            BigInteger expectedNumerator = 7;
            BigInteger expectedDenominator = 5;
            
            // Act
            BigRational innerExpression = Program.CalculateInnerExpression(two);
            BigRational outerExpression = Program.CalculateOuterExpression(innerExpression);
            
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
            BigRational two = new BigRational(2);
            
            BigInteger expectedNumerator = 17;
            BigInteger expectedDenominator = 12;
            
            // Act
            BigRational innerExpression1 = Program.CalculateInnerExpression(two);
            BigRational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            BigRational outerExpression = Program.CalculateOuterExpression(innerExpression2);
            
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
            BigRational two = new BigRational(2);
            
            BigInteger expectedNumerator = 41;
            BigInteger expectedDenominator = 29;
            
            // Act
            BigRational innerExpression1 = Program.CalculateInnerExpression(two);
            BigRational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            BigRational outerExpression = Program.CalculateOuterExpression(innerExpression3);
            
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
            BigRational two = new BigRational(2);
            
            BigInteger expectedNumerator = 99;
            BigInteger expectedDenominator = 70;
            
            // Act
            BigRational innerExpression1 = Program.CalculateInnerExpression(two);
            BigRational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            BigRational innerExpression4 = Program.CalculateInnerExpression(innerExpression3);
            BigRational outerExpression = Program.CalculateOuterExpression(innerExpression4);
            
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
            BigRational two = new BigRational(2);
            
            BigInteger expectedNumerator = 239;
            BigInteger expectedDenominator = 169;
            
            // Act
            BigRational innerExpression1 = Program.CalculateInnerExpression(two);
            BigRational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            BigRational innerExpression4 = Program.CalculateInnerExpression(innerExpression3);
            BigRational innerExpression5 = Program.CalculateInnerExpression(innerExpression4);
            BigRational outerExpression = Program.CalculateOuterExpression(innerExpression5);
            
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
            BigRational two = new BigRational(2);
            
            BigInteger expectedNumerator = 577;
            BigInteger expectedDenominator = 408;
            
            // Act
            BigRational innerExpression1 = Program.CalculateInnerExpression(two);
            BigRational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            BigRational innerExpression4 = Program.CalculateInnerExpression(innerExpression3);
            BigRational innerExpression5 = Program.CalculateInnerExpression(innerExpression4);
            BigRational innerExpression6 = Program.CalculateInnerExpression(innerExpression5);
            BigRational outerExpression = Program.CalculateOuterExpression(innerExpression6);
            
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
            BigRational two = new BigRational(2);
            
            BigInteger expectedNumerator = 1393;
            BigInteger expectedDenominator = 985;
            
            // Act
            BigRational innerExpression1 = Program.CalculateInnerExpression(two);
            BigRational innerExpression2 = Program.CalculateInnerExpression(innerExpression1);
            BigRational innerExpression3 = Program.CalculateInnerExpression(innerExpression2);
            BigRational innerExpression4 = Program.CalculateInnerExpression(innerExpression3);
            BigRational innerExpression5 = Program.CalculateInnerExpression(innerExpression4);
            BigRational innerExpression6 = Program.CalculateInnerExpression(innerExpression5);
            BigRational innerExpression7 = Program.CalculateInnerExpression(innerExpression6);
            BigRational outerExpression = Program.CalculateOuterExpression(innerExpression7);
            
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(outerExpression.Numerator, Is.EqualTo(expectedNumerator));
                Assert.That(outerExpression.Denominator, Is.EqualTo(expectedDenominator));
            });
        }

    }
}