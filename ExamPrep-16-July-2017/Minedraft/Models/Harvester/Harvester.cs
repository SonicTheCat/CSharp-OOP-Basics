using System;
using System.Text;

public abstract class Harvester : Identity
{
    private const int ENERGY_MAX_VALUE = 20000;

    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energy)
        : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energy;
    }

    public double OreOutput
    {
        get
        {
            return this.oreOutput;
        }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException
                    ($"Harvester is not registered, because of it's {nameof(OreOutput)}");
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get
        {
            return this.energyRequirement;
        }
        protected set
        {
            if (value < 0 || value > ENERGY_MAX_VALUE)
            {
                throw new ArgumentException
                    ($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
            }
            this.energyRequirement = value;
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"{this.GetType().Name.Replace("Harvester", "")} Harvester - {this.Id}");
        builder.AppendLine($"Ore Output: {this.OreOutput}");
        builder.Append($"Energy Requirement: {this.EnergyRequirement}");

        return builder.ToString();
    }
}