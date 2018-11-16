public class AirMonument : Monument
{
    private const string POWERNAME = "Air Affinity";

    public AirMonument(string name, int airAffinity)
        : base(name, airAffinity, POWERNAME)
    {
    }    
}