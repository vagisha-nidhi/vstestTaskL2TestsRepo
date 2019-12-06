using Xunit;

namespace XUnitDataDrivenTestsProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Test1(int data)
        {
            Assert.True(1 == 1);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(1 == 1);
        }
    }
}
