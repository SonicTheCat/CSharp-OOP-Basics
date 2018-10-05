using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Team> teams = new List<Team>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
            try
            {
                switch (tokens[0])
                {
                    case "Team": teams.Add(new Team(tokens[1])); break;
                    case "Add": AddNewPlayerToTeam(tokens, teams); break;
                    case "Remove": RemovePlayer(tokens, teams); break;
                    case "Rating": ShowTeamRating(tokens[1], teams); break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    static void ShowTeamRating(string teamName, List<Team> teams)
    {
        var team = teams.FirstOrDefault(x => x.Name == teamName);
        if (team == null)
        {
            NoTeamExeption(teamName);
        }
        Console.WriteLine($"{teamName} - {team.TeamRating()}");
    }

    static void RemovePlayer(string[] tokens, List<Team> teams)
    {
        var teamName = tokens[1];
        var playerName = tokens[2];
        teams.FirstOrDefault(x => x.Name == teamName).RemovePlayer(playerName);
    }

    static void AddNewPlayerToTeam(string[] tokens, List<Team> teams)
    {
        var teamName = tokens[1];
        var playerName = tokens[2];
        var stats = tokens.Skip(3).Take(5).Select(int.Parse).ToArray();

        var team = teams.FirstOrDefault(x => x.Name == teamName);
        if (team == null)
        {
            NoTeamExeption(teamName);
        }
        team.AddPlayer(new Player(playerName, stats));
    }

    static void NoTeamExeption(string teamName)
    {
        throw new ArgumentException($"Team {teamName} does not exist.");
    }
}