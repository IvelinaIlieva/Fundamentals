using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P01._Winning_Ticket
{
    internal class Program
    {
        static void Main()
        {
            string[] tickets = Console.ReadLine()
                .Split(", ")
                .Select(x => x.Trim())
                .ToArray();

            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                Regex jackpotRegex = new Regex(@"@{20}|#{20}|\${20}|\^{20}");
                Regex matchesRegex = new Regex(@"(@|#|\$|\^){6,}[\s\S]+?\1{6,}");

                if (jackpotRegex.IsMatch(ticket))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{ticket.ElementAt(0)} Jackpot!");
                }
                else if (matchesRegex.IsMatch(ticket))
                {
                    Regex symbolsRegex = new Regex(@"(@{6,}|#{6,}|\${6,}|\^{6,})");

                    Match leftSymbols = symbolsRegex.Match(ticket.Substring(0, 10));
                    Match rightSymbols = symbolsRegex.Match(ticket.Substring(10));

                    int minLength = Math.Min(leftSymbols.Length, rightSymbols.Length);

                    if (minLength >= 6)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {minLength}{leftSymbols.Value.ElementAt(0)}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}