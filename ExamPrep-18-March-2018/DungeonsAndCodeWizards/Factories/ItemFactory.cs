using System;

public  class ItemFactory
{
    public static Item CreateItem(string type)
    {
        switch (type)
        {
            case nameof(ArmorRepairKit):
                return new ArmorRepairKit();
            case nameof(HealthPotion):
                return new HealthPotion();
            case nameof(PoisonPotion):
                return new PoisonPotion();
            default:
                throw new ArgumentException($"Invalid item \"{type}\"!");
        }
    }
}

