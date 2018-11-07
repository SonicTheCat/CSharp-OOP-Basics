using System;

public class LightSoftware : Software
{
    private const string TYPE = "Light";
    private const double CAPACITY_CONSUMPTION_PERCENTAGE = 1.50;
    private const int MEMORY_CONSUMPTION = 2;

    public LightSoftware(string name, int capacityConsumption, int memoryConsumption) 
        : base(name,
            TYPE,
            (int)Math.Round(capacityConsumption * CAPACITY_CONSUMPTION_PERCENTAGE),
            memoryConsumption / MEMORY_CONSUMPTION)
    {
    }
}