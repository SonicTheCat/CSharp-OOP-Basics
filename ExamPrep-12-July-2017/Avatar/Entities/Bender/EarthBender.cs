public class EarthBender : Bender
{
    private const string POWERNAME = "Ground Saturation";

    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power, groundSaturation, POWERNAME)
    {
    }
}