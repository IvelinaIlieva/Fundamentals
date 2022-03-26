using System;
using System.Collections.Generic;

namespace P03._Word_Synonyms
{
    internal class Program
    {
        static void Main()
        {
            int countOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonymDictionary = new Dictionary<string, List<string>>();

            for (int i = 1; i <= countOfLines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymDictionary.ContainsKey(word))
                {
                    List<string> synonyms = new List<string>();
                    synonyms.Add(synonym);
                    synonymDictionary.Add(word, synonyms);
                }
                else
                {
                    synonymDictionary[word].Add(synonym);
                }
            }

            foreach (var item in synonymDictionary)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
