using System;

public class Warrior : Character, IAttackable
{
    private const int BASE_HEALTH = 100;
    private const int BASE_ARMOR = 50;
    private const int ABILITY_POINTS = 40;

    public Warrior(string name, Faction faction)
        : base(name, BASE_HEALTH, BASE_ARMOR, ABILITY_POINTS, new Satchel(), faction)
    {

    }

    public void Attack(Character character)
    {
        ExeptionTracker.IsAlive(this, character);

        ExeptionTracker.IsSelfAttack(this, character);

        ExeptionTracker.IsFriendlyFire(this, character);

        character.TakeDamage(this.AbilityPoints);
    }
}