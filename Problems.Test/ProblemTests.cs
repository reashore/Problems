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
            const int adjacentDigits = 13;
            const string number = "73167176531330624919225119674426574742355349194934" +
                                  "96983520312774506326239578318016984801869478851843" +
                                  "85861560789112949495459501737958331952853208805511" +
                                  "12540698747158523863050715693290963295227443043557" +
                                  "66896648950445244523161731856403098711121722383113" +
                                  "62229893423380308135336276614282806444486645238749" +
                                  "30358907296290491560440772390713810515859307960866" +
                                  "70172427121883998797908792274921901699720888093776" +
                                  "65727333001053367881220235421809751254540594752243" +
                                  "52584907711670556013604839586446706324415722155397" +
                                  "53697817977846174064955149290862569321978468622482" +
                                  "83972241375657056057490261407972968652414535100474" +
                                  "82166370484403199890008895243450658541227588666881" +
                                  "16427171479924442928230863465674813919123162824586" +
                                  "17866458359124566529476545682848912883142607690042" +
                                  "24219022671055626321111109370544217506941658960408" +
                                  "07198403850962455444362981230987879927244284909188" +
                                  "84580156166097919133875499200524063689912560717606" +
                                  "05886116467109405077541002256983155200055935729725" +
                                  "71636269561882670428252483600823257530420752963450";
            const long expectedResult = 23514624000;
            
            // Act
            long answer = Problem8.Program.Solve(number, adjacentDigits);

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
    }
}