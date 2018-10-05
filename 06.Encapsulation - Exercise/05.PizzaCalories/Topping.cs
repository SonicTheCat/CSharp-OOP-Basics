using System;

class Topping
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 50;
    private const int BASE_CALORIES = 2;

    private string type;
    private double weight;

    public string Type
    {
        get => this.type;
        set
        {
            var valLower = value.ToLower();
            if (valLower != "meat" && valLower != "veggies" && valLower != "cheese" && valLower != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.type = value;
        }
    }
    public double Weight
    {
        get => this.weight;
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException
                    ($"{this.type} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            this.weight = value;
        }
    }

    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight;
    }

    public string Calories()
    {
        var modifier = GetModifier();
        var calories = (BASE_CALORIES * this.weight) * modifier;
        return calories.ToString("F2");
    }

    private double GetModifier()
    {
        double modifier = 0;

        switch (this.type.ToLower())
        {
            case "meat": modifier = 1.2; break;
            case "veggies": modifier = 0.8; break;
            case "cheese": modifier = 1.1; break;
            case "sauce": modifier = 0.9; break;
        }
        return modifier;
    }
}