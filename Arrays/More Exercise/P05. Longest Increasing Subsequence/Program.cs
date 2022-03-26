using System;
using System.Linq;

namespace P05._Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] len = new int[input.Length];
            int[] prevIndex = new int[input.Length];
            int maxLen = 0;
            int endIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                len[i] = 1;
                prevIndex[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i] && len[i] < len[j] + 1)
                    {
                        len[i] = 1 + len[j];
                        prevIndex[i] = j;
                    }
                }
                if (maxLen < len[i])
                {
                    maxLen = len[i];
                    endIndex = i;
                }
            }
            int[] LIS = new int[maxLen];
            int finalIndex = maxLen - 1;

            while (endIndex != -1)
            {
                LIS[finalIndex] = input[endIndex];
                finalIndex--;
                endIndex = prevIndex[endIndex];
            }

            Console.WriteLine(String.Join(" ", LIS));
        }
    }
}

