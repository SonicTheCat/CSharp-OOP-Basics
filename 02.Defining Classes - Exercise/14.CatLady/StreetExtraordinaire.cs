public class StreetExtraordinaire : Cat
{
    private int decibelsOfMeows;

    public StreetExtraordinaire(string name, int decibelsOfMeows)
        :base(name)
    {
        this.decibelsOfMeows = decibelsOfMeows;
    }
    public override string ToString()
    {
        return $"{this.GetType().Name} {base.Name} {this.decibelsOfMeows}"; 
    }
}

