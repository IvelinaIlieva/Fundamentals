using System;
using System.Collections.Generic;

namespace P02._Odd_Occurrences
{
    internal class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurrencesDictionary = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string currWord = word.ToLower();

                if (occurrencesDictionary.ContainsKey(currWord))
                {
                    occurrencesDictionary[currWord]++;
                }
                else
                {
                    occurrencesDictionary.Add(currWord, 1);
                }
            }

            foreach (var item in occurrencesDictionary)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
