using NUnit.Framework;

namespace Problems.Test
{
    public class ProblemTests
    {
        [Test]
        public void Problem1Test()
        {
            // Arrange
            const int upperLimit = 1000;
            const int expectedResult = 233168;
            
            // Act
            int answer = Problem1.Program.Solve(upperLimit);

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem2Test()
        {
            // Arrange
            const int upperLimit = 4000000;
            const int expectedResult = 4613732;
            
            // Act
            int answer = Problem2.Program.Solve(upperLimit);

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem3Test()
        {
            // Arrange
            const long number = 600851475143;
            const long expectedResult = 6857;
            
            // Act
            long answer = Problem3.Program.Solve(number);

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem4Test()
        {
            // Arrange
            const long expectedResult = 906609;
            
            // Act
            long answer = Problem4.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem5Test()
        {
            // Arrange
            const long expectedResult = 232792560;
            
            // Act
            long answer = Problem5.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
         
        [Test]
        public void Problem6Test()
        {
            // Arrange
            const int number = 100;
            const int expectedResult = 25164150;
            
            // Act
            long answer = Problem6.Program.Solve(number);

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
         
        [Test]
        public void Problem7Test()
        {
            // Arrange
            const int number = 1001;
            const int expectedResult = 7927;
            
            // Act
            long answer = Problem7.Program.Solve(number);

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
         
        [Test]
        public void Problem8Test()
        {
            // Arrange
            const long expectedResult = 23514624000;
            
            // Act
            long answer = Problem8.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Problem9Test()
        {
            // Arrange
            const int expectedResult = 31875000;

            // Act
            int result = Problem9.Program.Solve();

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
          
        [Test]
        public void Problem10Test()
        {
            // Arrange
            const int number = 2000000;
            const long expectedResult = 142913828922;
            
            // Act
            long answer = Problem10.Program.Solve(number);

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem11Test()
        {
            // Arrange
            const long expectedResult = 70600674;
            
            // Act
            long answer = Problem11.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
          
        [Test]
        [Category("Slow")]
        [Explicit]
        [Ignore("Ignore slow test")]
        public void Problem12Test()
        {
            // Arrange
            const ulong expectedResult = 76576500;
            
            // Act
            long answer = Problem12.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem13Test()
        {
            // Arrange
            const long expectedResult = 5537376230;
            
            // Act
            long answer = Problem13.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem14Test()
        {
            // Arrange
            const long expectedResult = 837799;
            
            // Act
            long answer = Problem14.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Category("Slow")]
        [Explicit]
        [Ignore("Ignore slow test")]
        public void Problem15Test()
        {
            // Arrange
            const long expectedResult = 137846528820;
            
            // Act
            ulong answer = Problem15.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem16Test()
        {
            // Arrange
            const long expectedResult = 1366;
            
            // Act
            int answer = Problem16.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem17Test()
        {
            // Arrange
            const long expectedResult = 21124;
            
            // Act
            int answer = Problem17.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem18Test()
        {
            // Arrange
            const long expectedResult = 1074;
            
            // Act
            long answer = Problem18.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem19Test()
        {
            // Arrange
            const long expectedResult = 171;
            
            // Act
            int answer = Problem19.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem20Test()
        {
            // Arrange
            const long expectedResult = 648;
            
            // Act
            int answer = Problem20.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem21Test()
        {
            // Arrange
            const long expectedResult = 31626;
            
            // Act
            int answer = Problem21.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        
        
        
    }
}