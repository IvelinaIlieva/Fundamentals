using System;
using System.Text.RegularExpressions;

namespace P02._Ad_Astra
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(\||#)(?<name>[A-Za-z ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1");

            MatchCollection matches = regex.Matches(input);

            if (matches.Count == 0)
            {
                Console.WriteLine("You have food to last you for: 0 days!");
                return;
            }

            int totalCalories = 0;

            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }

            Console.WriteLine($"You have food to last you for: {totalCalories/2000} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["name"]}, Best before: {match.Groups["date"]}, Nutrition: {match.Groups["calories"]}");
            }
        }
    }
}
