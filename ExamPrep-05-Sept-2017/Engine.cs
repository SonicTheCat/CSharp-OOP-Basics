using System;
using System.Linq;

public class Engine
{
    private RaceTower raceTower;

    public Engine(RaceTower race)
    {
        this.raceTower = race;
    }

    public void Run()
    {
        while (this.raceTower.Track.CurrentLap < this.raceTower.Track.CountOfLaps)
        {
            var commands = Console.ReadLine().Split();
            var tokens = commands.Skip(1).ToList();

            var command = commands[0];

            try
            {
                switch (command)
                {
                    case "RegisterDriver":
                        {
                            raceTower.RegisterDriver(tokens);
                        }
                        break;
                    case "Leaderboard":
                        {
                            var result = raceTower.GetLeaderboard();
                            this.Print(result);
                        }
                        break;
                    case "CompleteLaps":
                        {
                            var result = raceTower.CompleteLaps(tokens);
                            if (!string.IsNullOrEmpty(result))
                            {
                                Print(result);
                            }
                        }
                        break;
                    case "Box":
                        {
                            raceTower.DriverBoxes(tokens);
                        }
                        break;
                    case "ChangeWeather":
                        {
                            raceTower.ChangeWeather(tokens);
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        var winner = this.raceTower.GetWinner();
        this.Print(winner);
    }

    private void Print(string value)
    {
        Console.WriteLine(value);
    }
}