using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Family family = new Family();

        for (int i = 0; i < n; i++)
        {
            var member = Console.ReadLine().Split();
            var name = member[0];
            var age = int.Parse(member[1]);

            family.AddMember(new Person(name, age));  
        }
        Person oldest = family.GetOldestMember();
        Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}

