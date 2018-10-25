public class HealthPotion : Item
{
    private const int INCREASING_POINTS = 20;
    private const int WEIGHT = 5;

    public HealthPotion() 
        : base(WEIGHT)
    {
    }

    public override void AffectCharacter(Character character)
    {
        base.AffectCharacter(character);
        character.Health += INCREASING_POINTS;
    }
}
