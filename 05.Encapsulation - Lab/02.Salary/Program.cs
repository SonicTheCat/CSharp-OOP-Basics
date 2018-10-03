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
            var firstname = tokens[0];
            var lastname = tokens[1];
            var age = int.Parse(tokens[2]);
            var salary = decimal.Parse(tokens[3]);

            Person person = new Person(firstname, lastname, age, salary);
            people.Add(person);
        }
        var bonus = decimal.Parse(Console.ReadLine());

        people.ForEach(p => Console.WriteLine(p.IcreaseSalary(bonus).ToString()));
    }
}