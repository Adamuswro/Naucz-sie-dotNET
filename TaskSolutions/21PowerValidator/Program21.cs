using System.Collections.Generic;
using System.Linq;

namespace _21PowerValidator
{
    public class Program21
    {
        static void Main(string[] args)
        {

        }

        public static bool AreSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            if (numbers.Count() != squares.Count())
                return false;

            var numbersSquared = numbers.Select(n => n = n * n);

            return Enumerable.SequenceEqual(squares, numbersSquared);
        }
    }
}
