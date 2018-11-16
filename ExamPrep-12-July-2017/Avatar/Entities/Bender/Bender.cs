public abstract class Bender : IPower, IBender
{
    protected Bender(string name, int power, double secondPower, string addedPowerName)
    {
        this.Name = name;
        this.PowerValue = power;
        this.AdditionalPower = secondPower;
        this.PowerName = addedPowerName;
    }

    public string Name { get; }

    public double PowerValue { get; }

    public double AdditionalPower { get; }

    public string PowerName { get; }

    public double TotalPower => this.PowerValue * this.AdditionalPower;

    public override string ToString()
    {
        return $"###{this.GetType().Name.Replace("Bender", " Bender")}: {this.Name}, Power: {this.PowerValue}, {this.PowerName}: {this.AdditionalPower:F2}";
    }
}