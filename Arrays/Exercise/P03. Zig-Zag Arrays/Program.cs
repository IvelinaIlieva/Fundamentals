using System;
using System.Linq;

namespace P03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int[] arr1 = new int[countOfLines];
            int[] arr2 = new int[countOfLines];

            for (int i = 1; i <= countOfLines; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int num1 = numbers[0];
                int num2 = numbers[1];

                if (i % 2 != 0)
                {
                    arr1[i-1] = num1;
                    arr2[i-1] = num2;
                }
                else
                {
                    arr1[i-1] = num2;
                    arr2[i-1] = num1;
                }
            }
            Console.WriteLine(String.Join(" ",arr1));
            Console.WriteLine(String.Join(" ",arr2));
        }
    }
}
