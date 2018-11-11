using System;
using System.Linq;

internal class Person
{
    private string firstName;
    private string lastName;
    private int age;


    public Person(string firstname, string lastname, int age)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Age = age;
    }

    public string FirstName
    {
        get
        {
            return this.firstName; 
        }
        set
        {
            this.NameValidations(value);
            this.firstName = value; 
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            this.NameValidations(value);
            this.lastName = value; 
        }
    }

    public int Age
    {
        get
        {
            return this.age; 
        }
        set
        {
            if (value < 0 || value > 120)
            {
                throw new InvalidPersonAgeException(); 
            }
            this.age = value; 
        }
    }

    private void NameValidations(string value)
    {
        if (!value.All(Char.IsLetter))
        {
            throw new InvalidPersonNameException(); 
        }
    }
}