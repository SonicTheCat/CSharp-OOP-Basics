using System;
using System.Collections.Generic;
using System.Text;

class Parent
{
    private string name;
    private string birthday;

    public Parent(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }
}

