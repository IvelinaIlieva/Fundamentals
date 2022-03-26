using System;
using System.Linq;

namespace P07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int counter = 0;
            int maxCounter = counter;
            int digit = 0;

            for (int i = 0; i < inputArray.Length - 1; i++) //7
            {
                if (inputArray[i] == inputArray[i + 1])
                {
                    counter++;
                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                        digit = inputArray[i];
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            int[] array = new int[maxCounter + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = digit;
            }

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
