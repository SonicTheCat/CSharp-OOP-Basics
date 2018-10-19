public class Tesla : Car, IElectricCar
{
    public int Battery { get; }

    public Tesla(string model, string color, int battery) : base(model, color)
    {
        this.Battery = battery; 
    }

    protected override string GetCarInfo()
    {
        return base.GetCarInfo() + $" with {this.Battery} Batteries"; 
    }
}