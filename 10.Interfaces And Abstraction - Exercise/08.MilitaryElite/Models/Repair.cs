using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public string PartName { get; }
        public int Hours { get; }

        public Repair(string partName, int hours)
        {
            PartName = partName;
            Hours = hours;
        }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {Hours}";
        }
    }
}
