public class AddCollection : Collection
{
    public override int Add(string item)
    {
        collection.Add(item);
        return collection.Count - 1;
    }
}