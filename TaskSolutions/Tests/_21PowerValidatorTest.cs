using _21PowerValidator;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class _21PowerValidatorTest
    {
        [Fact]
        public void AreSquares_ShouldReturnFalse()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            var squares = new List<int>() { 1, 4, 9, 4 };

            Assert.False(Program21.AreSquares(numbers,squares));
        }

        [Fact]
        public void AreSquares_ShouldReturnFalse2()
        {
            var numbers = new List<int>() { 1, 1, 3, 4 };
            var squares = new List<int>() { 1, 9, 9, 16 };

            Assert.False(Program21.AreSquares(numbers, squares));
        }

        [Fact]
        public void AreSquares_ShouldReturnTrue()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            var squares = new List<int>() { 1, 4, 9, 16 };

            Assert.True(Program21.AreSquares(numbers, squares));
        }

        [Fact]
        public void AreSquares_ShouldReturnTrue2()
        {
            var numbers = new List<int>() { 1, 1, 2, 2 };
            var squares = new List<int>() { 1, 1, 4, 4 };

            Assert.True(Program21.AreSquares(numbers, squares));
        }
    }
}
