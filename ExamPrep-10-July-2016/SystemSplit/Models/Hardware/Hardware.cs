using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Hardware
{
    private List<Software> implementedSoftwares;

    protected Hardware(string name, string type, int maximumCapacity, int maximumMemory)
    {
        this.Name = name;
        this.Type = type;
        this.CurrentCapacity = maximumCapacity;
        this.CurrentMemory = maximumMemory;
        this.TotalCapacity = maximumCapacity;
        this.TotalMemory = maximumMemory;
        this.implementedSoftwares = new List<Software>();
    }

    public string Name { get; }

    public string Type { get; }

    private int CurrentCapacity { get; set; }

    private int CurrentMemory { get; set; }

    public int TotalCapacity { get; }

    public int TotalMemory { get; }

    public int CountOfImplementedSoftwares => this.implementedSoftwares.Count;

    public int ExpressSoftwareCount => this.implementedSoftwares.Where(x => x.Type == "Express").ToArray().Length;

    public int LightSoftwareCount => this.implementedSoftwares.Where(x => x.Type == "Light").ToArray().Length;

    public int MemoryTaken => this.implementedSoftwares.Sum(x => x.MemoryConsumption);

    public int CapacityTaken => this.implementedSoftwares.Sum(x => x.CapacityConsumption);

    public void ImplementSoftware(Software software)
    {
        if (software.CapacityConsumption <= this.CurrentCapacity
            && software.MemoryConsumption <= this.CurrentMemory)
        {
            this.CurrentCapacity -= software.CapacityConsumption;
            this.CurrentMemory -= software.MemoryConsumption;

            this.implementedSoftwares.Add(software);
        }
    }

    public void ReleaseSoftware(string softwareName)
    {
        var software = this.implementedSoftwares.FirstOrDefault(x => x.Name == softwareName);
        ExeptionTracker.IsValidSoftware(software);

        this.implementedSoftwares.Remove(software);

        this.CurrentCapacity += software.CapacityConsumption;
        this.CurrentMemory += software.MemoryConsumption;
    }

    public override string ToString()
    {
        var expressSoftCount = this.implementedSoftwares.Where(x => x.Type == "Express").ToArray().Length;
        var lightSoftCount = this.implementedSoftwares.Where(x => x.Type == "Light").ToArray().Length;

        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Hardware Component - {this.Name}");
        sb.AppendLine($"Express Software Components - {expressSoftCount}");
        sb.AppendLine($"Light Software Components - {lightSoftCount}");
        sb.AppendLine($"Memory Usage: {this.MemoryTaken} / {this.TotalMemory}");
        sb.AppendLine($"Capacity Usage: {this.CapacityTaken} / {this.TotalCapacity}");
        sb.AppendLine($"Type: {this.Type}");
        if (this.implementedSoftwares.Count > 0)
        {
            sb.AppendLine
                ($"Software Components: {string.Join(", ", this.implementedSoftwares.Select(x => x.Name))}");
        }
        else
        {
            sb.AppendLine("Software Components: None");
        }
        return sb.ToString().TrimEnd();
    }
}