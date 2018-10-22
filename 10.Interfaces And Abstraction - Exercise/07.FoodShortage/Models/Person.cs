using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public abstract class Person : IPerson, IBuyer
    {
        public string Name { get; }
        public int Age { get; }
        public int Food { get; protected set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void BuyFood();
    }
}