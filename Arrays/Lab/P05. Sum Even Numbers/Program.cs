using System;
using System.Linq;

namespace P05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfEvenNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvenNum += numbers[i];
                }
            }
            Console.WriteLine(sumOfEvenNum);
        }
    }
}
