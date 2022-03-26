using System;
using System.Globalization;

namespace P04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", CalculateTheNumbers(countOfNumbers)));
        }

        static int[] CalculateTheNumbers(int num)
        {
            int[] row = new int[num];

            for (int i = 0; i < num; i++)
            {
                if (i == 0 || i == 1)
                {
                    row[i] = 1;
                }
                else if (i == 2)
                {
                    row[i] = 2;
                }
                else
                {
                    row[i] = row[i - 1] + row[i - 2] + row[i - 3];
                }
            }
            return row;
        }
    }
}
