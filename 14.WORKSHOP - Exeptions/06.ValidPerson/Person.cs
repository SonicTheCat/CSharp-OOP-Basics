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
                throw new ArgumentOutOfRangeException("value" ,"Age should be in the range [0...120]."); 
            }
            this.age = value; 
        }
    }

    private void NameValidations(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException("value", "Name can not be null or empty.");
        }

        if (!value.All(Char.IsLetter))
        {
            throw new FormatException("Name must contains only letters!");
        }

        if (value.Length <= 1)
        {
            throw new ArgumentException("Name must contains at least 2 characters");
        }
    }
}