using System;

namespace P03._Substring
{
    internal class Program
    {
        static void Main()
        {
            string wordToRemove = Console.ReadLine();

            string input = Console.ReadLine();

            while (input.Contains(wordToRemove))
            {
                int startIndex = input.IndexOf(wordToRemove);

                input = input.Remove(startIndex, wordToRemove.Length);
            }

            Console.WriteLine(input);
        }
    }
}
