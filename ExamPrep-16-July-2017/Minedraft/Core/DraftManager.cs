using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters;
    private List<Provider> providers;

    private double totalStoredEnergy;
    private double totalMinedOre;
    private Modes mode;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.totalStoredEnergy = 0d;
        this.totalMinedOre = 0d;
        this.mode = Modes.Full;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var harvester = HarvesterFactory.CreateHarvester(arguments);
            this.harvesters.Add(harvester);
            return $"Successfully registered {harvester.GetType().Name.Replace("Harvester", "")}" +
                $" Harvester - {harvester.Id}";
        }
        catch (ArgumentException e)
        {
            return e.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var provider = ProviderFactory.CreateProvider(arguments);
            this.providers.Add(provider);
            return $"Successfully registered {provider.GetType().Name.Replace("Provider", "")}" +
                $" Provider - {provider.Id}";
        }
        catch (ArgumentException e)
        {
            return e.Message;
        }
    }

    public string Day()
    {
        var currentEnergy = this.providers.Sum(x => x.EnergyOutput);
        this.totalStoredEnergy += currentEnergy;

        var summedRequiredEnergy = this.harvesters.Sum(x => x.EnergyRequirement) * EnergyModeModifier();
        var summedOreOutput = 0d;

        if (this.totalStoredEnergy >= summedRequiredEnergy)
        {
            summedOreOutput = this.harvesters.Sum(x => x.OreOutput) * OreModeModifier();
            this.totalMinedOre += summedOreOutput;
            this.totalStoredEnergy -= summedRequiredEnergy;
        }

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {currentEnergy}");
        sb.AppendLine($"Plumbus Ore Mined: {summedOreOutput}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        if (Enum.TryParse(typeof(Modes), arguments[0], out object newMode))
        {
            this.mode = (Modes)newMode;
            return $"Successfully changed working mode to {this.mode} Mode";
        }

        throw new ArgumentException("Invalid Mode type!");
    }

    public string Check(List<string> arguments)
    {
        var wantedID = arguments[0];

        Identity element = (Identity)
            this.harvesters.FirstOrDefault(x => x.Id == wantedID)
            ??
            this.providers.FirstOrDefault(x => x.Id == wantedID);

        if (element != null)
        {
            return element.ToString();
        }

        return $"No element found with id - {wantedID}";
    }

    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return sb.ToString().Trim();
    }

    private double EnergyModeModifier()
    {
        if (this.mode == Modes.Full) return 1.0;
        else if (this.mode == Modes.Half) return 0.60;
        else return 0;
    }

    private double OreModeModifier()
    {
        if (this.mode == Modes.Full) return 1.0;
        else if (this.mode == Modes.Half) return 0.50;
        else return 0;
    }
}