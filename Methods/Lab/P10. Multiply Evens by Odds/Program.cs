using System;
using System.Linq;

namespace P10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetSumOfEvenOddDigits(input));
        }
        static int GetSumOfEvenDigits(int numbers)
        {
            int sumOfEvenDigits = 0;

            int digit = numbers % 10;
            while (numbers != 0)
            {
                if (digit % 2 != 0)
                {
                    sumOfEvenDigits += digit;
                }
                numbers /= 10;
                digit = numbers % 10;
            }
            return Math.Abs(sumOfEvenDigits);
        }
        static int GetSumOfOddDigits(int numbers)
        {
            int sumOfOddDigits = 0;

            int digit = numbers % 10;
            while (numbers != 0)
            {
                if (digit % 2 == 0)
                {
                    sumOfOddDigits += digit;
                }
                numbers /= 10;
                digit = numbers % 10;
            }

            return Math.Abs(sumOfOddDigits);
        }
        static int GetSumOfEvenOddDigits(int numbers)
        {
            int result = GetSumOfOddDigits(numbers) * GetSumOfEvenDigits(numbers);
            return result;
        }
    }
}
