using System;

public abstract class Driver
{
    protected Driver(string name, Car car, double fuelConsumption)
    {
        this.Name = name;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumption;
        this.IsStillRacing = true;
    }

    public string Name { get; }

    public double TotalTime { get; private set; }

    public Car Car { get; }

    public double FuelConsumptionPerKm { get; }

    public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;

    public bool IsStillRacing { get; private set; }

    public string FailureReason { get; private set; }

    public void Fail(string reason)
    {
        this.IsStillRacing = false;
        this.FailureReason = reason;
    }

    public void IncreaseTime(double time)
    {
        this.TotalTime += time;
    }

    public void Decreasetime(double time)
    {
        this.TotalTime -= time;
    }

    public void CompletedLap(int trackLength)
    {
        AddExtraTimeForLap(trackLength);
        ReduceFuel(trackLength);
        this.Car.Tyre.ReduceDegradation(); 
    }

    private void ReduceFuel(int trackLength)
    {
        var value = trackLength * this.FuelConsumptionPerKm;
        this.Car.ReduceFuel(value); 
    }

    private void AddExtraTimeForLap(int trackLength)
    {
        double time = 60 / (trackLength / this.Speed);
        this.IncreaseTime(time);
    }

    public override string ToString()
    {
        var result = this.IsStillRacing == true ? this.TotalTime.ToString("F3") : this.FailureReason;
        return $"{this.Name} {result}";
    }
}