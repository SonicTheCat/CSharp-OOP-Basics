public class PoisonPotion : Item
{
    private const int DECREASING_POINTS = 20;
    private const int WEIGHT = 5;

    public PoisonPotion() 
        : base(WEIGHT)
    {
    }

    public override void AffectCharacter(Character character)
    {
        base.AffectCharacter(character);
        character.Health -= DECREASING_POINTS; 
    }
}