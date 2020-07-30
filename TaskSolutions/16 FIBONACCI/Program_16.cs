using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_FIBONACCI
{
    public class Program_16
    {
        static void Main(string[] args)
        {
            if (uint.TryParse(args[0], out uint input) == false || input == 0)
                ConsoleTools.CloseProgram("Wrong input. Enter the number of elements of Fibbonaci Series (positive number).");

            Console.WriteLine($"Input arguments: {String.Join(" ", args)}");

            Console.WriteLine(String.Join("", GetFibbonaciSeries(input)));

            ConsoleTools.CloseProgram();
        }

        public static List<int> GetFibbonaciSeries(uint elements)
        {
            if (elements == 0)
                return new List<int>();
            
            return GetNext(Convert.ToInt32(elements), new List<int>());
        }

        private static List<int> GetNext(int currentIndex, List<int> FibbonaciSeries)
        {
            if (currentIndex < 1)
                return FibbonaciSeries;

            if (FibbonaciSeries.Any() == false)
                FibbonaciSeries.Add(0);
            else if (FibbonaciSeries.Sum() == 0)
                FibbonaciSeries.Add(1);
            else
                FibbonaciSeries.Add(FibbonaciSeries.Sum());
            
            return GetNext(--currentIndex, FibbonaciSeries);
        }
    }
}
