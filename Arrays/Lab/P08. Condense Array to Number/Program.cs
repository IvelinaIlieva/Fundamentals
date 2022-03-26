using System;
using System.Linq;

namespace P08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = inputNumbers.Length;
            int[] condensed = new int[length - 1];

            for (int j = 0; j < length - 1; j++)
            {
                for (int i = 0; i < inputNumbers.Length - 1; i++)
                {
                    condensed[i] = inputNumbers[i] + inputNumbers[i + 1];
                }
                inputNumbers = condensed;
            }
            Console.WriteLine(inputNumbers[0]);
        }
    }
}
