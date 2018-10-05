using System;
using System.Linq;

class Player
{
    private const int MIN_STAT_INT = 0;
    private const int MAX_STAT_INT = 100;
    private string[] statNames = new string[] { "Endurance", "Sprint", "Dribble", "Passing", "Shooting" };

    private string name;
    private int[] stats;

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

    private int[] Stats
    {
        get => this.stats;
        set
        {
            this.stats = new int[5];
            for (int i = 0; i < 5; i++)
            {
                if (value[i] < MIN_STAT_INT || value[i] > MAX_STAT_INT)
                {
                    throw new ArgumentException
                        ($"{statNames[i]} should be between {MIN_STAT_INT} and {MAX_STAT_INT}.");
                }
                this.stats[i] = value[i];
            }
        }
    }

    public Player(string name, int[] stats)
    {
        Name = name;
        Stats = stats;
    }

    public double PlayerRating()
    {
        return Stats.Sum() / 5.0;
    }
}