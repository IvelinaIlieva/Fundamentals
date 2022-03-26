using System;

namespace P05._Multiplication_Sign
{
    internal class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Print(number1, number2, number3);
        }

        static bool IsZero(int num1, int num2, int num3)
        {
            bool isZero = num1 == 0 || num2 == 0 || num3 == 0;
            return isZero;
        }

        static bool IsNegative(int num1, int num2, int num3)
        {
            bool isNegative;
            if (num1 < 0 && num2 > 0 && num3 > 0 
                || num1 > 0 && num2 < 0 && num3 > 0
                || num1 > 0 && num2 > 0 && num3 < 0
                || num1 < 0 && num2 < 0 && num3 < 0)
            {
                isNegative = true;
            }
            else
            {
                isNegative = false;
            }
            
            return isNegative;
        }

        static bool IsPositive(int num1, int num2, int num3)
        {
            bool isPositive;
            if (num1 < 0 && num2 < 0 && num3 > 0
            || num1 > 0 && num2 < 0 && num3 < 0
            || num1 < 0 && num2 > 0 && num3 < 0
            || num1 > 0 && num2 > 0 && num3 > 0)
            {
                isPositive = true;
            }
            else
            {
                isPositive = false;
            }
            
            return isPositive;
        }

        static void Print(int num1, int num2, int num3)
        {
            if (IsZero(num1, num2, num3))
            {
                Console.WriteLine("zero");
            }
            else if (IsNegative(num1, num2, num3))
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
