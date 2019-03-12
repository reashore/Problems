using System.Collections.Generic;
using NUnit.Framework;

namespace Problem60.Tests
{
    [TestFixture]
    public class PrimeTests
    {
        private PrimesUtility _primesUtility;
        
        [OneTimeSetUp]  
        public void SetUp()
        {
            const int upperBound = 700_000;
            _primesUtility = new PrimesUtility(upperBound);   
        }
        
        [Test]
        [TestCase(     3, true)]
        [TestCase(     7, true)]
        [TestCase(   109, true)]
        [TestCase(   673, true)]
        [TestCase(  1097, true)]
        [TestCase(  7109, true)]
        [TestCase(109673, true)]
        [TestCase(673109, true)]
        public void IsPrimeCorrectlyValidatesPrimesTest(int number, bool expectedResult)
        {
            // Act
            bool actualResult = _primesUtility.IsPrimeFast(number);
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void ConcatenatedPrimesArePrimesTest()
        {
            // Arrange
            List<int> specialPrimes = new List<int> {3, 7, 109, 673};
            const bool expectedResult = true;
            
            // Act
            bool actualResult = Problem60.AreConcatenatedPrimesPrime(specialPrimes, _primesUtility);
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void SolvePrime4ProblemTest()
        {
            // Arrange
            const int expectedResult = 792;
            
            // Act
            int actualResult = Problem60.SolvePrime4Problem(_primesUtility);
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}