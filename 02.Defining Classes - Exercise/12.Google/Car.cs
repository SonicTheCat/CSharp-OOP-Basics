using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private int speed;

    public Car()
    {
       
    }

    public Car(string model, int speed)
    {
        this.Model = model;
        this.Speed = speed;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public override string ToString()
    {        
        if (this.Model != null || this.speed != 0)
        {
            return "\n" + this.Model + " " + this.Speed;
        }
        return "";
    }
}
