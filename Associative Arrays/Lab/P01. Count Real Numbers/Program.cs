using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            SortedDictionary<int, int> occurrencesDictionary = new SortedDictionary<int, int>();

            foreach (int num in list)
            {
                if (occurrencesDictionary.ContainsKey(num))
                {
                    occurrencesDictionary[num]++;
                }
                else
                {
                    occurrencesDictionary.Add(num, 1);
                }
            }

            foreach (var item in occurrencesDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
