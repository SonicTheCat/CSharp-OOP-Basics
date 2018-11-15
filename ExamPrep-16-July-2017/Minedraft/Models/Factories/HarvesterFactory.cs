using System;
using System.Collections.Generic;

public class HarvesterFactory
{
    public static Harvester CreateHarvester(List<string> tokens)
    {
        var type = tokens[0];
        var id = tokens[1];
        var oreOutput = double.Parse(tokens[2]);
        var energy = double.Parse(tokens[3]);

        switch (type)
        {
            case "Sonic": return new SonicHarvester(id, oreOutput, energy, int.Parse(tokens[4]));
            case "Hammer": return new HammerHarvester(id, oreOutput, energy);
            default: throw new ArgumentException("Invalid Harvester Type!"); 
        }
    }
}