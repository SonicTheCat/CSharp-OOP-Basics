using System;

class Dough
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 200;
    private const int BASE_CALORIES = 2;

    private string flourType;
    private string bakingTechnique;
    private double weight;  

    private string FlourType
    {
        get => this.flourType;
        set
        {
            var valLower = value.ToLower();
            if (valLower != "white" && valLower != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flourType = value;
        }
    }

    private string BakingTechnique
    {
        get => this.bakingTechnique;
        set
        {
            var valLower = value.ToLower();
            if (valLower != "crispy" && valLower != "chewy" && valLower != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value;
        }
    }

    private double Weight
    {
        get => this.weight;
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException
                    ($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            this.weight = value;
        }
    }

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;     
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

        switch (this.flourType.ToLower())
        {
            case "white": modifier = 1.5; break;
            case "wholegrain": modifier = 1.0; break;
        }
        switch (this.bakingTechnique.ToLower())
        {
            case "crispy": modifier *= 0.9; break;
            case "chewy": modifier *= 1.1; break;
            case "homemade": modifier *= 1.0; break;
        }
        return modifier;
    }
}