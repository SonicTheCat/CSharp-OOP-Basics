public class FireMonument : Monument
{
    private const string POWERNAME = "Fire Affinity";

    public FireMonument(string name, int fireAffinity) 
        : base(name,fireAffinity,POWERNAME)
    {     
    }
}