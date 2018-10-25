using WildFarm.Contracts.Foods;
using WildFarm.Models.Foods;

namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!"; 
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