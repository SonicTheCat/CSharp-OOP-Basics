using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        List<IIdentifiable> creatures = new List<IIdentifiable>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            if (tokens.Length == 2)
            {
                creatures.Add(new Robot(tokens[0], tokens[1])); 
            }
            else if (tokens.Length == 3)
            {
                creatures.Add(new Citizen(tokens[0], tokens[1], tokens[2]));
            }
        }

        string fakeId = Console.ReadLine();
        foreach (var c in creatures)
        {
            if (c.Id.EndsWith(fakeId))
            {
                Console.WriteLine(c.Id);
            }
        }
    }
}