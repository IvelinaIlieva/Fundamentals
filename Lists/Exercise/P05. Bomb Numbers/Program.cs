using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Bomb_Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombAndPower = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombAndPower[0];
            int bombPower = bombAndPower[1];

            int bombIndex = numbers.IndexOf(bombNumber);

            while (bombIndex != -1)
            {
                int leftIndex = bombIndex - bombPower;
                if (bombIndex - bombPower < 0)
                {
                    leftIndex = 0;
                }

                int rightIndex = bombIndex + bombPower;
                if (bombIndex + bombPower >= numbers.Count)
                {
                    rightIndex = numbers.Count - 1;
                }

                numbers.RemoveRange(leftIndex, rightIndex + 1 - leftIndex);

                bombIndex = numbers.IndexOf(bombNumber);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}

