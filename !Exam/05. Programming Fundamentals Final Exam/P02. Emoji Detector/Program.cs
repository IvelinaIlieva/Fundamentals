using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace P02._Emoji_Detector
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> digits = input.Where(char.IsDigit).Select(x => x - '0').ToList();

            BigInteger multiply = new BigInteger(1);

            foreach (int digit in digits)
            {
                multiply *= digit;
            }

            Console.WriteLine($"Cool threshold: {multiply}");

            Regex regex = new Regex(@"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1");

            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in matches)
            {
                string currEmoji = match.Groups["emoji"].Value;

                int sumOfChars = 0;

                foreach (char ch in currEmoji)
                {
                    sumOfChars += ch;
                }

                if (sumOfChars > multiply)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
