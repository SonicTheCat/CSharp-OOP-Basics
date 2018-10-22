public class Citizen : Creature, IIdentifiable
{
    public string Id { get; }
    public string Age { get; }

    public Citizen(string name, string age, string id, string birthdate) 
        : base(name, birthdate)
    {
        this.Id = id;
        this.Age = age;
    }
}