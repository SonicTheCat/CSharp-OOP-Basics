public class SonicHarvester : Harvester
{
    public SonicHarvester(string id, double oreOutput, double energy, int sonicFactor) 
        : base(id, oreOutput, energy)
    {
        this.EnergyRequirement /= sonicFactor; 
    }
}