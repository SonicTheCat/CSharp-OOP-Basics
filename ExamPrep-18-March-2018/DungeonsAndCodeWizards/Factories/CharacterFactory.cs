using System;

public class CharacterFactory
{
    public static Character CreateCharacter(string factio, string type, string name)
    {
        if (!Enum.TryParse(typeof(Faction), factio, out object parsedFaction))
        {
            throw new ArgumentException($"Invalid faction \"{factio}\"!");
        }

        Faction faction = (Faction)parsedFaction;
        switch (type)
        {
            case nameof(Warrior):
                return new Warrior(name, faction);
            case nameof(Cleric):
                return new Cleric(name, faction);
            default:
                throw new ArgumentException($"Invalid character type \"{type}\"!");
        }
    }
}