using System;
using System.Text.RegularExpressions;

namespace P01._Match_Full_Name
{
    internal class Program
    {
        static void Main()
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string input = Console.ReadLine();

            MatchCollection names = Regex.Matches(input, regex);

            foreach (Match name in names)
            {
                Console.Write($"{name} ");
            }

            Console.WriteLine();
        }
    }
}
