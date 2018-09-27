using System.Collections.Generic;
using System.Linq;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer()
    {
        this.Badges = 0;
        this.pokemons = new List<Pokemon>();
    }

    public Trainer(string name)
        :this()
    {
        this.Name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Badges
    {
        get { return badges; }
        set { badges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public void AddBadge()
    {
        this.Badges++;
    }

    public void AddPokemon(Pokemon poke)
    {
        this.Pokemons.Add(poke);
    }

    public void DecreasePokeHealth()
    {
        this.pokemons.ForEach(p => p.Health -= 10); 
    }

    public void RemovePokemons()
    {
        this.Pokemons = this.Pokemons.Where(p => p.Health > 0).ToList();
    }
}