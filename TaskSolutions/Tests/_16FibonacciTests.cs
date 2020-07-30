using System;
using Xunit;
using _16Fibonacci;
using System.Collections.Generic;

namespace Tests
{
    public class _16FibonacciTests
    {
        [Fact]
        public void GetFibbonaciSeries_ShouldReturnCorrectSeries1()
        {
            uint input = 5;
            List<int> expected = new List<int>() { 0, 1, 1, 2, 4 };

            var actual = Program16.GetFibbonaciSeries(input);

            Assert.Equal(expected, actual);
        }

    }
}
