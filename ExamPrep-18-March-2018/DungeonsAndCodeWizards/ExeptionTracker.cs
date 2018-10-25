using System;
using System.Collections.Generic;

public static class ExeptionTracker
{
    private const string NOT_ALIVE_EXEPTION_MESSAGE = "Must be alive to perform this action!";

    public static void HealableCharacter(Character healer)
    {
        if (!(healer is IHealable))
        {
            throw new ArgumentException($"{healer.Name} cannot heal!");
        }
    }

    public static void AttackableCharacter(Character attacker)
    {
        if (!(attacker is IAttackable))
        {
            throw new ArgumentException($"{attacker.Name} cannot attack!");
        }
    }

    public static void IsPoolEmpty (IList<Item> pool)
    {
        if (pool.Count == 0)
        {
            throw new InvalidOperationException("No items left in pool!");
        }
    }

    public static void DoesCharacterExist(Character character, string characterName)
    {
        if (character == null)
        {
            throw new ArgumentException($"Character {characterName} not found!");
        }
    }

    public static void IsBagCapacityFull(Bag bag, Item item)
    {
        if (bag.Load + item.Weight > bag.Capacity)
        {
            throw new InvalidOperationException("Bag is full!");
        }
    }

    public static void IsItemInBag(Item item, string name)
    {
        if (item == null)
        {
            throw new ArgumentException($"No item with name {name} in bag!");
        }
    }

    public static void IsBagEmpty(IList<Item> bag)
    {
        if (bag.Count < 1)
        {
            throw new InvalidOperationException("Bag is empty!");
        }
    }

    public static void IsNameCorrect(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace!");
        }
    }

    public static void IsEnemyHealing(Character first, Character second)
    {
        if (first.Faction != second.Faction)
        {
            throw new InvalidOperationException("Cannot heal enemy character!");
        }
    }

    public static void IsFriendlyFire(Character first, Character second)
    {
        if (first.Faction == second.Faction)
        {
            throw new ArgumentException($"Friendly fire! Both characters are from {first.Faction} faction!");
        }
    }

    public static void IsSelfAttack(Character first, Character second)
    {
        if (first.Equals(second))
        {
            throw new InvalidOperationException("Cannot attack self!");
        }
    }

    public static void IsAlive(Character character)
    {
        if (!character.IsAlive)
        {
            throw new InvalidOperationException(NOT_ALIVE_EXEPTION_MESSAGE);
        }
    }

    public static void IsAlive(Character first, Character second)
    {
        if (!first.IsAlive || !second.IsAlive)
        {
            throw new InvalidOperationException(NOT_ALIVE_EXEPTION_MESSAGE);
        }
    }
}