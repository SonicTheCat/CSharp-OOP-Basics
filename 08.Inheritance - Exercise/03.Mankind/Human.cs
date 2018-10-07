using System;

public class Human
{
    private const int FIRSTNAME_MIN_LENGTH = 4;
    private const int LASTNAME_MIN_LENGTH = 3;

    private string firstName;
    private string lastName;

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            Validator(value, FIRSTNAME_MIN_LENGTH, "firstName");
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
            Validator(value, LASTNAME_MIN_LENGTH, "lastName");
            this.lastName = value;
        }
    }

    public Human(string firstname, string lastname)
    {
        FirstName = firstname;
        LastName = lastname;
    }

    private void Validator(string value, int minLegth, string namePosition)
    {
        if (!char.IsUpper(value[0]))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: {namePosition}");
        }
        else if (value.Length < minLegth)
        {
            throw new ArgumentException($"Expected length at least {minLegth} symbols! Argument: {namePosition}");
        }
    }

    public override string ToString()
    {
        return $"First Name: {FirstName}\nLast Name: {LastName}\n";
    }
}