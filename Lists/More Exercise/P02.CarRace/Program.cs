using System;
using System.Linq;

namespace P02.CarRace
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lenght = input.Length / 2;

            double leftCarTime = 0d;
            double rightCarTime = 0d;

            for (int i = 0; i < lenght; i++)
            {
                leftCarTime += input[i];

                if (input[i] == 0)
                {
                    leftCarTime *= 0.8;
                }
            }

            for (int i = input.Length - 1; i > lenght; i--)
            {
                rightCarTime += input[i];

                if (input[i] == 0)
                {
                    rightCarTime *= 0.8;
                }
            }

            Console.WriteLine(leftCarTime < rightCarTime
                ? $"The winner is left with total time: {leftCarTime}"
                : $"The winner is right with total time: {rightCarTime}");
        }
    }
}
