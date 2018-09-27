using System;
using System.Collections.Generic;
using System.Text;


class Company
{
    private string name;
    private string department;
    private decimal salary;

    public Company()
    {
    }

    public Company(string name, string department, decimal salary)
    {
        this.Name = name;
        this.Department = department;
        this.Salary = salary;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public override string ToString()
    {
        if (this.Name != null || this.Department != null || this.Salary != 0)
        {
          return  "\n"  + this.Name + " " + this.Department + " " + $"{this.Salary:F2}";
        }
        return "";
    }
}