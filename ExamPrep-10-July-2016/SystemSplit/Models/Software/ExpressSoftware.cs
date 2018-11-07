public class ExpressSoftware : Software
{
    private const string TYPE = "Express";
    private const int MEMORY_CONSUMPTION_MULTIPLIER = 2;

    public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption) 
        : base(name, TYPE, capacityConsumption, memoryConsumption * MEMORY_CONSUMPTION_MULTIPLIER)
    {
    }
}