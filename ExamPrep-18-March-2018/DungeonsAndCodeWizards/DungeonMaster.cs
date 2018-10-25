using System;
using System.Collections.Generic;
using System.Linq;

public class DungeonMaster
{
    private IList<Character> party;
    private IList<Item> pool;
    private int lastSurvivorRounds;

    public DungeonMaster()
    {
        this.party = new List<Character>();
        this.pool = new List<Item>();
        this.lastSurvivorRounds = 0;
    }

    public string JoinParty(string[] args)
    {
        var character = CharacterFactory.CreateCharacter(args[0], args[1], args[2]);
        party.Add(character);
        return $"{character.Name} joined the party!";
    }

    public string AddItemToPool(string[] args)
    {
        var item = ItemFactory.CreateItem(args[0]);
        pool.Add(item);
        return $"{item.GetType().Name} added to pool.";
    }

    public string PickUpItem(string[] args)
    {
        var characterName = args[0];

        var character = party.FirstOrDefault(c => c.Name == characterName);
        ExeptionTracker.DoesCharacterExist(character, characterName);

        ExeptionTracker.IsPoolEmpty(pool);

        var item = pool.Last();
        pool.Remove(item);
        character.Bag.AddItem(item);

        return $"{characterName} picked up {item.GetType().Name}!";
    }

    public string UseItem(string[] args)
    {
        var characterName = args[0];
        var itemName = args[1];

        var character = party.FirstOrDefault(c => c.Name == characterName);
        ExeptionTracker.DoesCharacterExist(character, characterName);

        var item = character.Bag.GetItem(itemName);
        character.UseItem(item);

        return $"{character.Name} used {itemName}.";

    }

    public string UseItemOn(string[] args)
    {
        string giverName = args[0];
        string receiverName = args[1];
        string itemName = args[2];

        var giver = party.FirstOrDefault(c => c.Name == giverName);
        var receiver = party.FirstOrDefault(c => c.Name == receiverName);
        ExeptionTracker.DoesCharacterExist(giver, giverName);
        ExeptionTracker.DoesCharacterExist(receiver, receiverName);

        Item item = giver.Bag.GetItem(itemName);
        giver.UseItemOn(item, receiver);

        return $"{giverName} used {itemName} on {receiverName}.";
    }

    public string GiveCharacterItem(string[] args)
    {
        string giverName = args[0];
        string receiverName = args[1];
        string itemName = args[2];

        var giver = party.FirstOrDefault(c => c.Name == giverName);
        var receiver = party.FirstOrDefault(c => c.Name == receiverName);
        ExeptionTracker.DoesCharacterExist(giver, giverName);
        ExeptionTracker.DoesCharacterExist(receiver, receiverName);

        Item item = giver.Bag.GetItem(itemName);
        giver.GiveCharacterItem(item, receiver);

        return $"{giverName} gave {receiverName} {itemName}.";
    }

    public string GetStats()
    {
        return string.Join("\n", party.OrderByDescending(c => c.IsAlive).ThenByDescending(c => c.Health));
    }

    public string Attack(string[] args)
    {
        string attackerName = args[0];
        string receiverName = args[1];

        var attacker = party.FirstOrDefault(c => c.Name == attackerName);
        var receiver = party.FirstOrDefault(c => c.Name == receiverName);
        ExeptionTracker.DoesCharacterExist(attacker, attackerName);
        ExeptionTracker.DoesCharacterExist(receiver, receiverName);

        ExeptionTracker.AttackableCharacter(attacker);

        ((Warrior)attacker).Attack(receiver);

        var output = $"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points!" +
            $" {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP " +
            $"and {receiver.Armor}/{receiver.BaseArmor} AP left!";

        if (!receiver.IsAlive)
        {
            output += $"\n{receiver.Name} is dead!";
        }
        return output;
    }

    public string Heal(string[] args)
    {
        string healerName = args[0];
        string healingReceiverName = args[1];

        var healer = party.FirstOrDefault(c => c.Name == healerName);
        var receiver = party.FirstOrDefault(c => c.Name == healingReceiverName);

        ExeptionTracker.DoesCharacterExist(healer, healerName);
        ExeptionTracker.DoesCharacterExist(receiver, healingReceiverName);

        ExeptionTracker.HealableCharacter(healer);

        ((Cleric)healer).Heal(receiver);

        return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}!" +
            $" {receiver.Name} has {receiver.Health} health now!";
    }

    public string EndTurn()
    {
        var output = new List<string>();
        foreach (var character in party)
        {
            if (character.IsAlive)
            {
                var healthBeforeRest = character.Health;
                character.Rest();
                output.Add($"{character.Name} rests ({healthBeforeRest} => {character.Health})");
            }
        }
        if (party.Count <= 1)
        {
            lastSurvivorRounds++;
        }

        return string.Join("\n", output);
    }

    public bool IsGameOver()
    {
        return lastSurvivorRounds > 1;
    }
}