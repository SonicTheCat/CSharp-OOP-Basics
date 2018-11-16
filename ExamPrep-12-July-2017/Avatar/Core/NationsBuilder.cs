using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, double> nationsPoints;
    private List<Bender> benders;
    private List<Monument> monuments;
    private BenderFactory benderFactory;
    private MonumentFactory monumentFactory;
    private List<string> wars;

    public NationsBuilder()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
        this.benderFactory = new BenderFactory();
        this.monumentFactory = new MonumentFactory();
        this.wars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var bender = this.benderFactory.CreateBender(benderArgs);
        this.benders.Add(bender);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var monument = this.monumentFactory.CreateMonument(monumentArgs);
        monuments.Add(monument);
    }

    public string GetStatus(string nationsType)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(nationsType + " Nation");

        var wantedBenders = GetElementsFromCollection(this.benders, nationsType);
        sb.AppendLine(StatusAppendLines(wantedBenders, "Benders"));

        var wantedMonuments = GetElementsFromCollection(this.monuments, nationsType);
        sb.AppendLine(StatusAppendLines(wantedMonuments, "Monuments"));

        return sb.ToString().TrimEnd();
    }

    public void IssueWar(string nationsType)
    {
        this.nationsPoints = new Dictionary<string, double>();
        this.wars.Add(nationsType);

        GetNationsInDictionary("Air");
        GetNationsInDictionary("Water");
        GetNationsInDictionary("Fire");
        GetNationsInDictionary("Earth");

        var winnerNation = this.nationsPoints
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, y => y.Value)
            .First().Key;

        this.benders = DeleteLostNations(this.benders, winnerNation);
        this.monuments = DeleteLostNations(this.monuments, winnerNation);
    }

    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < this.wars.Count; i++)
        {
            sb.AppendLine($"War {i + 1} issued by {this.wars[i]}"); 
        }

        return sb.ToString().TrimEnd();
    }

    private List<T> GetElementsFromCollection<T>(List<T> collection, string nationsType)
    {
        return collection
             .Where(x => x.GetType().Name.StartsWith(nationsType))
             .ToList();
    }

    private string StatusAppendLines<T>(List<T> collection, string type)
    {
        StringBuilder sb = new StringBuilder();

        if (collection.Count > 0)
        {
            sb.AppendLine(type + ":");
            collection.ForEach(x => sb.AppendLine(x.ToString()));
        }
        else
        {
            sb.AppendLine($"{type}: None");
        }

        return sb.ToString().TrimEnd();
    }

    private List<T> DeleteLostNations<T>(List<T> collection, string winner)
    {
        return collection
            .Where(x => x.GetType().Name.StartsWith(winner))
            .Select(x => x)
            .ToList();
    }

    private void GetNationsInDictionary(string nation)
    {
        if (!this.nationsPoints.ContainsKey(nation))
        {
            this.nationsPoints[nation] = 0;
        }

        var pointsFrombenders = SumBendersPower(nation);
        if (pointsFrombenders > 0)
        {
            this.nationsPoints[nation] += pointsFrombenders;
            var pointsFromMonuments = SumMonumentsPower(nation);
            var bonus = (this.nationsPoints[nation] / 100) * pointsFromMonuments;
            this.nationsPoints[nation] += bonus;
        }
    }

    private double SumBendersPower(string bender)
    {
        return this.benders
            .Where(x => x.GetType().Name.StartsWith(bender))
            .Sum(x => x.TotalPower);
    }

    private double SumMonumentsPower(string monument)
    {
        return this.monuments
          .Where(x => x.GetType().Name.StartsWith(monument))
          .Sum(x => x.PowerValue);
    }
}