public class FireBender : Bender
{
    private const string POWERNAME = "Heat Aggression";

    public FireBender(string name, int power, double heatAggression)
        : base(name, power, heatAggression, POWERNAME)
    {
    }
}