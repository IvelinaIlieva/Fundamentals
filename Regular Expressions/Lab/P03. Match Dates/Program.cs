﻿using System;
using System.Text.RegularExpressions;

namespace P03._Match_Dates
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"\b(?<day>\d{2})(.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            
            string input = Console.ReadLine();

            MatchCollection dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
