using System;

public class SoftwareFactory
{
    public Software Create(string[] tokens)
    {
        var type = tokens[0];
        var name = tokens[2];
        var capacity = int.Parse(tokens[3]); 
        var memory = int.Parse(tokens[4]);

        switch (type)
        {
            case "RegisterExpressSoftware": return new ExpressSoftware(name, capacity, memory);
            case "RegisterLightSoftware": return new LightSoftware(name, capacity, memory);

            default: throw new ArgumentException("Invalid software type!"); 
        }
    }
}