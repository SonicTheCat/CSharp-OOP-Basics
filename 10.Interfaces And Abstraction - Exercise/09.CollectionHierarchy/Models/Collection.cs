using System.Collections.Generic;

public abstract class Collection : IAddable
{
    protected List<string> collection = new List<string>(); 

    public abstract int Add(string item); 
}