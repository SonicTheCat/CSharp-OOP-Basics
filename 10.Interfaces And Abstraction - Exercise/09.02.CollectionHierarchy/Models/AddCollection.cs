using System.Collections.Generic;

public class AddCollection : IAddable
{
    protected IList<string> collection = new List<string>();

    public virtual int Add(string item)
    {
        collection.Add(item);
        return collection.Count - 1;
    }
}