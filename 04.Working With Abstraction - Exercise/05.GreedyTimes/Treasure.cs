using System.Collections.Generic;
using System.Linq;

class Treasure
{
    public string Type { get; set; }
    public long Amount { get; set; }
    public Dictionary<string,long> Names { get; set; }

    public Treasure(string type)
    {
        Type = type;
        Names = new Dictionary<string, long>();
    }

    public override string ToString()
    {
        var result = string.Empty;
        result += $"<{Type}> ${Amount}";
        foreach (var kvp in Names.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
        {
          result+= $"\n##{kvp.Key} - {kvp.Value}";
        }

        return result; 
    }
}