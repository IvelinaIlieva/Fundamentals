using System;

namespace P01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int[] array = new int[countOfLines];
            int sumOFPassengers = 0;

            for (int i = 0; i < countOfLines; i++)
            {
                int numToArray = int.Parse(Console.ReadLine());
                sumOFPassengers += numToArray;
                array[i] = numToArray;
            }
            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine(sumOFPassengers);
        }
    }
}
