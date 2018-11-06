using System;

public class Car
{
    private const double TANK_CAPACITY = 160;

    private double fuelAmount;

    public Car(int horsePower, double fuelAmount, Tyre tyre)
    {
        this.Hp = horsePower;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public int Hp { get; }

    public double FuelAmount
    {
        get
        {
            return this.fuelAmount;
        }
        private set
        {
            if (value > TANK_CAPACITY)
            {
                this.fuelAmount = TANK_CAPACITY;
            }
            else if (value < 0)
            {
                throw new ArgumentException(Messages.FuelIsOver);
            }
            else
            {
                this.fuelAmount = value;
            }
        }
    }

    public Tyre Tyre { get; private set; }

    public void Refuel(double givenFuel)
    {
        this.FuelAmount += givenFuel;
    }

    public void ReduceFuel(double givenFuel)
    {
        this.FuelAmount -= givenFuel;
    }

    public void ChangeTyres(Tyre tyre)
    {
        this.Tyre = tyre;
    }
}