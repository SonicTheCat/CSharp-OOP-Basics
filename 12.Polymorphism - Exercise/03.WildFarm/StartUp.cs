using System;
using System.Collections.Generic;
using WildFarm.Contracts;
using WildFarm.Contracts.Foods;
using WildFarm.Factories; 

namespace WildFarm
{
    public class StartUp
    {
        public static void Main()
        {
            var animals = new List<IAnimal>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var animalTokens = input.Split();
                var foodTokens = Console.ReadLine().Split();

                IAnimal animal = AnimalFactory.Create(animalTokens);
                IFood food = FoodFactory.Create(foodTokens); 

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food, food.Quantity);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                animals.Add(animal);
            }

            animals.ForEach(a => Console.WriteLine(a));
        }
    }
}