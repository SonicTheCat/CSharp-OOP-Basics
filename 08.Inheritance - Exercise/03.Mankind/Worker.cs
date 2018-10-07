using System;

public class Worker : Human
{
    private const int MIN_WORK_HOURS = 1;
    private const int MAX_WORK_HOURS = 12;
    private const decimal MINIMUM_SALARY = 10;
    private const int WORK_DAYS_IN_WEEK = 5;

    private decimal weekSalary;
    private decimal workHoursPerDay;

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value < MINIMUM_SALARY)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }
    public decimal WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value < MIN_WORK_HOURS || value > MAX_WORK_HOURS)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHoursPerDay = value;
        }
    }

    public Worker(string firstname, string lastname, decimal weekSalary, decimal hoursPerDay)
        : base(firstname, lastname)
    {
        WeekSalary = weekSalary;
        WorkHoursPerDay = hoursPerDay;
    }

    private decimal SalaryPerHour()
    {
        var daySalary = WeekSalary / WORK_DAYS_IN_WEEK;
        var hourSalary = daySalary / WorkHoursPerDay;
        return hourSalary;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"Week Salary: {WeekSalary:F2}\n" +
            $"Hours per day: {WorkHoursPerDay:F2}\n" +
            $"Salary per hour: {SalaryPerHour():F2}";
    }
}