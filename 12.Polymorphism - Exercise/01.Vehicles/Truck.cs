namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double INCREASED_CONSUMPTION = 1.6;
        private const double TANK_CAPACITY_PERCENTAGE = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption + INCREASED_CONSUMPTION)
        {

        }

        public override void Refuel(double quantity)
        {
            base.Refuel(quantity * TANK_CAPACITY_PERCENTAGE);  
        }
    }
}