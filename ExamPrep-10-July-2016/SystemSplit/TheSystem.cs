using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TheSystem
{
    private List<Hardware> allHardwares;

    public TheSystem()
    {
        this.allHardwares = new List<Hardware>();
        this.Dumper = new Dumper(this.allHardwares);
    }

    public Dumper Dumper { get; }

    public void RegisterHardware(string[] tokens)
    {
        var hardFactory = new HardwareFactory();
        var hardware = hardFactory.Create(tokens);

        allHardwares.Add(hardware);
    }

    public void RegisterSoftware(string[] tokens)
    {
        var softFactory = new SoftwareFactory();
        var software = softFactory.Create(tokens);

        var hardwareName = tokens[1];
        var hardware = this.allHardwares.FirstOrDefault(h => h.Name == hardwareName);
        ExeptionTracker.IsValidHardware(hardware);

        hardware.ImplementSoftware(software);
    }

    public void ReleaseSoftwareComponent(string[] tokens)
    {
        var hardwareName = tokens[1];
        var softwareName = tokens[2];

        var hardware = this.allHardwares.FirstOrDefault(h => h.Name == hardwareName);
        ExeptionTracker.IsValidHardware(hardware);

        hardware.ReleaseSoftware(softwareName);
    }

    public string Analyze()
    {
        var countOfSoftwares = 0;
        var totalOperationalMemory = 0;
        var totalCapacityTaken = 0;

        foreach (var hardware in this.allHardwares)
        {
            countOfSoftwares += hardware.CountOfImplementedSoftwares;
            totalOperationalMemory += hardware.MemoryTaken;
            totalCapacityTaken += hardware.CapacityTaken;
        }

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("System Analysis");
        sb.AppendLine($"Hardware Components: {this.allHardwares.Count}");
        sb.AppendLine($"Software Components: {countOfSoftwares}");
        sb.AppendLine
            ($"Total Operational Memory: {totalOperationalMemory} / {this.allHardwares.Sum(x => x.TotalMemory)}");
        sb.AppendLine
          ($"Total Capacity Taken: {totalCapacityTaken} / {this.allHardwares.Sum(x => x.TotalCapacity)}");

        return sb.ToString().TrimEnd();
    }

    public string SystemSplit()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var hardware in this.allHardwares)
        {
            if (hardware.Type == "Power")
            {
                sb.AppendLine(hardware.ToString());
            }
        }

        sb.ToString().TrimEnd();
        foreach (var hardware in this.allHardwares)
        {
            if (hardware.Type == "Heavy")
            {
                sb.AppendLine(hardware.ToString());
            }
        }

        return sb.ToString().TrimEnd();
    }
}