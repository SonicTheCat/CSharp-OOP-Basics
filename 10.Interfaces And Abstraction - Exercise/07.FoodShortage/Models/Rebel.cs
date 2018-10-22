namespace FoodShortage.Models
{
    public class Rebel : Person
    {
        private const int increasingNumber = 5;

        public string Group { get; }

        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            Group = group;
        }

        public override void BuyFood()
        {
            Food += increasingNumber;
        }
    }
}