public abstract class Car : ICar
{
    public string Model { get;}
    public string Color { get; }

    public Car(string model, string color)
    {
        this.Model = model;
        this.Color = color; 
    }

    public string Start()
    {
        return "Engine start"; 
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    protected virtual string GetCarInfo()
    {
        return $"{this.Color} {this.GetType().Name} {this.Model}"; 
    }

    public override string ToString()
    {
        return GetCarInfo() + "\n" + Start() + "\n" + Stop(); 
    }
}