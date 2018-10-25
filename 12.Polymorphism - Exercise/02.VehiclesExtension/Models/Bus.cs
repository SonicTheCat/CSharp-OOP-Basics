class Bus : Vehicle
{
    private const double INCREASED_CONSUMPTION = 1.4;

    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {

    }

    public override string Drive(double distance, bool isAcOn)
    {
        var consumption = this.FuelConsumptionPerKm;

        if (isAcOn)
        {
            consumption += INCREASED_CONSUMPTION; 
        }

        if (distance * consumption <= this.FuelQuantity)
        {
            this.FuelQuantity -= distance * consumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }
        return $"{this.GetType().Name} needs refueling";
    }
}