public class Car : Vehicle
{
    private const double INCREASED_CONSUMPTION = 0.9;

    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption + INCREASED_CONSUMPTION, tankCapacity)
    {

    }
}