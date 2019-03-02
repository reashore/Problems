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
            int answer = Problem1.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem2Test()
        {
            // Arrange
            const int expectedResult = 4613732;
            
            // Act
            int answer = Problem2.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem3Test()
        {
            // Arrange
            const long expectedResult = 6857;
            
            // Act
            long answer = Problem3.Program.Solve();

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
            const int expectedResult = 25164150;
            
            // Act
            long answer = Problem6.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
         
        [Test]
        public void Problem7Test()
        {
            // Arrange
            const int expectedResult = 7927;
            
            // Act
            long answer = Problem7.Program.Solve();

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
            int answer = Problem9.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
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
        
        [Test]
        public void Problem22Test()
        {
            // Arrange
            const long expectedResult = 871198282;
            
            // Act
            long answer = Problem22.Program.Solve();

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
            long answer = Problem23.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem24Test()
        {
            // Arrange
            const string expectedResult = "2783915460";
            
            // Act
            string answer = Problem24.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem25Test()
        {
            // Arrange
            const long expectedResult = 4782;
            
            // Act
            int answer = Problem25.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [Ignore("Not finished")]
        public void Problem26Test()
        {
            // Arrange
            const long expectedResult = 4782;
            
            // Act
            int answer = Problem25.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem27Test()
        {
            // Arrange
            const long expectedResult = -59231;
            
            // Act
            long answer = Problem27.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem28Test()
        {
            // Arrange
            const long expectedResult = 669171001;
            
            // Act
            long answer = Problem28.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem29Test()
        {
            // Arrange
            const long expectedResult = 9183;
            
            // Act
            long answer = Problem29.Program.Solve();

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
            ulong answer = Problem31.Program.Solve();

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
            long answer = Problem32.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem33Test()
        {
            // Arrange
            const long expectedResult = 100;
            
            // Act
            long answer = Problem33.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem34Test()
        {
            // Arrange
            const long expectedResult = 40730;
            
            // Act
            long answer = Problem34.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem35Test()
        {
            // Arrange
            const long expectedResult = 55;
            
            // Act
            long answer = Problem35.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem36Test()
        {
            // Arrange
            const long expectedResult = 872187;
            
            // Act
            long answer = Problem36.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem37Test()
        {
            // Arrange
            const long expectedResult = 748317;
            
            // Act
            long answer = Problem37.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem38Test()
        {
            // Arrange
            const long expectedResult = 932718654;
            
            // Act
            long answer = Problem38.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem39Test()
        {
            // Arrange
            const long expectedResult = 840;
            
            // Act
            long answer = Problem39.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem40Test()
        {
            // Arrange
            const long expectedResult = 210;
            
            // Act
            long answer = Problem40.Program.Solve();

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
            long answer = Problem41.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem42Test()
        {
            // Arrange
            const long expectedResult = 162;
            
            // Act
            long answer = Problem42.Program.Solve();

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
            long answer = Problem43.Program.Solve();

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
            long answer = Problem44.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem45Test()
        {
            // Arrange
            const long expectedResult = 1533776805;
            
            // Act
            long answer = Problem45.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem46Test()
        {
            // Arrange
            const long expectedResult = 5777;
            
            // Act
            long answer = Problem46.Program.Solve();

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
            long answer = Problem47.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem48Test()
        {
            // Arrange
            const string expectedResult = "9110846700";
            
            // Act
            string answer = Problem48.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem49Test()
        {
            // Arrange
            const string expectedResult = "296962999629";
            
            // Act
            string answer = Problem49.Program.Solve();

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
            long answer = Problem50.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem52Test()
        {
            // Arrange
            const int expectedResult = 142857;
            
            // Act
            ulong answer = Problem52.Program.Solve();

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
            int answer = Problem54.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem55Test()
        {
            // Arrange
            const int expectedResult = 249;
            
            // Act
            int answer = Problem55.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem56Test()
        {
            // Arrange
            const int expectedResult = 972;
            
            // Act
            long answer = Problem56.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
                
        [Test]
        public void Problem59Test()
        {
            // Arrange
            const int expectedResult = 107359;
            
            // Act
            (long, string) answer = Problem59.Program.Solve();

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
            int answer = Problem63.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem79Test()
        {
            // Arrange
            const string expectedResult = "73162890";
            
            // Act
            string answer = Problem79.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem92Test()
        {
            // Arrange
            const int expectedResult = 8581146;
            
            // Act
            int answer = Problem92.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Problem97Test()
        {
            // Arrange
            const string expectedResult = "8739992577";
            
            // Act
            string answer = Problem97.Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }
    }
}
