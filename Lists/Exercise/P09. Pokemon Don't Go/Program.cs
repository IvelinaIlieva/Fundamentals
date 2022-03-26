using System;
using System.Collections.Generic;
using System.Linq;

namespace P09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (input.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int indexValue = 0;

                if (index < 0)
                {
                    index = 0;
                    indexValue = input[index];
                    input.RemoveAt(index);
                    input.Insert(index, input[input.Count - 1]);
                }
                else if (index >= input.Count)
                {
                    index = input.Count - 1;
                    indexValue = input[index];
                    input.RemoveAt(input.Count - 1);
                    input.Add(input[0]);
                }
                else
                {
                    indexValue = input[index];
                    input.RemoveAt(index);
                }
                
                sum += indexValue;
                
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= indexValue)
                    {
                        input[i] += indexValue;
                    }
                    else
                    {
                        input[i] -= indexValue;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
