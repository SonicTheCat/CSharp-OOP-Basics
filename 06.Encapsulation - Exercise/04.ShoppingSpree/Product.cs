using System;

class Product
{
    private string name;
    private int cost;

    public string Name
    {
        get => this.name;
        private set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }
    public int Cost
    {
        get => this.cost;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.cost = value;
        }
    }

    public Product(string name, int cost)
    {
        this.Name = name;
        this.Cost = cost;
    }
}