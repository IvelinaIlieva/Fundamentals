using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.MixedUpLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            list2.Reverse();

            int lenght = Math.Min(list1.Count, list2.Count);
            List<int> addList = new List<int>();

            for (int i = 0; i < lenght * 2; i++)
            {
                if (i % 2 == 0)
                {
                    addList.Add(list1[0]);
                    list1.RemoveAt(0);
                }
                else
                {
                    addList.Add(list2[0]);
                    list2.RemoveAt(0);
                }
            }

            int startNum = 0;
            int endNum = 0;

            if (list1.Count == 2)
            {
                startNum = Math.Min(list1[0], list1[1]);
                endNum = Math.Max(list1[0], list1[1]);
            }
            else if (list2.Count == 2)
            {
                startNum = Math.Min(list2[0], list2[1]);
                endNum = Math.Max(list2[0], list2[1]);
            }

            List<int> containConditionNumbers = addList.FindAll(num => num > startNum && num < endNum);
            containConditionNumbers.Sort();

            Console.WriteLine(string.Join(" ", containConditionNumbers));
        }
    }
}
