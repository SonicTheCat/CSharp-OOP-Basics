using System;

public class Vehicle : IVehicle
{
    private double fuelQuantity;
    private double fuelConsumptionPerKm;
    private double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
    {
        TankCapacity = tankCapacity;
        FuelQuantity = fuelQuantity;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public double FuelQuantity
    {
        get
        {
            return this.fuelQuantity;
        }
        protected set
        {
            if (value > this.TankCapacity)
            {
                this.fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = value;
            }
        }
    }

    public double FuelConsumptionPerKm
    {
        get
        {
            return this.fuelConsumptionPerKm;
        }
        protected set
        {
            this.fuelConsumptionPerKm = value;
        }
    }

    public double TankCapacity
    {
        get
        {
            return this.tankCapacity;
        }
        protected set
        {
            this.tankCapacity = value;
        }
    }

    public virtual string Drive(double distance, bool isAcOn)
    {
        var currentConsumption = this.FuelConsumptionPerKm;

        if (distance * currentConsumption <= this.FuelQuantity)
        {
            this.FuelQuantity -= distance * currentConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }
        return $"{this.GetType().Name} needs refueling";
    }

    public virtual string Drive(double distance)
    {
        return this.Drive(distance, true);
    }

    public virtual void Refuel(double quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        else if (this.FuelQuantity + quantity > this.TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
        }
        this.FuelQuantity += quantity;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {FuelQuantity:F2}";
    }
}