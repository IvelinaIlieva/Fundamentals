﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
