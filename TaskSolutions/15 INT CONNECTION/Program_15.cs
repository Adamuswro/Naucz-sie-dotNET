using System;
using System.Collections.Generic;
using System.Linq;
using Helpers;

namespace _15_INT_CONNECTION
{
    class Program_15
    {
        static void Main(string[] args)
        {
            List<int> input = ConvertInput(args);
            
            if (input == null || input.Count == 0)
            {
                ConsoleTools.CloseProgram($"Error. Wrong input. (Input: {String.Join(" ", args)})");

            }
            else if (isMoreThanTenDgits(input) == true)
            {
                ConsoleTools.CloseProgram($"Too many digits, result is out of int type size.");
            }
            var sortedFromMax = input.
                OrderByDescending(p => GetDigitFromLeft(p, 1)).
                ThenByDescending(p => GetDigitFromLeft(p, 2)).
                ThenByDescending(p => GetDigitFromLeft(p, 3)).
                ThenByDescending(p => GetDigitFromLeft(p, 4)).
                ThenByDescending(p => GetDigitFromLeft(p, 5)).
                ToList();

            var sortedFromMin = input.
                OrderBy(p => GetDigitFromLeft(p, 1)).
                ThenBy(p => GetDigitFromLeft(p, 2)).
                ThenBy(p => GetDigitFromLeft(p, 3)).
                ThenBy(p => GetDigitFromLeft(p, 4)).
                ThenBy(p => GetDigitFromLeft(p, 5)).
                ToList();

            if (Int32.TryParse(String.Join("", sortedFromMin), out int min) == false)
            {
                ConsoleTools.CloseProgram($"Min number is out of int type size.");
            }

            if (Int32.TryParse(String.Join("", sortedFromMax), out int max) == false)
            {
                int bufor;
                int index = 0;
                int maxIterations = (sortedFromMax.Count - 1) * (sortedFromMax.Count - 1);
                for (int i = 0; i < maxIterations; i++)
                {
                    if (index == sortedFromMax.Count - 1)
                    {
                        index = 0;
                    }

                    bufor = sortedFromMax[index];
                    sortedFromMax[index] = sortedFromMax[index + 1];
                    sortedFromMax[index + 1] = bufor;
                    if (Int32.TryParse(String.Join("", sortedFromMax), out max) == true)
                    {
                        break;
                    }
                    index++;
                }
            }

            Console.WriteLine($"Input {String.Join(" ", input)}");
            Console.WriteLine($"Max int: {Int32.MaxValue}");
            Console.WriteLine($"Max {max}");
            Console.WriteLine($"Min {min}");

            ConsoleTools.CloseProgram();
        }

        private static int LeftToMax(int input)
        {
            var digits = GetDigitsNumber(input);

            var max = 10 ^ (digits + 1) - 1;

            return max - input;
        }



        private static bool isMoreThanTenDgits(List<int> input)
        {
            int counter = 0;

            foreach (var number in input)
            {
                counter += GetDigitsNumber(number);
            }

            if (counter > 10)
            {
                return true;
            }

            return false;
        }

        private static int GetDigitFromLeft(int input, int numberOfDigitFromLeft)
        {
            if (numberOfDigitFromLeft < 1)
            {
                throw new ArgumentException("Number of digit must be higher than 0!");
            }

            int allDigits = GetDigitsNumber(input);

            if (numberOfDigitFromLeft > allDigits)
            {
                return GetDigitFromLeft(input, allDigits);
            }

            int result = (input / (int)Math.Pow(10, GetDigitsNumber(input) - numberOfDigitFromLeft)) % 10;
            return result;
        }

        private static int GetDigitsNumber(int input)
        {
            return Convert.ToInt32(Math.Floor(Math.Log10(input) + 1));
        }

        static List<int> ConvertInput(string[] input)
        {
            List<int> result;
            try
            {
                result = new List<int>(Array.ConvertAll(input, s => int.Parse(s)));
            }
            catch (Exception)
            {
                result = new List<int>();
            }
            return result;
        }
    }
}
