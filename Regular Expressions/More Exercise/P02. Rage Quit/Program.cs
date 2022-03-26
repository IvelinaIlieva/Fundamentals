using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P02._Rage_Quit
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Regex groupOfSymbols = new Regex(@"(\D{1,20})(\d+)");

            MatchCollection matches = groupOfSymbols.Matches(input);

            StringBuilder output = new StringBuilder();

            List<char> uniqueChars = new List<char>();

            foreach (Match match in matches)
            {
                string symbols = match.Groups[1].Value.ToUpper();
                int count = int.Parse(match.Groups[2].Value);

                for (int i = 1; i <= count; i++)
                {
                    output.Append(symbols);
                }

                if (count > 0)
                {
                    foreach (char ch in symbols)
                    {
                        if (!uniqueChars.Contains(ch))
                        {
                            uniqueChars.Add(ch);
                        }
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueChars.Count}");
            Console.WriteLine(output);
        }
    }
}
