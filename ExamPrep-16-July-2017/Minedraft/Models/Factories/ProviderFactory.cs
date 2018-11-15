using System;
using System.Collections.Generic;

public class ProviderFactory
{
    public static Provider CreateProvider(List<string> tokens)
    {
        var type = tokens[0];
        var id = tokens[1];
        var energy = double.Parse(tokens[2]);

        switch (type)
        {
            case "Solar": return new SolarProvider(id, energy);
            case "Pressure": return new PressureProvider(id, energy);
            default: throw new ArgumentException("Invalid Provider Type!");
        }
    }
}