using System;
using System.Text.RegularExpressions;

namespace P02._Match_Phone_Number
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();

            MatchCollection numbers = Regex.Matches(input, pattern);

            string[] phoneNumbers = new string[numbers.Count];

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                phoneNumbers[i] = numbers[i].Value;
            }

            Console.WriteLine(string.Join(", ", phoneNumbers));
        }
    }
}
