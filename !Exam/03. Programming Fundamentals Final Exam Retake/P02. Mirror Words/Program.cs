using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02._Mirror_Words
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(@|#)(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1");

            MatchCollection matches = regex.Matches(input);

            List<string> words = new List<string>();

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                foreach (Match match in matches)
                {
                    string word1 = match.Groups["word1"].Value;
                    string word2 = match.Groups["word2"].Value;

                    char[] revWordArray = word2.ToCharArray();
                    Array.Reverse(revWordArray);
                    string reversedWord2 = new string(revWordArray);

                    if (word1.Equals(reversedWord2))
                    {
                        string pair = word1 + " <=> " + word2;
                        words.Add(pair);
                    }
                }

                if (words.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", words));
                }
            }
        }
    }
}
