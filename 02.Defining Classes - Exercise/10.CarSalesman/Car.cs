public class Car
{
    private string model;
    private Engine engine;
    private string weigth;
    private string color;

    public Car(string model, Engine engine, string weigth, string color)
    {
        this.model = model;
        this.engine = engine;
        this.weigth = weigth;
        this.color = color;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public string Weight
    {
        get { return weigth; }
        set { weigth = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public override string ToString()
    {
        return $"{model}: \n" +
            $"  {engine.Model}:\n" +
            $"    Power: {engine.Power}\n" +
            $"    Displacement: {engine.Displacement}\n" +
            $"    Efficiency: {engine.Efficiency}\n" +
            $"  Weight: {weigth}\n" +
            $"  Color: {color}";
    }
}