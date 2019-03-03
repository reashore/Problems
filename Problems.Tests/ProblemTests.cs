using NUnit.Framework;

namespace Problems.Tests
{
    public class ProblemTests
    {
        [Test]
        public void Problem1Test()
        {
            // Arrange
            const int expectedResult = 233168;
            
            // Act
            int answer = Problem1.Problem1.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem2Test()
        {
            // Arrange
            const int expectedResult = 4613732;
            
            // Act
            int answer = Problem2.Problem2.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem3Test()
        {
            // Arrange
            const long expectedResult = 6857;
            
            // Act
            long answer = Problem3.Problem3.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem4Test()
        {
            // Arrange
            const long expectedResult = 906609;
            
            // Act
            long answer = Problem4.Problem4.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem5Test()
        {
            // Arrange
            const long expectedResult = 232792560;
            
            // Act
            long answer = Problem5.Problem5.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
         
        [Test]
        public void Problem6Test()
        {
            // Arrange
            const int expectedResult = 25164150;
            
            // Act
            long answer = Problem6.Problem6.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
         
        [Test]
        public void Problem7Test()
        {
            // Arrange
            const int expectedResult = 7927;
            
            // Act
            long answer = Problem7.Problem7.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
         
        [Test]
        public void Problem8Test()
        {
            // Arrange
            const long expectedResult = 23514624000;
            
            // Act
            long answer = Problem8.Problem8.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Problem9Test()
        {
            // Arrange
            const int expectedResult = 31875000;

            // Act
            int answer = Problem9.Problem9.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
          
        [Test]
        public void Problem10Test()
        {
            // Arrange
            const long expectedResult = 142913828922;
            
            // Act
            long answer = Problem10.Problem10.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem11Test()
        {
            // Arrange
            const long expectedResult = 70600674;
            
            // Act
            long answer = Problem11.Problem11.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
          
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem12Test()
        {
            // Arrange
            const ulong expectedResult = 76576500;
            
            // Act
            long answer = Problem12.Problem12.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem13Test()
        {
            // Arrange
            const long expectedResult = 5537376230;
            
            // Act
            long answer = Problem13.Problem13.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem14Test()
        {
            // Arrange
            const long expectedResult = 837799;
            
            // Act
            long answer = Problem14.Problem14.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem15Test()
        {
            // Arrange
            const long expectedResult = 137846528820;
            
            // Act
            ulong answer = Problem15.Problem15.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem16Test()
        {
            // Arrange
            const long expectedResult = 1366;
            
            // Act
            int answer = Problem16.Problem16.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem17Test()
        {
            // Arrange
            const long expectedResult = 21124;
            
            // Act
            int answer = Problem17.Problem17.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem18Test()
        {
            // Arrange
            const long expectedResult = 1074;
            
            // Act
            long answer = Problem18.Problem18.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem19Test()
        {
            // Arrange
            const long expectedResult = 171;
            
            // Act
            int answer = Problem19.Problem19.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem20Test()
        {
            // Arrange
            const long expectedResult = 648;
            
            // Act
            int answer = Problem20.Problem20.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem21Test()
        {
            // Arrange
            const long expectedResult = 31626;
            
            // Act
            int answer = Problem21.Problem21.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem22Test()
        {
            // Arrange
            const long expectedResult = 871198282;
            
            // Act
            long answer = Problem22.Problem22.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem23Test()
        {
            // Arrange
            const long expectedResult = 4179871;
            
            // Act
            long answer = Problem23.Problem23.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem24Test()
        {
            // Arrange
            const string expectedResult = "2783915460";
            
            // Act
            string answer = Problem24.Problem24.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem25Test()
        {
            // Arrange
            const long expectedResult = 4782;
            
            // Act
            int answer = Problem25.Problem25.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Ignore("Not finished")]
        public void Problem26Test()
        {
            // Arrange
            //const long expectedResult = 4782;
            
            // Act
            //var (maxDenominator, maxDigitStringLength, maxDigitString) = Problem26.Problem26.Solve();

            // Assert
            //Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem27Test()
        {
            // Arrange
            const long expectedResult = -59231;
            
            // Act
            long answer = Problem27.Problem27.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem28Test()
        {
            // Arrange
            const long expectedResult = 669171001;
            
            // Act
            long answer = Problem28.Problem28.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem29Test()
        {
            // Arrange
            const long expectedResult = 9183;
            
            // Act
            long answer = Problem29.Problem29.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem30Test()
        {
            // Arrange
            const long expectedResult = 443839;
            
            // Act
            long answer = Problem30.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem31Test()
        {
            // Arrange
            const long expectedResult = 73682;
            
            // Act
            ulong answer = Problem31.Problem31.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem32Test()
        {
            // Arrange
            const long expectedResult = 45228;
            
            // Act
            long answer = Problem32.Problem32.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem33Test()
        {
            // Arrange
            const long expectedResult = 100;
            
            // Act
            long answer = Problem33.Problem33.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem34Test()
        {
            // Arrange
            const long expectedResult = 40730;
            
            // Act
            long answer = Problem34.Problem34.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem35Test()
        {
            // Arrange
            const long expectedResult = 55;
            
            // Act
            long answer = Problem35.Problem35.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem36Test()
        {
            // Arrange
            const long expectedResult = 872187;
            
            // Act
            long answer = Problem36.Problem36.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem37Test()
        {
            // Arrange
            const long expectedResult = 748317;
            
            // Act
            long answer = Problem37.Problem37.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem38Test()
        {
            // Arrange
            const long expectedResult = 932718654;
            
            // Act
            long answer = Problem38.Problem38.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem39Test()
        {
            // Arrange
            const long expectedResult = 840;
            
            // Act
            long answer = Problem39.Problem39.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem40Test()
        {
            // Arrange
            const long expectedResult = 210;
            
            // Act
            long answer = Problem40.Problem40.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem41Test()
        {
            // Arrange
            const long expectedResult = 7652413;
            
            // Act
            long answer = Problem41.Problem41.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem42Test()
        {
            // Arrange
            const long expectedResult = 162;
            
            // Act
            long answer = Problem42.Problem42.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem43Test()
        {
            // Arrange
            const long expectedResult = 16695334890;
            
            // Act
            long answer = Problem43.Problem43.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem44Test()
        {
            // Arrange
            const long expectedResult = 5482660;
            
            // Act
            long answer = Problem44.Problem44.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem45Test()
        {
            // Arrange
            const long expectedResult = 1533776805;
            
            // Act
            long answer = Problem45.Problem45.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem46Test()
        {
            // Arrange
            const long expectedResult = 5777;
            
            // Act
            long answer = Problem46.Problem46.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem47Test()
        {
            // Arrange
            const long expectedResult = 134043;
            
            // Act
            long answer = Problem47.Problem47.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem48Test()
        {
            // Arrange
            const string expectedResult = "9110846700";
            
            // Act
            string answer = Problem48.Problem48.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem49Test()
        {
            // Arrange
            const string expectedResult = "296962999629";
            
            // Act
            string answer = Problem49.Problem49.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem50Test()
        {
            // Arrange
            const int expectedResult = 997651;
            
            // Act
            long answer = Problem50.Problem50.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem52Test()
        {
            // Arrange
            const int expectedResult = 142857;
            
            // Act
            ulong answer = Problem52.Problem52.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Ignore("Not finished")]
        public void Problem54Test()
        {
            // Arrange
            const int expectedResult = 376;
            
            // Act
            int answer = Problem54.Problem54.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem55Test()
        {
            // Arrange
            const int expectedResult = 249;
            
            // Act
            int answer = Problem55.Problem55.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem56Test()
        {
            // Arrange
            const int expectedResult = 972;
            
            // Act
            long answer = Problem56.Problem56.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem59Test()
        {
            // Arrange
            const int expectedResult = 107359;
            
            // Act
            (long, string) answer = Problem59.Problem59.Solve();

            // Assert
            Assert.That(answer.Item1, Is.EqualTo(expectedResult));
            //Assert.That(answer.Item2, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem63Test()
        {
            // Arrange
            const int expectedResult = 49;
            
            // Act
            int answer = Problem63.Problem63.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem79Test()
        {
            // Arrange
            const string expectedResult = "73162890";
            
            // Act
            string answer = Problem79.Problem79.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem92Test()
        {
            // Arrange
            const int expectedResult = 8581146;
            
            // Act
            int answer = Problem92.Problem92.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem97Test()
        {
            // Arrange
            const string expectedResult = "8739992577";
            
            // Act
            string answer = Problem97.Problem97.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Category("Slow")]
        [Explicit]
        public void Problem99Test()
        {
            // Arrange
            const int expectedResult = 21;
            
            // Act
            int answer = Problem99.Problem99.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
    }
}
