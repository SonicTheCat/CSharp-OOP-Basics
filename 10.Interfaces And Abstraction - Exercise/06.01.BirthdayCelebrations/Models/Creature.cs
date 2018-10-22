public abstract class Creature
{
    public string Name { get; }
  
    public string Birthdate { get; }

    public Creature(string name, string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }

    public bool HasBirthday(string year)
    {
        return this.Birthdate.EndsWith(year); 
    }
}