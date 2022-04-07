using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P02._Encrypting_Password
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                string password = Console.ReadLine();

                Regex regex =
                    new Regex(
                        @"([\s\S]+?)\>(?<numbers>[0-9]{3})\|(?<lowercase>[a-z]{3})\|(?<uppercase>[A-Z]{3})\|(?<symbols>[^\>\<]{3})\<\1");
                
                Match match = regex.Match(password);

                if (!match.Success)
                {
                    Console.WriteLine("Try another password!");
                    continue;
                }

                StringBuilder newPassword = new StringBuilder();

                string numbers = match.Groups["numbers"].Value;
                string lowerCase = match.Groups["lowercase"].Value;
                string upperCase = match.Groups["uppercase"].Value;
                string symbols = match.Groups["symbols"].Value;

                newPassword.Append(numbers);
                newPassword.Append(lowerCase);
                newPassword.Append(upperCase);
                newPassword.Append(symbols);

                Console.WriteLine($"Password: {newPassword}");
            }
        }
    }
}
