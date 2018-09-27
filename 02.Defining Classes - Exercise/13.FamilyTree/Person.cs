using System;
using System.Collections.Generic;
using System.Text;

class Person
{
    private string firstname;
    private string lastname;
    private string dayOfBirth;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {
        this.Parents = new List<Person>();
        this.Children = new List<Person>();
    }

    public Person(string firstname, string lastname)
        : this()
    {
        this.FirstName = firstname;
        this.LastName = lastname;
    }

    public Person(string dayOfBirth)
        :this()
    {
        this.BirthDate = dayOfBirth;
    }

    public string FirstName
    {
        get
        {
            return firstname;
        }
        set
        {
            firstname = value;
        }
    }
    public string LastName
    {
        get
        {
            return lastname;
        }
        set
        {
            lastname = value;
        }
    }
    public string BirthDate
    {
        get
        {
            return dayOfBirth;
        }
        set
        {
            dayOfBirth = value;
        }
    }

    public List<Person> Parents
    {
        get
        {
            return this.parents;
        }
        set
        {
            this.parents = value;
        }
    }
    public List<Person> Children
    {
        get
        {
            return this.children;
        }
        set
        {
            this.children = value;
        }
    }
    public void AddChild(Person child)
    {
        this.Children.Add(child);
    }
    public void AddParent(Person parent)
    {
        this.Parents.Add(parent);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.FirstName} {this.LastName} {this.BirthDate}");

        sb.AppendLine("Parents:");
        this.Parents.ForEach(p => sb.AppendLine($"{p.FirstName} {p.LastName} {p.BirthDate}"));

        sb.AppendLine("Children:");
        this.Children.ForEach(ch => sb.AppendLine($"{ch.FirstName} {ch.LastName} {ch.BirthDate}"));

        return sb.ToString();
    }
}