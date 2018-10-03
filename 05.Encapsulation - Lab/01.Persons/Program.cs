using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var people = new List<Person>();

        for (int i = 0; i < lines; i++)
        {
            var tokens = Console.ReadLine().Split();
            Person person = new Person(tokens[0], tokens[1], int.Parse(tokens[2]));
            people.Add(person);
        }

        people.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p));
    }
}