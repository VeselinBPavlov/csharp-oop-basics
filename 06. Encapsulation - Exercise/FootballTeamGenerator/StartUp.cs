namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var teams = new List<Team>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    var data = command.Split(';', StringSplitOptions.RemoveEmptyEntries);

                    switch (data[0])
                    {
                        case "Team": AddTeam(teams, data); break;
                        case "Add":  AddPlayer(teams, data); break;
                        case "Remove": RemovePlater(teams, data);break;
                        case "Rating": ShowRating(teams, data); break;
                        default: break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void ShowRating(List<Team> teams, string[] data)
        {
            var teamName = data[1];

            var team = teams.FirstOrDefault(t => t.Name == teamName);
            if (team == null)
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }

            Console.WriteLine($"{team.Name} - {team.Rating}");
        }

        private static void RemovePlater(List<Team> teams, string[] data)
        {
            var teamName = data[1];
            var playerName = data[2];
            teams.FirstOrDefault(t => t.Name == teamName).RemovePlayer(playerName);
        }

        private static void AddPlayer(List<Team> teams, string[] data)
        {
            var teamName = data[1];
            var playerName = data[2];
            var stats = new int[5]
            {
                int.Parse(data[3]),
                int.Parse(data[4]),
                int.Parse(data[5]),
                int.Parse(data[6]),
                int.Parse(data[7])
            };
            var team = teams.FirstOrDefault(t => t.Name == teamName);
            if (team == null)
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }
            team.AddPlayer(new Player(playerName, stats));
        }

        private static void AddTeam(List<Team> teams, string[] data)
        {
            var name = data[1];
            teams.Add(new Team(name));
        }
    }
}


