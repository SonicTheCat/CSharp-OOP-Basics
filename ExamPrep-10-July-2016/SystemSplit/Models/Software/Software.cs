public abstract class Software
{
    protected Software(string name, string type, int capacityConsumption, int memoryConsumption)
    {
        this.Name = name;
        this.Type = type;
        this.CapacityConsumption = capacityConsumption;
        this.MemoryConsumption = memoryConsumption;
    }

    public string Name { get; }

    public string Type { get; }

    public int CapacityConsumption { get; }

    public int MemoryConsumption { get; }
}