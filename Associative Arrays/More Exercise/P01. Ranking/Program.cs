using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Ranking
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> contestInfo = new Dictionary<string, string>();

            string command;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] contestArgs = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string contest = contestArgs[0];
                string password = contestArgs[1];

                if (!contestInfo.ContainsKey(contest))
                {
                    contestInfo[contest] = password;
                }
            }

            SortedDictionary<string, Dictionary<string, int>> userContestList = new SortedDictionary<string, Dictionary<string, int>>();
            
            string commandNext;
            while ((commandNext = Console.ReadLine()) != "end of submissions")
            {
                string[] contestArgs = commandNext.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = contestArgs[0];
                string password = contestArgs[1];
                string username = contestArgs[2];
                int points = int.Parse(contestArgs[3]);

                if (!contestInfo.ContainsKey(contest))
                {
                    continue;
                }
                else
                {
                    if (contestInfo[contest] != password)
                    {
                        continue;
                    }

                    if (!userContestList.ContainsKey(username))
                    {
                        userContestList[username] = new Dictionary<string, int>();
                    }

                    if (!userContestList[username].ContainsKey(contest))
                    {
                        userContestList[username][contest] = points;
                    }

                    if (userContestList[username][contest] < points)
                    {
                        userContestList[username][contest] = points;
                    }
                }
            }

            Dictionary<string, int> userPoints = new Dictionary<string, int>(){};

            foreach (var pair in userContestList)
            {
                if (!userPoints.ContainsKey(pair.Key))
                {
                    userPoints[pair.Key] = 0;
                }
                userPoints[pair.Key] += pair.Value.Values.Sum();
            }

            int maxPoints = userPoints.Values.Max();

            foreach (var kvp in userPoints)
            {
                if (kvp.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {maxPoints} points.");
                }
            }

            Console.WriteLine("Ranking:");

            foreach (var kvp in userContestList)
            {
                Console.WriteLine(kvp.Key);

                foreach (var item in kvp.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
