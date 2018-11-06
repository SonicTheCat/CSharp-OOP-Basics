using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    private const int BOX_TIME = 20;
    private const string CRASHED_MESSAGE = "Crashed";

    private List<Driver> validDrivers;
    private List<Driver> failedDrivers;

    public RaceTower()
    {
        this.validDrivers = new List<Driver>();
        this.failedDrivers = new List<Driver>();
    }

    public TrackInfo Track { get; set; }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.Track = new TrackInfo(lapsNumber, trackLength);
    }

    public void RegisterDriver(List<string> commandArgs)
    {
        var tyreFactory = new TyreFactory();
        var tyre = tyreFactory.Create(commandArgs.Skip(4).ToArray());

        var carFactory = new CarFactory();
        var car = carFactory.Create(commandArgs.Skip(2).Take(2).ToArray(), tyre);

        this.validDrivers.Add(new DriverFactory().Create(commandArgs.Take(2).ToArray(), car));
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        var reasonToBox = commandArgs[0];
        var driverName = commandArgs[1];
        var driver = validDrivers.FirstOrDefault(x => x.Name == driverName);

        if (reasonToBox == "Refuel")
        {
            driver.Car.Refuel(double.Parse(commandArgs[2]));
        }
        else if (reasonToBox == "ChangeTyres")
        {
            var tyreFactory = new TyreFactory();
            var tyre = tyreFactory.Create(commandArgs.Skip(2).ToArray());
            driver.Car.ChangeTyres(tyre);
        }

        driver.IncreaseTime(BOX_TIME);
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        var laps = int.Parse(commandArgs[0]);
        StringBuilder sb = new StringBuilder();

        if (laps > this.Track.CountOfLaps - this.Track.CurrentLap)
        {
            throw new ArgumentException(string.Format(Messages.WrongLapsNumbers, this.Track.CurrentLap));
        }

        for (int lap = 0; lap < laps; lap++)
        {
            foreach (var driver in validDrivers)
            {
                try
                {
                    driver.CompletedLap(this.Track.TrackLength);
                }
                catch (Exception e)
                {
                    driver.Fail(e.Message);
                    failedDrivers.Add(driver);
                }
            }
            this.Track.IncreaseLapsByOne();
            RemoveFailedDrivers();

            var overtaking = TryOvertaking();

            if (!string.IsNullOrEmpty(overtaking))
            {
                sb.AppendLine(overtaking);
            }
        }

        return sb.ToString().TrimEnd();
    }

    public string GetWinner()
    {
        var winner = this.validDrivers.OrderBy(x => x.TotalTime).ToArray()[0];
        return $"{winner.Name} wins the race for {winner.TotalTime:F3} seconds.";
    }

    private string TryOvertaking()
    {
        var orderedDrivers = this.validDrivers.OrderByDescending(x => x.TotalTime).ToList();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < orderedDrivers.Count - 1; i++)
        {
            var overtakingDriver = orderedDrivers[i];
            var targetDriver = orderedDrivers[i + 1];

            bool agressiveCondition = overtakingDriver.GetType().Name == "AggressiveDriver"
              && overtakingDriver.Car.Tyre.GetType().Name == "UltrasoftTyre";

            bool enduranceCondition = overtakingDriver.GetType().Name == "EnduranceDriver"
              && overtakingDriver.Car.Tyre.GetType().Name == "HardTyre";

            if (overtakingDriver.TotalTime - targetDriver.TotalTime <= 3)
            {
                if (agressiveCondition && this.Track.Weather.ToString() != "Foggy")
                {
                    overtakingDriver.Decreasetime(3);
                    targetDriver.IncreaseTime(3);

                    sb.AppendLine($"{overtakingDriver.Name} has overtaken {targetDriver.Name} on lap {this.Track.CurrentLap}.");

                    i++;
                    continue;
                }
                else if (agressiveCondition)
                {
                    overtakingDriver.Fail(CRASHED_MESSAGE);
                    failedDrivers.Add(overtakingDriver);
                    continue;
                }
                else if (enduranceCondition && this.Track.Weather.ToString() != "Rainy")
                {
                    overtakingDriver.Decreasetime(3);
                    targetDriver.IncreaseTime(3);

                    sb.AppendLine($"{overtakingDriver.Name} has overtaken {targetDriver.Name} on lap {this.Track.CurrentLap}.");

                    i++;
                    continue;
                }
                else if (enduranceCondition)
                {
                    overtakingDriver.Fail(CRASHED_MESSAGE);
                    failedDrivers.Add(overtakingDriver);
                    continue;
                }
            }

            if (overtakingDriver.TotalTime - targetDriver.TotalTime <= 2)
            {
                overtakingDriver.Decreasetime(2);
                targetDriver.IncreaseTime(2);

                sb.AppendLine($"{overtakingDriver.Name} has overtaken {targetDriver.Name} on lap {this.Track.CurrentLap}.");

                i++;
            }
        }
        RemoveFailedDrivers();
        return sb.ToString().TrimEnd();
    }

    private void RemoveFailedDrivers()
    {
        foreach (var driver in this.failedDrivers)
        {
            if (this.validDrivers.Contains(driver))
            {
                this.validDrivers.Remove(driver);
            }
        }
    }

    public string GetLeaderboard()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Lap {this.Track.CurrentLap}/{this.Track.CountOfLaps}");

        var orderedDrivers = this.validDrivers
             .OrderBy(x => x.TotalTime); 

        var position = 1;
        foreach (var driver in orderedDrivers)
        {
            sb.AppendLine($"{position++} {driver.ToString()}");
        }
        for (int i = failedDrivers.Count - 1; i >= 0; i--)
        {
            sb.AppendLine($"{position++} {failedDrivers[i].ToString()}");
        }
        return sb.ToString().TrimEnd();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        this.Track.ChangeWeather(commandArgs[0]);
    }
}