using System;

public abstract class Character
{
    private string name;
    private double baseHealth;
    private double baseArmor;
    private double abilityPoints;
    private Faction faction;
    private double health;
    private double armor;
    private Bag bag;

    public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
    {
        this.Name = name;
        this.BaseHealth = health;
        this.Health = health;
        this.BaseArmor = armor;
        this.Armor = armor;
        this.IsAlive = true;
        this.AbilityPoints = abilityPoints;
        this.Bag = bag;
        this.Faction = faction;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            ExeptionTracker.IsNameCorrect(value);
            this.name = value;
        }
    }

    public double BaseHealth
    {
        get { return this.baseHealth; }
        set { this.baseHealth = value; }
    }

    public double Health
    {
        get
        {
            return this.health;
        }
        set
        {
            if (value <= 0)
            {
                this.health = 0;
                this.IsAlive = false;
            }
            else if (value > this.BaseHealth)
            {
                this.health = this.BaseHealth;
            }
            else
            {
                this.health = value;
            }
        }
    }

    public double BaseArmor
    {
        get { return this.baseArmor; }
        set { this.baseArmor = value; }
    }

    public double Armor
    {
        get
        {
            return this.armor;
        }
        set
        {
            if (value <= 0)
            {
                this.armor = 0;
            }
            else if (value > this.BaseArmor)
            {
                this.armor = this.BaseArmor;
            }
            else
            {
                this.armor = value;
            }
        }
    }

    public double AbilityPoints
    {
        get { return this.abilityPoints; }
        set { this.abilityPoints = value; }
    }

    public Bag Bag
    {
        get { return this.bag; }
        set { this.bag = value; }
    }

    public Faction Faction
    {
        get { return this.faction; }
        set { this.faction = value; }
    }

    public bool IsAlive { get; set; }

    public virtual double RestHealMultiplier => 0.2;

    public void TakeDamage(double hitPoints)
    {
        ExeptionTracker.IsAlive(this);

        var leftHitPoints = this.Armor - hitPoints;
        this.Armor -= hitPoints;

        if (leftHitPoints < 0)
        {
            this.Health -= Math.Abs(leftHitPoints);
        }
    }

    public void Rest()
    {
        ExeptionTracker.IsAlive(this);

        var increase = this.BaseHealth * this.RestHealMultiplier;
        this.Health += increase;
    }

    public void UseItem(Item item)
    {
        ExeptionTracker.IsAlive(this);

        item.AffectCharacter(this);
    }

    public void UseItemOn(Item item, Character character)
    {
        ExeptionTracker.IsAlive(this, character);

        item.AffectCharacter(character);
    }

    public void GiveCharacterItem(Item item, Character character)
    {
        ExeptionTracker.IsAlive(this, character);

        character.Bag.AddItem(item);
    }

    public void ReceiveItem(Item item)
    {
        ExeptionTracker.IsAlive(this);

        this.Bag.AddItem(item);
    }

    public override string ToString()
    {
        var status = this.IsAlive == true ? "Alive" : "Dead";

        return $"{this.Name} - " +
            $"HP: {this.Health}/{this.BaseHealth}, " +
            $"AP: {this.Armor}/{this.BaseArmor}, " +
            $"Status: {status}";
    }

    public override bool Equals(object character)
    {
        if (this.GetType() != character.GetType())
        {
            return false;
        }

        var casted = (Character)character;

        if (this.Name != casted.Name || this.Faction != casted.Faction)
        {
            return false;
        }

        return true;
    }
}