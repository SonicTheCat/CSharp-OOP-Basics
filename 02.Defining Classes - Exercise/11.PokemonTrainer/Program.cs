using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var trainers = GetTrainersAndPokemons();
        Battle(trainers);

        foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
        {
            Console.WriteLine(trainer.Name + " " + trainer.Badges + " " + trainer.Pokemons.Count);
        }
    }
    static void Battle(List<Trainer> trainers)
    {
        string currentEl;
        while ((currentEl = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == currentEl))
                {
                    trainer.AddBadge();
                    continue;
                }

                trainer.DecreasePokeHealth();
                trainer.RemovePokemons();
            }
        }
    }
    static List<Trainer> GetTrainersAndPokemons()
    {
        List<Trainer> trainers = new List<Trainer>();

        string data;
        while ((data = Console.ReadLine()) != "Tournament")
        {
            var splitData = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var trainerName = splitData[0];
            var pokemonName = splitData[1];
            var pokemonEl = splitData[2];
            var pokemonHealth = int.Parse(splitData[3]);

            Pokemon pokemon = new Pokemon(pokemonName, pokemonEl, pokemonHealth);

            var trainer = trainers
                .Where(t => t.Name == trainerName)
                .FirstOrDefault();

            if (trainer == null)
            {
                trainer = new Trainer(trainerName);
                trainers.Add(trainer);
            }
            trainer.AddPokemon(pokemon);
        }
        return trainers;
    }
}

