using System;
using System.Collections.Generic;

namespace TaskSolutions
{
    class Program1
    {
        static void Main(string[] args)
        {
            do
            {
                bool isInputCorrect = false;
                string input;
                List<int> convertedInput = new List<int>();

                #region Read and convert user input
                Console.WriteLine($"Enter the list of numbers with seperator ','. It should be at least 3 numbers {Environment.NewLine} " +
                $"Example: '1,2,5,-4,5,-10'");
                do
                {
                    input = Console.ReadLine();
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
                    if (convertedInput.Count < 3)
                    {
                        Console.WriteLine("Input must contain at least 3 numbers. Try again.");
                        continue;
                    }
                    isInputCorrect = true;
                } while (isInputCorrect == false);
                #endregion

                var results = SolveThreeSumProblem(convertedInput);

                #region Present result
                if (results.Count == 0)
                {
                    Console.WriteLine("There are no numbers that satisfy the 3 sum condition");
                }
                else
                {
                    Console.WriteLine("Results:");
                    foreach (var result in results)
                    {
                        Console.WriteLine(String.Join(", ", result));
                    }
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

        static List<List<int>> SolveThreeSumProblem(List<int> input)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < input.Count - 2; i++)
            {
                for (int j = i + 1; j < input.Count - 1; j++)
                {
                    for (int k = j + 1; k < input.Count; k++)
                    {
                        if (input[i] + input[j] + input[k] == 0)
                        {
                            if (IsDuplicate(result, input[i], input[j], input[k]))
                            {
                                continue;
                            }
                            result.Add(new List<int>(){
                                    input[i],
                                    input[j],
                                    input[k]
                                });
                        }
                    }
                }
            }

            return result;
        }

        private static bool IsDuplicate(List<List<int>> input, int v1, int v2, int v3)
        {
            bool result = false;
            foreach (var item in input)
            {
                if (item.Contains(v1) && item.Contains(v2) && item.Contains(v3))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
