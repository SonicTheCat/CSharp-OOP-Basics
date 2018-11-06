using System;

public class UltrasoftTyre : Tyre
{
    private const string NAME = "Ultrasoft";

    public UltrasoftTyre(double hardness, double grip)
        : base(NAME, hardness)
    {
        this.Grip = grip;
    }
    public override double Degradation
    {
        get => base.Degradation;
        protected set
        {
            if (value < 30)
            {
                throw new ArgumentException(Messages.BlownTyre);
            }
            base.Degradation = value; 
        }
    }

    public double Grip { get; private set; }

    public override void ReduceDegradation()
    {
        base.ReduceDegradation();
        this.Degradation -= this.Grip;
    }
}