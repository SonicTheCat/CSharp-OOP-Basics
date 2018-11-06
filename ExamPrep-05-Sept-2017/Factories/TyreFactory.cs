using System;

public class TyreFactory
{
    public Tyre Create(string[] args)
    {
        string type = args[0];
        double hardness = double.Parse(args[1]);

        switch (type)
        {
            case "Ultrasoft":
                {
                    double grip = double.Parse(args[2]);
                    return new UltrasoftTyre(hardness, grip);
                }
            case "Hard":
                {
                    return new HardTyre(hardness);
                }
            default: throw new ArgumentException(Messages.InvalidType);
        }
    }
}