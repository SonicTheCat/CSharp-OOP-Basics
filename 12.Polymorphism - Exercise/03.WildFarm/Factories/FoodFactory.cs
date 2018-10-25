using System;
using WildFarm.Contracts.Foods;
using WildFarm.Models.Foods;

namespace WildFarm.Factories
{
    public static class FoodFactory
    {
        public static IFood Create(string[] tokens)
        {
            var food = tokens[0];
            var quantity = int.Parse(tokens[1]);

            switch (food)
            {
                case nameof(Vegetable):
                    return new Vegetable(quantity);
                case nameof(Fruit):
                    return new Fruit(quantity);
                case nameof(Meat):
                    return new Meat(quantity);
                case nameof(Seeds):
                    return new Seeds(quantity);
                default:
                    throw new NotImplementedException("Current Food Type Does Not Exist!");
            }
        }
    }
}