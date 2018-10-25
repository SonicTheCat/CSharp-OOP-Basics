using System; 

public abstract class Item
{
    public Item(int weight)
    {
        this.Weight = weight;
    }

    public int Weight { get; set; }

    public virtual void AffectCharacter(Character character)
    {
        ExeptionTracker.IsAlive(character); 
    }
}