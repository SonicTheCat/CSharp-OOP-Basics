using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Dumper
{
    private List<Hardware> dumpedHardware;
    private List<Hardware> allHardwares;

    public Dumper(List<Hardware> allHardwares)
    {
        this.dumpedHardware = new List<Hardware>();
        this.allHardwares = allHardwares;
    }

    public int PowerHardwareCount => this.dumpedHardware.Where(x => x.Type == "Power").ToArray().Length;

    public int HeavyHardwareCount => this.dumpedHardware.Where(x => x.Type == "Heavy").ToArray().Length;

    public void Dump(string hardwareName)
    {
        var hardware = allHardwares.FirstOrDefault(x => x.Name == hardwareName);
        ExeptionTracker.IsValidHardware(hardware);

        allHardwares.Remove(hardware);
        this.dumpedHardware.Add(hardware);
    }

    public void Restore(string hardwareName)
    {
        var hardware = this.dumpedHardware.FirstOrDefault(x => x.Name == hardwareName);
        ExeptionTracker.IsValidHardware(hardware);

        this.allHardwares.Add(hardware);
    }

    public void Destroy(string hardwareName)
    {
        var hardware = this.dumpedHardware.FirstOrDefault(x => x.Name == hardwareName);
        ExeptionTracker.IsValidHardware(hardware);

        this.dumpedHardware.Remove(hardware);
    }

    public string DumpAnalyze()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Dump Analysis");
        sb.AppendLine($"Power Hardware Components: {this.PowerHardwareCount}");
        sb.AppendLine($"Heavy Hardware Components: {this.HeavyHardwareCount}");
        sb.AppendLine($"Express Software Components: {this.FindSoftwareComponentsCunt("Express")}");
        sb.AppendLine($"Light Software Components: {this.FindSoftwareComponentsCunt("Light")}");

        return sb.ToString().TrimEnd();
    }

    private int FindSoftwareComponentsCunt(string type)
    {
        var count = 0;
        foreach (var hardwares in this.dumpedHardware)
        {
            if (type == "Express")
            {
                count += hardwares.ExpressSoftwareCount;
            }
            else if(type == "Light")
            {
                count += hardwares.LightSoftwareCount;
            }
        }
        return count;
    }
}