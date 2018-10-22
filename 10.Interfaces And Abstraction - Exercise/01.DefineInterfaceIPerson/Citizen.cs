public class Citizen : Person 
{
    public string CitizenShip { get; set; }

    public Citizen(string name, int age) : base(name,age)
    {

    }

    public override string SayHelloInYourLanguage()
    {
        return "salam alemkom";
    }
}