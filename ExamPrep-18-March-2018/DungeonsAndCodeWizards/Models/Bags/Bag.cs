using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Bag
{
    private IList<Item> listItems;

    public Bag(int capacity)
    {
        Capacity = capacity;
        listItems = new List<Item>();
    }

    public int Capacity { get; set; } = 100;

    public double Load
    {
        get
        {
            return listItems.Sum(i => i.Weight);
        }
    }

    public IReadOnlyCollection<Item> Items
    {
        get
        {
            return (IReadOnlyCollection<Item>)this.listItems;
        }
    }

    public void AddItem(Item item)
    {
        ExeptionTracker.IsBagCapacityFull(this, item);

        listItems.Add(item);
    }

    public Item GetItem(string name)
    {
        ExeptionTracker.IsBagEmpty(listItems);

        var wantedItem = listItems.FirstOrDefault(i => i.GetType().Name == name);

        ExeptionTracker.IsItemInBag(wantedItem, name);

        listItems.Remove(wantedItem);
        return wantedItem;
    }
}