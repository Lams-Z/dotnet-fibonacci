using Xunit;

namespace Fibonacci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = Compute.Execute(new[] {"44"});
            Assert.Equal(701408733, result[0]);
        }
    }
}