using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private int engineSpeed;
    private int enginePower;

    public Engine(int engineSpeed, int enginePower)
    {
        this.engineSpeed = engineSpeed;
        this.enginePower = enginePower;
    }

    public int EnginePower
    {
        get { return this.enginePower; }
    }
}

