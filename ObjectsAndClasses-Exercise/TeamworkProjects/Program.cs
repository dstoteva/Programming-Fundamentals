using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string [] splitedInput = Console.ReadLine().Split('-');

                string creatorName = splitedInput[0];
                string teamName = splitedInput[1];

                bool isTeamExists = teams.Select(x => x.Name).Contains(teamName);
                bool isCreatorExists = teams.Select(x => x.Creator).Contains(creatorName);

                if (isTeamExists == false && isCreatorExists == false)
                {
                    Team team = new Team(teamName, creatorName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (isTeamExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreatorExists)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");

                }
            }
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] splitedInput = input.Split(new string[] { "->" }, StringSplitOptions.None);
                string user = splitedInput[0];
                string team = splitedInput[1];

                bool isTeamExists = teams.Select(x => x.Name).Contains(team);
                if (!isTeamExists)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(user) || x.Creator == user);
                if (isAlreadyMember)
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    continue;
                }
                if (isTeamExists && !isAlreadyMember)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Name == team);
                    teams[indexOfTeam].Members.Add(user);
                }
            }
            List<Team> teamsWithMembers = teams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();
            List<Team> teamsWithoutMembers = teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name).ToList();

            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.Creator);
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => $"-- {x}")));
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsWithoutMembers)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
    class Team
    {
        public Team(string name, string creatorName)
        {
            Name = name;
            Creator = creatorName;
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
