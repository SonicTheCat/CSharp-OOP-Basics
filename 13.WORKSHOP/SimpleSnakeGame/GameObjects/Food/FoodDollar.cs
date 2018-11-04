public class FoodDollar : Food
{
    private const char foodSymbol = '$';
    private const int points = 2;

    public FoodDollar(Wall wall)
        : base(wall, foodSymbol, points)
    {
    }
}