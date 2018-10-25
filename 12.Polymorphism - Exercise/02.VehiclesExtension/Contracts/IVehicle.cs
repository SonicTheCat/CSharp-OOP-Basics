public interface IVehicle
{
    double FuelQuantity { get; }

    double FuelConsumptionPerKm { get; }

    double TankCapacity { get; }

    string Drive(double distance);

    void Refuel(double quantity);
}