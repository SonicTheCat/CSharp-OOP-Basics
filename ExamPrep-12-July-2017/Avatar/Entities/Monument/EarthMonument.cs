public class EarthMonument : Monument
{
    private const string POWERNAME = "Earth Affinity";

    public EarthMonument(string name, int earthAffinity) 
        : base(name, earthAffinity,POWERNAME)
    {    
    }
}