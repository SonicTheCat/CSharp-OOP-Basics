using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        List<Creature> creatures = new List<Creature>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            if (tokens[0] == "Citizen")
            {
                creatures.Add(new Citizen(tokens[1], tokens[2], tokens[3], tokens[4]));
            }
            else if(tokens[0] == "Pet")
            {
                creatures.Add(new Pet(tokens[1], tokens[2]));
            }
        }

        var birthday = Console.ReadLine();

        creatures
            .Where(c => c.HasBirthday(birthday))
            .ToList()
            .ForEach(c => Console.WriteLine(c.Birthdate));
    }
}