using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Information
{
    private string name;
    private Company company;
    private Car car;
    private List<Parent> parents;
    private List<Child> children;
    private List<Pokemon> pokemon;

    public Information()
    {
        Company company = new Company();
        Car car = new Car();
        this.Parents = new List<Parent>();
        this.Children = new List<Child>();
        this.Pokemon = new List<Pokemon>();
    }
    public Information(string name)
        : this()
    {
        this.Name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Company Company
    {
        get { return company; }
        set { company = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }

    public List<Parent> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Child> Children
    {
        get { return children; }
        set { children = value; }
    }

    public List<Pokemon> Pokemon
    {
        get { return pokemon; }
        set { pokemon = value; }
    }

    public void AddParent(Parent parent)
    {
        this.Parents.Add(parent);
    }
    public void AddChild(Child child)
    {
        this.Children.Add(child);
    }
    public void AddPokemon(Pokemon poke)
    {
        this.Pokemon.Add(poke);
    }

    public override string ToString()
    {
        return $"{this.Name}" +
            $"\nCompany: {this.Company}" +
            $"\nCar:{this.Car}" +
            $"\nPokemon:{string.Join("", this.Pokemon.Select(p => "\n" + p.Name + " " + p.Type))}" +
            $"\nParents:{string.Join("", this.Parents.Select(p => "\n" + p.Name + " " + p.Birthday))}" +
            $"\nChildren:{string.Join("", this.Children.Select(p => "\n" + p.Name + " " + p.Birthday))}";
    }
}

