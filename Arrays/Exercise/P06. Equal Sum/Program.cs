using System;
using System.Linq;

namespace P06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                        
            bool isEqual = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int sumLeft = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft+=inputArray[j];
                }

                int sumRight = 0;
                for (int k = inputArray.Length-1; k > i; k--)
                {
                    sumRight += inputArray[k];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
