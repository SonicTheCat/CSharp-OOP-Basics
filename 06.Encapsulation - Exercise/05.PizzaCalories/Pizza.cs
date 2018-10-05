using System;
using System.Collections.Generic;
using System.Linq;

class Pizza
{
    private const int MIN_LENGHT = 1;
    private const int MAX_LENGHT = 15;
    private const int MIN_TOPPING = 0;
    private const int MAX_TOPPING = 10;

    private string name;
    private Dough dough;
    private List<Topping> toppings;

    public string Name
    {
        get => this.name;
        private set
        {
            if (value.Length < MIN_LENGHT || value.Length > MAX_LENGHT)
            {
                throw new ArgumentException
                    ($"Pizza name should be between {MIN_LENGHT} and {MAX_LENGHT} symbols.");
            }
            this.name = value;
        }
    }

    public Dough Dough
    {
        set => this.dough = value;
    }

    public Pizza(string name)
    {
        Name = name;
        this.toppings = new List<Topping>();
    }

    public void AddTopping(Topping top)
    {
        this.NumberOfToppings();
        this.toppings.Add(top);
    }

    public int NumberOfToppings()
    {
        var count = this.toppings.Count;
        if (count < MIN_TOPPING || count > MAX_TOPPING)
        {
            throw new ArgumentException
                ($"Number of toppings should be in range [{MIN_TOPPING}..{MAX_TOPPING}].");
        }
        return count;
    }

    public string TotalCalories()
    {
        var toppingCalories = this.toppings.Sum(x => double.Parse(x.Calories()));
        var doughCalories = double.Parse(this.dough.Calories());

        return (toppingCalories + doughCalories).ToString("F2");
    }
}