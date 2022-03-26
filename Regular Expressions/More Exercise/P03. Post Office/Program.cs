using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03._Post_Office
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            Dictionary<char, int> lettersDictionary = new Dictionary<char, int>();

            lettersDictionary = LettersFinder(firstPart, lettersDictionary);
            lettersDictionary = LengthFinder(secondPart, lettersDictionary);
            
            Print(thirdPart, lettersDictionary);
            
        }
        static Dictionary<char, int> LettersFinder(string firstPart, Dictionary<char, int> lettersDictionary)
        {
            string pattern = @"(#|\$|\%|\*|&)[A-Z]+\1";

            Match firstMatch = Regex.Match(firstPart, pattern);

            foreach (char ch in firstMatch.Value.Substring(1, firstMatch.Length - 2))
            {
                lettersDictionary[ch] = 0;
            }

            return lettersDictionary;
        }
        static Dictionary<char, int> LengthFinder(string secondPart, Dictionary<char, int> lettersDictionary)
        {
            string pattern = @"(?<charcode>6[5-9]|[7-8][0-9]|90):(?<length>[0-1][0-9]|20)";

            MatchCollection secondMatchCollection = Regex.Matches(secondPart, pattern);

            foreach (Match match in secondMatchCollection)
            {
                char charCode = (char)int.Parse(match.Groups["charcode"].Value);
                int length = int.Parse(match.Groups["length"].Value);

                if (lettersDictionary.ContainsKey(charCode))
                {
                    lettersDictionary[charCode] = length;
                }
            }

            return lettersDictionary;
        }
        static void Print(string thirdPart, Dictionary<char, int> lettersDictionary)
        {
            string[] thirdPartArr = thirdPart.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var kvp in lettersDictionary)
            {
                char letter = kvp.Key;
                int length = kvp.Value;
                string pattern = $"^[{letter}]\\S" + "{" + $"{length}" + "}" + @"\b$";

                foreach (string word in thirdPartArr)
                {
                    Match match = Regex.Match(word, pattern);

                    if (match.Success)
                    {
                        Console.WriteLine(match);
                    }
                }
            }
        }
    }
}

