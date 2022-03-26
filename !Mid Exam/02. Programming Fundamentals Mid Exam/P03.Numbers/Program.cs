using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace P03.Numbers
{
    internal class Program
    {
        static void Main()
        {
            const int TopCount = 5;

            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double averageValue = inputList.Sum() / (double)inputList.Count;

            List<int> currList = inputList.FindAll(num => num > averageValue);
            currList.Sort();
            currList.Reverse();

            if (currList.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                if (currList.Count > TopCount)
                {
                    currList.RemoveRange(TopCount, currList.Count - TopCount);
                }

                Console.WriteLine(string.Join(" ", currList));
            }
        }
    }
}
