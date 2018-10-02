using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private List<Tire> tires;

    public Car(Func<string> data)
    {
        var tokens = data().Split();

        this.Model = tokens[0];
        engine = new Engine(int.Parse(tokens[1]), int.Parse(tokens[2]));
        cargo = new Cargo(int.Parse(tokens[3]), tokens[4]);
        tires = new List<Tire>(); 
        GetTires(tokens.Skip(5).ToArray());
    }

    public string Model
    {
        get => this.model;
        set => this.model = value;
    }
 
    private void GetTires(string[] tiresData)
    {
        for (int i = 0; i < tiresData.Length; i += 2)
        {
            var presure = double.Parse(tiresData[i]);
            var age = int.Parse(tiresData[i + 1]);

            tires.Add(new Tire(presure, age));
        }
    }

    public bool isCarSuitale(string command)
    {
        if (command == "fragile")
        {
          return  this.cargo.Type == "fragile" && this.tires.Any(x => x.Presure < 1); 
        }
        else
        {
            return this.cargo.Type == "flamable" && this.engine.Power > 250;
        }
    }
}