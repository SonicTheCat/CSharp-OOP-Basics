using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>(); 

        for (int i = 0; i < n; i++)
        {
            var person = Console.ReadLine().Split();
            people.Add(new Person(person[0], int.Parse(person[1])));
        }

        people
            .Where(p => p.Age > 30)
            .OrderBy(p => p.Name)
            .ToList()
            .ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
    }
}

