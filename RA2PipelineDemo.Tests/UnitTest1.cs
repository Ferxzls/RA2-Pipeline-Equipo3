using Xunit;
using RA2PipelineDemo;

namespace RA2PipelineDemo.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Sum_ReturnsCorrectValue()
        {
            var calc = new Calculator();
            var result = calc.Sum(2, 3);

            Assert.Equal(5, result);
        }
    }
}