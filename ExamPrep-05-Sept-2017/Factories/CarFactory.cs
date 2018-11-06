public class CarFactory
{
    public Car Create(string[] args, Tyre tyre)
    {
        int horsePower = int.Parse(args[0]);
        double fuelAmount = double.Parse(args[1]); 

        return new Car(horsePower, fuelAmount, tyre);
    }
}