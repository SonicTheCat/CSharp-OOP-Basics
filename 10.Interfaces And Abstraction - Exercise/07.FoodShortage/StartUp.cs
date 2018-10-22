using System;
using System.Collections.Generic;
using System.Linq;
using FoodShortage.Models;

namespace FoodShortage
{
    class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            GetAllPeople(people);
            FindTotalAmountOfFood(people);

        }

        static void GetAllPeople(List<Person> people)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var tokens = Console.ReadLine().Split();
                if (tokens.Length == 4)
                {
                    people.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
                else if (tokens.Length == 3)
                {
                    people.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }
        }

        static void FindTotalAmountOfFood(List<Person> people)
        {
            string name;
            while ((name = Console.ReadLine()) != "End")
            {
                var person = people.FirstOrDefault(x => x.Name == name);
                person?.BuyFood();
            }
            Console.WriteLine(people.Sum(p => p.Food));
        }
    }
}