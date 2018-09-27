public class Cymric : Cat
{
    private double furLength;

    public Cymric(string name, double furLength)
        :base(name)
    {
        this.furLength = furLength;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} {base.Name} {this.furLength:F2}";
    }
}

