using System;

public class Animal
{
    private string name;
    private int age;
    private string gender;

    public string Name
    {
        get => this.name;
        set
        {
            if (value.Length < 1)
            {
                InvalidInput();
            }
            this.name = value;
        }
    }
    public int Age
    {
        get => this.age;
        set
        {
            if (value < 0)
            {
                InvalidInput();
            }
            this.age = value;
        }
    }
    public string Gender
    {
        get => this.gender;
        set
        {
            if (value.ToLower() != "male" && value.ToLower() != "female")
            {
                InvalidInput();
            }
            this.gender = value;
        }
    }

    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public virtual string ProduceSound() { return ""; }

    public override string ToString()
    {
        return
            $"{this.GetType()}\n" +
            $"{Name} {Age} {Gender}\n" +
             $"{ProduceSound()}";
    }

    private void InvalidInput()
    {
        throw new ArgumentException("Invalid input!");
    }
}