using System;
using System.Linq;

namespace P05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isBigger = false;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                isBigger = true;

                for (int j = i + 1; j < inputNumbers.Length; j++)
                {
                    if (inputNumbers[i] <= inputNumbers[j])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    Console.Write($"{inputNumbers[i]} ");
                }
            }
        }
    }
}
