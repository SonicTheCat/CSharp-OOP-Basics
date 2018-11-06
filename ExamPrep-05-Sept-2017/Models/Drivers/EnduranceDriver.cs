public class EnduranceDriver : Driver
{
    private const double FUEL_CONSUPTION_PER_KM = 1.5;

    public EnduranceDriver(string name, Car car)
        : base(name, car, FUEL_CONSUPTION_PER_KM)
    {
    }
}