using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private List<Tire> tire;

    public Car(string model, Engine engine, Cargo cargo, List<Tire> tire)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tire = tire;
    }

    public string Model
    {
        get { return this.model; }
    }
    public Cargo Cargo
    {
        get { return this.cargo; }
    }
    public Engine Engine
    {
        get { return this.engine; }
    }
    public List<Tire> Tire
    {
        get { return this.tire; }
    }
}

