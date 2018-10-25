namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumption;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumptionPerKm { get; protected set; }

        public string Drive(double distance)
        {
            var consumption = this.FuelConsumptionPerKm;
            var msg = $"{this.GetType().Name} needs refueling";

            if (distance * consumption <= this.FuelQuantity)
            {
                msg = $"{this.GetType().Name} travelled {distance} km";
                this.FuelQuantity -= distance * consumption;
            }
            return msg;
        }

        public virtual void Refuel(double quantity)
        {
            this.FuelQuantity += quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }
    }
}