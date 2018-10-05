using System;
using System.Collections.Generic;

class Person
{
    private string name;
    private int money;
    private List<string> products;

    public string Name
    {
        get => this.name;
        private set
        {
            if (value == string.Empty || value == " ")
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public int Money
    {
        get => this.money;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public Person(string name, int money)
    {
        Name = name;
        Money = money;
        this.products = new List<string>();
    }

    public string CanAfford(Product product)
    {
        if (product.Cost > this.money)
        {
            return $"{this.name} can't afford {product.Name}";
        }
        else
        {
            this.money -= product.Cost;
            AddProduct(product.Name);
            return $"{Name} bought {product.Name}";
        }
    }

    private void AddProduct(string productName)
    {
        this.products.Add(productName);
    }

    public override string ToString()
    {
        if (products.Count > 0)
        {
            return $"{Name} - {string.Join(", ", products)}";
        }
        return $"{Name} - Nothing bought";
    }
}