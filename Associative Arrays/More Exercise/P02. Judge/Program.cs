using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace P02._Judge
{
    internal class Program
    {
        static void Main()
        {
            //To save contest, users and points - contest = key -> user = key, points = value
            Dictionary<string, Dictionary<string, int>> contestDictionary = new Dictionary<string, Dictionary<string, int>>();

            //To save users and total points - user = key, total points = value
            Dictionary<string, int> individualStatistic = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] inputArgs = command.Split(" -> ");
                string username = inputArgs[0];
                string contest = inputArgs[1];
                int points = int.Parse(inputArgs[2]);

                if (!contestDictionary.ContainsKey(contest))
                {
                    contestDictionary[contest] = new Dictionary<string, int>();
                }

                if (!contestDictionary[contest].ContainsKey(username))
                {
                    contestDictionary[contest][username] = points;
                }

                if (contestDictionary[contest][username] < points)
                {
                    contestDictionary[contest][username] = points;
                }

                if (!individualStatistic.ContainsKey(username))
                {
                    individualStatistic[username] = 0;
                }
            }

            foreach (var pair in contestDictionary.Values)
            {
                foreach (var kvp in pair)
                {
                    individualStatistic[kvp.Key] += kvp.Value;
                }
            }

            foreach (var kvp in contestDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");

                int counter = 1;

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {item.Key} <::> {item.Value}");
                    counter++;
                }
            }

            Console.WriteLine("Individual standings:");

            int counterInd = 1;
            foreach (var kvp in individualStatistic.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counterInd}. {kvp.Key} -> {kvp.Value}");
                counterInd++;
            }
        }
    }
}
