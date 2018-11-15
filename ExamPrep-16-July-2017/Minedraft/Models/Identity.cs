public abstract class Identity
{
    protected Identity(string id)
    {
        this.Id = id; 
    }

    public string Id { get; private set; }
}