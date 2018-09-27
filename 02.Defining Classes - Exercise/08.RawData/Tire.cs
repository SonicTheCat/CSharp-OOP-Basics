using System;
using System.Collections.Generic;
using System.Text;

public class Tire
{
    private double presure;
    private int age;

    public Tire(double presure, int age)
    {
        this.presure = presure;
        this.age = age;
    }

    public double Presure
    {
        get { return this.presure; }
    }
}
