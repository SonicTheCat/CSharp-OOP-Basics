using System;

public class StartUp
{
    public static void Main()
    {
        var countOfLaps = int.Parse(Console.ReadLine());
        var trackLength = int.Parse(Console.ReadLine());

        RaceTower race = new RaceTower();
        race.SetTrackInfo(countOfLaps, trackLength);

        Engine engine = new Engine(race);
        engine.Run();
    }
}