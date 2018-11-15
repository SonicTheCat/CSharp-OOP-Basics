public class HammerHarvester : Harvester
{
    private const int ORE_INCREASER = 3;
    private const int ENERGY_INCREASER = 2;

    public HammerHarvester(string id, double oreOutput, double energy)
        : base(id, oreOutput, energy)
    {
        this.OreOutput *= ORE_INCREASER;
        this.EnergyRequirement *= ENERGY_INCREASER; 
    }
}