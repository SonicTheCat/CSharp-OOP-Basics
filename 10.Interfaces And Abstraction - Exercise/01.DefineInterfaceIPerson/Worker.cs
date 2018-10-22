class Worker : Person
{
    public string Job { get; set; }
    public decimal Salary { get; set; }

    public Worker(string name, int age) : base(name,age)
    {

    }

    public override string SayHelloInYourLanguage()
    {
        return "Hello"; 
    }
}