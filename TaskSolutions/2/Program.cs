using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                bool isInputCorrect = false;
                var convertedInput = new List<int>();
                #region Read and convert user input
                Console.WriteLine($"Enter the list of numbers with seperator ','.");
                do
                {
                    string input = Console.ReadLine();
                    if (input == null)
                    {
                        Console.WriteLine("No data. Try again.");
                        continue;
                    }
                    convertedInput = ConvertStringWithSeperator(input, ',');
                    if (convertedInput == null || convertedInput.Count == 0)
                    {
                        Console.WriteLine("Wrong input format. Try again.");
                        continue;
                    }
                    if (convertedInput.Count < 2)
                    {
                        Console.WriteLine("List must contain at least 2 numbers.");
                        continue;
                    }
                    isInputCorrect = true;
                } while (isInputCorrect == false);
                #endregion

                #region Present result
                Console.WriteLine("Result:");
                int currentResult = convertedInput[0];
                for (int i = 1; i < convertedInput.Count; i++)
                {
                    Console.WriteLine(currentResult += convertedInput[i]);
                }
                #endregion
                Console.WriteLine("To exit type 'q'");
            } while (Console.ReadLine() != "q");
        }

        static List<int> ConvertStringWithSeperator(string input, char separator)
        {
            var splittedInput = input.Split(separator);
            List<int> result = new List<int>();
            foreach (var number in splittedInput)
            {
                int cache;
                if (Int32.TryParse(number, out cache) == false)
                {
                    continue;
                }
                result.Add(cache);
            }

            return result;
        }
    }
}
