using System;

public class TrackInfo
{
    public TrackInfo(int countOfLaps, int tracklength)
    {
        this.CountOfLaps = countOfLaps;
        this.TrackLength = tracklength;
        this.CurrentLap = 0;
        this.Weather = Weather.Sunny; 
    }

    public int CountOfLaps { get; }

    public int TrackLength { get; }

    public int CurrentLap { get; private set; }

    public Weather Weather { get; private set; }

    public void IncreaseLapsByOne()
    {
        this.CurrentLap++;
    }

    public void ChangeWeather(string newWeather)
    {
        bool isValidWeather = Enum.TryParse(typeof(Weather), newWeather, out object changedWeather);

        if (!isValidWeather)
        {
            throw new ArgumentException(Messages.InvalidWeather);
        }

        this.Weather = (Weather)changedWeather; 
    }
}