using System;

public class DriverFactory
{
    public Driver Create(string[] args, Car car)
    {
        var type = args[0];
        var name = args[1];

        switch (type)
        {
            case "Aggressive": return new AggressiveDriver(name, car);
            case "Endurance": return new EnduranceDriver(name, car);
            default: throw new ArgumentException(Messages.InvalidType);
        }
    }
}