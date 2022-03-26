using System;
using System.Linq;

namespace P06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfOddNumbers = 0;
            int sumOfEvenNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvenNumbers += numbers[i];
                }
                else
                {
                    sumOfOddNumbers += numbers[i];
                }
            }
            Console.WriteLine(sumOfEvenNumbers - sumOfOddNumbers);
        }
    }
}
