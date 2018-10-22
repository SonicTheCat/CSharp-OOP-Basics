class Citizen : IIdentifiable
{
    public string Id { get; }
    public string Name { get; }
    public string Age { get; }

    public Citizen(string name, string age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }
}