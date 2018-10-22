using System;
using BirthdayCelebrations.Interfaces;
using BirthdayCelebrations.Models;
using System.Collections.Generic;
using System.Linq; 

namespace BirthdayCelebrations
{
    class StartUp
    {
        static void Main()
        {
            List<IBirthable> creatures = new List<IBirthable>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split();
                if (tokens[0] == "Citizen")
                {
                    creatures.Add(new Citizen(tokens[1], tokens[2], tokens[3], tokens[4]));
                }
                else if (tokens[0] == "Pet")
                {
                    creatures.Add(new Pet(tokens[1], tokens[2]));
                }
            }

            var birthday = int.Parse(Console.ReadLine());

            creatures
                .Where(c => c.Birthdate.Year == birthday)
                .ToList()
                .ForEach(c => Console.WriteLine($"{c.Birthdate:dd/mm/yyyy}"));
        }
    }
}