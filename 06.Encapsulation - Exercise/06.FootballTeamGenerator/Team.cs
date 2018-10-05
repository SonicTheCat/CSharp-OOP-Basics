using System;
using System.Collections.Generic;
using System.Linq;

class Team
{
    private string name;
    private List<Player> players;

    public Team(string name)
    {
        this.Name = name;
        this.players = new List<Player>();
    }

    public string Name
    {
        get => this.name;
        set
        {
            if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            this.name = value;
        }
    }

    public double TeamRating()
    {
        var sum = players.Sum(p => p.PlayerRating());
        return Math.Round(sum, 0);
    }

    public void AddPlayer(Player player)
    {
        this.players.Add(player);
    }

    public void RemovePlayer(string name)
    {
        var player = this.players.FirstOrDefault(x => x.Name == name);
        if (player == null)
        {
            throw new ArgumentException($"Player {name} is not in {this.name} team.");
        }
        this.players.Remove(player);
    }
}