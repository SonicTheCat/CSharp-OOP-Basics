using System;

public class PowerHardware : Hardware
{
    private const string TYPE = "Power";
    private const double MAXIMUM_CAPACITY_PERCENTAGE = 0.25;
    private const double MAXIMUM_MEMORY_PERCENTAGE = 1.75;

    public PowerHardware(string name, int maximumCapacity, int maximumMemory)
        : base(name,
            TYPE,
            (int)Math.Round(maximumCapacity * MAXIMUM_CAPACITY_PERCENTAGE),
            (int)Math.Ceiling(maximumMemory * MAXIMUM_MEMORY_PERCENTAGE))
    {
    }
}