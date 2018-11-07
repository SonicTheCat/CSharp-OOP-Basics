using System;

public class HeavyHardware : Hardware
{
    private const string TYPE = "Heavy";
    private const int MAXIMUM_CAPACITY = 2;
    private const double MAXIMUM_MEMORY_PERCENTAGE = 0.75;

    public HeavyHardware(string name, int maximumCapacity, int maximumMemory)
        : base(name,
            TYPE,
            maximumCapacity * MAXIMUM_CAPACITY,
            (int)Math.Ceiling(maximumMemory * MAXIMUM_MEMORY_PERCENTAGE))
    {
    }
}