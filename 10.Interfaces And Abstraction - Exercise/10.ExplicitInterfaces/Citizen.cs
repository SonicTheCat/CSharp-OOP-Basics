public class Citizen : IPerson, IResident
{
    public string Name { get; private set; }

    public string Age { get; private set; }

    public string Country { get; private set; }

    public Citizen(string name, string country, string age)
    {
        Name = name;
        Age = age;
        Country = country;
    }

    string IPerson.GetName()
    {
        return Name;
    }

    string IResident.GetName()
    {
        return "Mr/Ms/Mrs " + Name;
    }
}