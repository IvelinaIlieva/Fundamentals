using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02._Destination_Mapper
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(=|\/)(?<destination>[A-Z][A-Za-z]{2,})\1");

            MatchCollection matches = regex.Matches(input);

            int travelPoints = 0;
            List<string> destinations = new List<string>();

            foreach (Match match in matches)
            {
                travelPoints += match.Groups["destination"].Length;
                destinations.Add(match.Groups["destination"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
