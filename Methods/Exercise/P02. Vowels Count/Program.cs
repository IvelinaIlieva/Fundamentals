using System;
using System.Linq;

namespace P02._Vowels_Count
{
    internal class Program
    {
        static void Main()
        {
            string inputWord = Console.ReadLine();

            Console.WriteLine(GetCountOfVowels(inputWord));
        }

        static int GetCountOfVowels(string word)
        {
            char[] vowels = new[] {'a', 'o', 'u', 'e', 'i'};
            int count = 0;

            foreach (char ch in word.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
