using WildFarm.Contracts.Foods;
using WildFarm.Models.Foods;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot"; 
        }

        public override void Eat(IFood food, int quantity)
        {
            if (!(food is Meat))
            {
                base.WrongFood(food);
            }
            else
            {
                base.Eat(food, quantity);
            }
        }
    }
}