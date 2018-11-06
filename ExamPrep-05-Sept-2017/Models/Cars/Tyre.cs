using System;

public abstract class Tyre
{
    private const double DEFAULT_DEGRADATION = 100;

    private double degradation;

    protected Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.Degradation = DEFAULT_DEGRADATION;
    }

    public string Name { get; }

    public double Hardness { get; }

    public virtual double Degradation
    {
        get
        {
            return this.degradation;
        }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException(Messages.BlownTyre);
            }
            this.degradation = value; 
        }
    }

    public virtual void ReduceDegradation()
    {
        this.Degradation -= this.Hardness;
    }
}