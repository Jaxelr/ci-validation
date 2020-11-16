using Xunit;

namespace HelloTestProject
{
    public class Tests
    {
        [Fact]
        public void Single_test_approved()
        {
            //Arrange
            int x = 1;

            //Act
            x *= 2;

            //Assert
            Assert.Equal(2, x);
        }
    }
}