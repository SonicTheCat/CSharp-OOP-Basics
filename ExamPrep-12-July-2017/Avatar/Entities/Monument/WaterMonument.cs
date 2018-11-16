public class WaterMonument : Monument
{
    private const string POWERNAME = "Water Affinity";

    public WaterMonument(string name, int waterAffinity)
        : base(name, waterAffinity, POWERNAME)
    {
    }
}