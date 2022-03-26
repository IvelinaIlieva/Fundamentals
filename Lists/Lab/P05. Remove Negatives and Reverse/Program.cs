using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(number => number < 0);
            numbers.Reverse();

            Console.WriteLine(numbers.Count == 0 ? "empty" : string.Join(" ", numbers));
        }
    }
}
