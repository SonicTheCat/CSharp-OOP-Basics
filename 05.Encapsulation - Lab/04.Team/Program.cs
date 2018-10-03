using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var people = new List<Person>();

        for (int i = 0; i < lines; i++)
        {
            var tokens = Console.ReadLine().Split();
            var firstname = tokens[0];
            var lastname = tokens[1];
            var age = int.Parse(tokens[2]);
            var salary = decimal.Parse(tokens[3]);

            try
            {
                Person person = new Person(firstname, lastname, age, salary);
                people.Add(person);
            }
            catch (ArgumentException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        Team team = new Team("YAMBOL Records");

        foreach (var p in people)
        {
            team.AddPlayer(p); 
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
    }
}

