using System;
using System.Linq;

namespace P04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] startArr = new int[inputArr.Length / 4];
            int lastIndex = 0;
            for (int i = 0; i < startArr.Length; i++)
            {
                startArr[i] = inputArr[i];
                lastIndex++;
            }
            Array.Reverse(startArr);

            int[] midArr = new int[inputArr.Length / 2];
            for (int j = 0; j < inputArr.Length / 2; j++)
            {
                midArr[j] = inputArr[lastIndex];
                lastIndex++;
            }

            int[] endArr = new int[inputArr.Length / 4];
            for (int k = 0; k < inputArr.Length / 4; k++)
            {
                endArr[k] = inputArr[lastIndex];
                lastIndex++;
            }
            Array.Reverse (endArr);
                        
            int[] uppArr = new int[inputArr.Length / 2];
            uppArr = startArr.Concat(endArr).ToArray();
            
            int[] sum = new int[uppArr.Length];

            for (int l = 0; l < uppArr.Length; l++)
            {
                sum[l] = uppArr[l] + midArr[l];
            }                        
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
