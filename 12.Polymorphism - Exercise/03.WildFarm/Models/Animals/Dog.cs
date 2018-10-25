using WildFarm.Contracts.Foods;
using WildFarm.Models.Foods;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!"; 
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