using System.Collections.Generic;
using System.Linq;

class Bag
{
    private long Capacity { get; set; }
    private long CurrentAmount { get; set; }
    private long TotalCash { get; set; }
    private long TotalGold { get; set; }
    private long TotalGems { get; set; }
    public List<Treasure> treasures = new List<Treasure>();

    public Bag(string capacity)
    {
        this.Capacity = long.Parse(capacity);
    }

    public void ParseTreasure(string type, long amount)
    {
        if (type.Length == 3)
        {
            bool balanced = IsBalanceKept(this.TotalCash, this.TotalGems, amount);
            if (balanced)
            {
                CollectTreasure("Cash", type, amount);
                this.TotalCash += amount;
            }
        }      
        else if (type.ToLower().EndsWith("gem"))
        {
            bool balanced = IsBalanceKept(this.TotalGems, this.TotalGold, amount);
            if (balanced)
            {
                CollectTreasure("Gem", type, amount);
                this.TotalGems += amount;
            }
        }
        else if (type == "Gold")
        {
            CollectTreasure("Gold", type, amount);
            this.TotalGold += amount;
        }
    }

    private void CollectTreasure(string type, string name, long amount)
    {
        var treasure = GetTreasureType(type);
        treasure.Amount += amount;

        var hasKey = treasure.Names.Any(k => k.Key.ToLower() == name.ToLower());
        if (!hasKey)
        {
            treasure.Names[name] = 0;
        }
        treasure.Names[name] += amount;
        this.CurrentAmount += amount;
    }

    private Treasure GetTreasureType(string type)
    {
        var treasure = treasures.FirstOrDefault(t => t.Type == type);
        if (treasure == null)
        {
            treasure = new Treasure(type);
            treasures.Add(treasure);
        }
        return treasure;
    }

    public bool IsBelowBagCapacity(long amount)
    {
        return amount + this.CurrentAmount <= Capacity;
    }

    public static bool IsBalanceKept(long smallerT, long biggerT, long addAmount)
    {
        return smallerT + addAmount <= biggerT;
    }

    public List<Treasure> OrderByValue()
    {
        return this.treasures.OrderByDescending(x => x.Amount).ToList(); 
    }
}