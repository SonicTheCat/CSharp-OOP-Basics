public class PressureProvider : Provider
{
    public PressureProvider(string id, double energy) 
        : base(id, energy)
    {
        this.EnergyOutput += (this.EnergyOutput / 2); 
    }
}