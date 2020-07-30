using System.Collections.Generic;
using Xunit;
using _16_FIBONACCI;

namespace TaskSolutions.Tests
{
    public class _16FibonacciTests
    {
        [Fact]
        public void GetFibbonaciSeries_ShouldReturnCorrectSeries1()
        {
            uint input = 5;
            List<int> expected = new List<int>() { 0, 1, 1, 2, 4 };

            var actual = Program_16.GetFibbonaciSeries(input);

            Assert.Equal(expected, actual);
        }
        
    }
}
