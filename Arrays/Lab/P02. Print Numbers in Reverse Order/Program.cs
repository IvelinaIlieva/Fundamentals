using System;
using System.Linq;

namespace P02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int[] itemArray = new int[countOfNumbers];

            for (int i = 0; i < countOfNumbers; i++)
            {
                int items = int.Parse(Console.ReadLine());
                itemArray[i] = items;
            }

            for (int j = countOfNumbers - 1; j >= 0; j--)
            {
                Console.Write($"{itemArray[j]} ");
            }
            Console.WriteLine();
        }
    }
}
