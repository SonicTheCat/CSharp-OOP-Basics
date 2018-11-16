public class WaterBender : Bender
{
    private const string POWERNAME = "Water Clarity";

    public WaterBender(string name, int power, double waterClarity)
        : base(name, power,waterClarity,POWERNAME)
    {   
    }
}