using System;
using System.Linq;

namespace P08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            int[] newArray = new int[2];

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    int sum = inputArray[i] + inputArray[j];

                    if (sum == magicSum)
                    {
                        newArray[0] = inputArray[i];
                        newArray[1] = inputArray[j];
                        Console.WriteLine(String.Join(" ", newArray));
                    }
                }                                
            }
        }
    }
}
