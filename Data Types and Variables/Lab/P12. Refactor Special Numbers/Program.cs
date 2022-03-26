using System;

namespace P12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sumOfDigit = 0;
                int currNum = i;

                while (currNum > 0)
                {
                    sumOfDigit += currNum % 10;
                    currNum /= 10;
                }
                bool isSpecial = (sumOfDigit == 5) || (sumOfDigit == 7) || (sumOfDigit == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
