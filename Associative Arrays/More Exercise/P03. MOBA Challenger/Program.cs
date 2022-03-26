using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._MOBA_Challenger
{
    internal class Program
    {
        static void Main()
        {
            //key = player; value.key = position, value.value = points
            Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

            string command;
            while ((command = Console.ReadLine()) != "Season end")
            {
                if (command.Contains('>'))
                {
                    string[] playerArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    PlayerPool(playerArgs, playerPool);
                }

                if(!command.Contains('>'))
                {
                    string[] fightArgs = command.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    Fight(fightArgs, playerPool);
                }
            }

            Dictionary<string, int> totalSkills = TotalSkills(playerPool);

            foreach (var player in totalSkills.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");

                foreach (var pair in playerPool[player.Key].OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }
        }

        static void PlayerPool(string[] playerArgs, Dictionary<string, Dictionary<string, int>> playerPool)
        {
            string player = playerArgs[0];
            string position = playerArgs[1];
            int skills = int.Parse(playerArgs[2]);

            if (!playerPool.ContainsKey(player))
            {
                playerPool.Add(player, new Dictionary<string, int>());
            }

            if (!playerPool[player].ContainsKey(position))
            {
                playerPool[player].Add(position, skills);
            }
            
            if (playerPool[player][position] < skills)
            {
                playerPool[player][position] = skills;
            }
        }

        static void Fight(string[] playerArgs, Dictionary<string, Dictionary<string, int>> playerPool)
        {
            string playerOne = playerArgs[0];
            string playerTwo = playerArgs[1];

            string playerToRemove = string.Empty;

            if (playerPool.ContainsKey(playerOne) && playerPool.ContainsKey(playerTwo))
            {
                foreach (var position in playerPool[playerOne])
                {
                    if (playerPool[playerTwo].ContainsKey(position.Key))
                    {
                        int totalSkillsPlOne = playerPool[playerOne].Values.Sum();
                        int totalSkillsPlTwo = playerPool[playerTwo].Values.Sum();

                        if (totalSkillsPlOne > totalSkillsPlTwo)
                        {
                            playerToRemove = playerTwo;
                        }
                        else if (totalSkillsPlOne < totalSkillsPlTwo)
                        {
                            playerToRemove = playerOne;
                        }
                    }
                }
            }

            playerPool.Remove(playerToRemove);
        }

        static Dictionary<string, int> TotalSkills(Dictionary<string, Dictionary<string, int>> playerPool)
        {
            Dictionary<string, int> totalSkills = new Dictionary<string, int>();

            foreach (var pair in playerPool)
            {
                if (!totalSkills.ContainsKey(pair.Key))
                {
                    totalSkills[pair.Key] = 0;
                }
                totalSkills[pair.Key] += pair.Value.Values.Sum();
            }
            return totalSkills;
        }
    }
}
