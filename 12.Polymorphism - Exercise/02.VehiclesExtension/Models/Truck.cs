using System;

public class Truck : Vehicle
{
    private const double INCREASED_CONSUMPTION = 1.6;
    private const double TANK_CAPACITY_PERCENTAGE = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption + INCREASED_CONSUMPTION, tankCapacity)
    {

    }

    public override void Refuel(double quantity)
    {
        base.Refuel(quantity);
        this.FuelQuantity -= (1 - TANK_CAPACITY_PERCENTAGE) * quantity;
    }
}