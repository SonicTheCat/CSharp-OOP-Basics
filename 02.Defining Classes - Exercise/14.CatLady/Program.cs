using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Cat> cats = new List<Cat>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var catData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var name = catData[1];
            var info = catData[2];

            switch (catData[0])
            {
                case "Cymric":
                    cats.Add(new Cymric(name, double.Parse(info))); break;
                case "Siamese":
                    cats.Add(new Siamese(name, int.Parse(info))); break;
                case "StreetExtraordinaire":
                    cats.Add(new StreetExtraordinaire(name, int.Parse(info))); break;
            }  
        }

        var lookFor = Console.ReadLine();
        var cat = cats.Single(c => c.Name == lookFor);
        Console.WriteLine(cat);
    }
}

