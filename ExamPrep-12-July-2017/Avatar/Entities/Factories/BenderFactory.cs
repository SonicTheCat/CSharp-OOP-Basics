using System;
using System.Collections.Generic;

public class BenderFactory
{
    public Bender CreateBender(List<string> arguments)
    {
        var type = arguments[0] + "Bender";
        var name = arguments[1];
        var power = int.Parse(arguments[2]);
        var secondParam = double.Parse(arguments[3]);

        return (Bender)Activator.CreateInstance(Type.GetType(type), new object[] { name, power, secondParam });
    }
}