using WildFarm.Contracts.Foods;
using WildFarm.Models.Foods;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak"; 
        }

        public override void Eat(IFood food, int quantity)
        {
            if (!(food is Vegetable) && !(food is Fruit))
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