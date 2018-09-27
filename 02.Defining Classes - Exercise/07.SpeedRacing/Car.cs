using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private decimal amountFuel;
    private decimal consumption;
    private int distance;

    public Car(string model, decimal amountFuel, decimal consumption)
    {
        this.model = model;
        this.amountFuel = amountFuel;
        this.consumption = consumption;
        this.distance = 0;
    }

    public string Model
    {
        get { return this.model; }
    }

    public void isFuelEnough(int amountOfKm)
    {
        var wasted = amountOfKm * this.consumption;
        if (wasted <= this.amountFuel)
        {
            this.amountFuel -= wasted;
            this.distance += amountOfKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {
        return $"{this.model} {this.amountFuel:f2} {this.distance}"; 
    }
}

