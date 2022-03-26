using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Merging_Lists
{
    internal class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();

            int count = Math.Min(list1.Count, list2.Count);

            List<int> mergedList = new List<int>();

            for (int i = 0; i < count * 2; i++)
            {
                if (i % 2 == 0)
                {
                    mergedList.Add(list1[0]);
                    list1.RemoveAt(0);
                }
                else
                {
                    mergedList.Add(list2[0]);
                    list2.RemoveAt(0);
                }
            }

            mergedList.AddRange(list1);
            mergedList.AddRange(list2);

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
