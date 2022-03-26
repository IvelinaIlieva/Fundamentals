using System;

namespace P07._NxN_Matrix
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Print(number);
        }

        static void Print(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
