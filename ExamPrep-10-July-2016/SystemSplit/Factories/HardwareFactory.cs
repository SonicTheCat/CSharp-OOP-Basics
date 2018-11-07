using System; 

public class HardwareFactory
{
    public Hardware Create(string[] tokens)
    {
        var type = tokens[0];
        var name = tokens[1];
        var capacity = int.Parse(tokens[2]);
        var memory = int.Parse(tokens[3]);

        switch (type)
        {
            case "RegisterPowerHardware": return new PowerHardware(name, capacity, memory); 
            case "RegisterHeavyHardware": return new HeavyHardware(name, capacity, memory); 
            default: throw new ArgumentException("Invalid hardware type"); 
        }
    }
}