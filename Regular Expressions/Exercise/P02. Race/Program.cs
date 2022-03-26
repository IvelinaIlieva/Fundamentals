using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02._Race
{
    internal class Program
    {
        static void Main()
        {
            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> participantDict = new Dictionary<string, int>();

            foreach (string participant in participants)
            {
                if (!participantDict.ContainsKey(participant))
                {
                    participantDict[participant] = 0;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string namePattern = "[A-Za-z]+";
                string distancePattern = "\\d";

                MatchCollection participantName = Regex.Matches(input, namePattern);
                string name = string.Join("", participantName);

                MatchCollection participantDistance = Regex.Matches(input, distancePattern);
                int distance = participantDistance.Select(p => int.Parse(p.Value)).ToList().Sum();

                if (participantDict.ContainsKey(name))
                {
                    participantDict[name] += distance;
                }

            }

            participantDict = participantDict.OrderByDescending(p => p.Value).ToDictionary(n => n.Key, d => d.Value);

            Console.WriteLine($"1st place: {participantDict.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {participantDict.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {participantDict.ElementAt(2).Key}");
        }
    }
}
