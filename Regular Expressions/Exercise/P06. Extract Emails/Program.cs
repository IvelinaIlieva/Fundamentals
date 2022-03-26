using System;
using System.Text.RegularExpressions;

namespace P06._Extract_Emails
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(^|(?<=\s))(?<user>[a-z0-9]+[\.|\-|_]?[a-z0-9]+)@(?<host>[a-z]+([\.|\-]?[a-z]+[\.|\-]?)+[a-z]+)\.(?<domain>[a-z]+-?[a-z]+)";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}
