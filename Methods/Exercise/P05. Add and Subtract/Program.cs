using System;

namespace P05._Add_and_Subtract
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetTheSubtract(num1, num2, num3));
        }

        static int GetTheSum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int GetTheSubtract(int num1, int num2, int num3)
        {
            return GetTheSum(num1, num2) - num3;
        }
    }
}
