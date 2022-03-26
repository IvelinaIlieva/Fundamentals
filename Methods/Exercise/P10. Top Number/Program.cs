using System;

namespace P10._Top_Number
{
    internal class Program
    {
        static void Main()
        {
            const int Divider = 8;
            int number = int.Parse(Console.ReadLine());

            PrintTheTopNumbers(number,Divider);
        }

        static bool CheckTheSumOfDigits(int number, int div)
        {
            bool isTop = false;
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % div == 0)
            {
                isTop = true;
            }
            return isTop;
        }

        static bool CheckIfHasOddDigits(int number)
        {
            bool isTop = false;
            int num = 0;

            while (number > 0)
            {
                num = number % 10;

                if (number % 2 != 0)
                {
                    isTop = true;
                }

                number /= 10;
            }

            return isTop;
        }

        static void PrintTheTopNumbers(int number, int div)
        {
            for (int i = 0; i < number; i++)
            {
                if (CheckTheSumOfDigits(i, div) && CheckIfHasOddDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
