using System;
using System.Collections.Generic;
using System.Text;

class Pokemon
{
    private string name;
    private string type;

    public Pokemon(string name, string type)
    {
        this.Name = name;
        this.Type = type;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }
}

