using System;
using System.Collections.Generic;

public class MonumentFactory
{
    public Monument CreateMonument(List<string> arguments)
    {
        var type = arguments[0] + "Monument";
        var name = arguments[1];
        var affinity = int.Parse(arguments[2]);

        return (Monument)Activator.CreateInstance(Type.GetType(type), new object[] { name, affinity });
    }
}