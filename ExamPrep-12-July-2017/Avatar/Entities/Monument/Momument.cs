public abstract class Monument : IPower, IName
{
    protected Monument(string name, double powerValue, string powerName)
    {
        this.Name = name;
        this.PowerValue = powerValue;
        this.PowerName = powerName; 
    }

    public string Name { get; }

    public double PowerValue { get; }

    public double TotalPower => this.PowerValue;

    public string PowerName { get; }

    public override string ToString()
    {
        return $"###{this.GetType().Name.Replace("Monument", " Monument")}: {this.Name}, {this.PowerName}: {this.PowerValue}";
    }
}