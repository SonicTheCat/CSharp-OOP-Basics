class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public string FirstName
    {
        get => this.firstName;
    }
    public string LastName
    {
        get => this.lastName;
    }
    public int Age
    {
        get => this.age;
    }
    public decimal Salary
    {
        get => this.salary;
    }

    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public Person(string firstname, string lastname, int age, decimal salary)
        : this(firstname, lastname, age)
    {
        this.salary = salary;
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