public class MathOperations
{
    public int Add(int a, int b)
    {
        var value = a + b;
        return value;
    }

    public double Add(double a, double b, double c)
    {
        var value = a + b + c;
        return value;
    }

    public decimal Add(decimal a, decimal b, decimal c)
    {
        var value = a + b + c;
        return value;
    }
}