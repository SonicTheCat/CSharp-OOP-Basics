public class AddRemoveCollection : AddCollection, IRemoveable
{
    public override int Add(string item)
    {
        this.collection.Insert(0, item);
        return 0;
    }

    public virtual string Remove()
    {
        var item = this.collection[collection.Count - 1];
        this.collection.RemoveAt(collection.Count - 1);
        return item;
    }
}