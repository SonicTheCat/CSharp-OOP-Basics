using System;

class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public string FirstName
    {
        get => this.firstName;
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            this.firstName = value;
        }
    }
    public string LastName
    {
        get => this.lastName;
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            this.lastName = value;
        }
    }
    public int Age
    {
        get => this.age;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            this.age = value;
        }
    }
    public decimal Salary
    {
        get => this.salary;
        private set
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }
            this.salary = value;
        }
    }

    public Person(string firstname, string lastname, int age, decimal salary)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Age = age;
        this.Salary = salary;
    }

    public Person IcreaseSalary(decimal bonus)
    {
        if (this.Age < 30)
        {
            bonus /= 2;
        }
        var percentageBonus = (100 + bonus) / 100;
        this.salary *= percentageBonus;

        return this;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:F2} leva.";
    }
}