class Person
{
    private string firstName;
    private string lastName;
    private int age;

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

    public Person(string firstname, string lastname, int age)
    {
        this.firstName = firstname;
        this.lastName = lastname;
        this.age = age; 
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old."; 
    }
}