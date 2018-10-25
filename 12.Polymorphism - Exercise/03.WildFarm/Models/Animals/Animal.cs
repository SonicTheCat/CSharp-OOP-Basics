using System;
using WildFarm.Contracts;
using WildFarm.Contracts.Foods;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; protected set; }

        public abstract string ProduceSound();

        public virtual void Eat(IFood food, int quantity)
        {
            this.FoodEaten += quantity;
            var increasingNumber = WeightMultiplier.IncreasingNumber(this);
            this.Weight += quantity * increasingNumber; 
        }

        protected string WrongFood(IFood food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}