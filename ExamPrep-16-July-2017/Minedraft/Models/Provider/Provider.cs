using System;
using System.Text;

public abstract class Provider : Identity
{
    private const int ENERGY_MAX_VALUE = 10000;

    private double energyOutput;

    protected Provider(string id, double energy) 
        : base(id)
    {
        this.EnergyOutput = energy;
    }

    public double EnergyOutput
    {
        get
        {
            return this.energyOutput;
        }
        protected set
        {
            if (value < 0 || value >= ENERGY_MAX_VALUE)
            {
                throw new ArgumentException
                   ($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"{this.GetType().Name.Replace("Provider", "")} Provider - {this.Id}");
        builder.Append($"Energy Output: {this.EnergyOutput}");

        return builder.ToString();
    }
}