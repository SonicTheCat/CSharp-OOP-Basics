using System.Text;

class Car
{
    public string model;
    public Engine engine;
    public int weight;
    public string color;

    public Car()
    {
        this.weight = -1;
        this.color = "n/a";
    }

    public Car(string model, Engine engine)
        : this()
    {
        this.model = model;
        this.engine = engine;
    }

    public Car(string model, Engine engine, int weight)
         : this(model, engine)
    {
        this.weight = weight;
    }

    public Car(string model, Engine engine, string color)
         : this(model, engine)
    {
        this.color = color;
    }

    public Car(string model, Engine engine, int weight, string color)
        : this(model, engine)
    {
        this.weight = weight;
        this.color = color;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.model}:");
        sb.Append(this.engine.ToString());
        sb.Append($"  Weight: ");
        sb.AppendLine(this.weight == -1 ? "n/a" : this.weight.ToString());
        sb.Append($"  Color: {this.color}");

        return sb.ToString();
    }
}