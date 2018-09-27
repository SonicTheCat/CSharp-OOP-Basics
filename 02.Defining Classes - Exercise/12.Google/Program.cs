using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Information> storeData = new List<Information>();

        string data;
        while ((data = Console.ReadLine()) != "End")
        {
            var tokens = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var currentPerson = storeData.Where(x => x.Name == tokens[0]).FirstOrDefault();
            if (currentPerson == null)
            {
                currentPerson = new Information(tokens[0]);
                storeData.Add(currentPerson);
            }

            switch (tokens[1])
            {
                case "company": StoreCompanyData(currentPerson, tokens); break;
                case "pokemon": StorePokemonData(currentPerson, tokens); break;
                case "parents": StoreParentData(currentPerson, tokens); break;
                case "children": StoreChildData(currentPerson, tokens); break;
                case "car": StoreCarData(currentPerson, tokens); break;
            }
        }

        var lookFor = Console.ReadLine();
        var printPerson = storeData.Where(x => x.Name == lookFor).FirstOrDefault();
        Console.WriteLine(printPerson);
    }
    static void StoreCarData(Information person, string[] tokens)
    {
        var model = tokens[2];
        var speed = int.Parse(tokens[3]);
        person.Car = new Car(model, speed);
    }

    static void StoreChildData(Information person, string[] tokens)
    {
        var childName = tokens[2];
        var birthday = tokens[3];
        person.AddChild(new Child(childName, birthday));
    }

    static void StoreParentData(Information person, string[] tokens)
    {
        var parentName = tokens[2];
        var birthday = tokens[3];
        person.AddParent(new Parent(parentName, birthday));
    }

    static void StorePokemonData(Information person, string[] tokens)
    {
        var pokemonName = tokens[2];
        var type = tokens[3];
        Pokemon pokemon = new Pokemon(pokemonName, type);
        person.AddPokemon(pokemon);
    }

    static void StoreCompanyData(Information person, string[] tokens)
    {
        var companyName = tokens[2];
        var department = tokens[3];
        var salary = decimal.Parse(tokens[4]);

        person.Company = new Company(companyName, department, salary);
    }
}