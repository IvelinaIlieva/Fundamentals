using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Teamwork_Projects
{
    public class Team
    {
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Member = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Member { get; set; }

        public void AddMember(string member)
        {
            this.Member.Add(member);
        }
    }
    internal class Program
    {
        static void Main()
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            List<string> members = new List<string>();

            for (int i = 1; i <= countOfTeams; i++)
            {
                string[] regTeamInfo = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creator = regTeamInfo[0];
                string name = regTeamInfo[1];

                if (teams.FindAll(t => t.Name == name).Count != 0)
                {
                    Console.WriteLine($"Team {name} was already created!");
                    continue;
                }

                if (teams.FindAll(t => t.Creator == creator).Count != 0)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                Team team = new Team(name, creator);

                Console.WriteLine($"Team {name} has been created by {creator}!");

                teams.Add(team);
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] userTeamInfo = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string member = userTeamInfo[0];
                string teamToJoin = userTeamInfo[1];

                Team team = teams.FirstOrDefault(t => t.Name == teamToJoin);

                if (team == null)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }

                if (IsMember(teams, member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                    continue;
                }
                
                team.AddMember(member);
            }

            List<Team> validTeams = teams
                .FindAll(t => t.Member.Count > 0)
                .OrderByDescending(t => t.Member.Count)
                .ThenBy(t => t.Name)
                .ToList();

            List<Team> disbandList = teams
                .FindAll(t => t.Member.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (string member in team.Member.OrderBy(t => t))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in disbandList)
            {
                Console.WriteLine(team.Name);
            }
        }

        static bool IsMember(List<Team> teams, string member)
        {
            foreach (Team t in teams)
            {
                if (t.Member.Contains(member) || t.Creator.Contains(member))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
