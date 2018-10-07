using System;
using System.Linq;

public class Student : Human
{
    private const int NUMBER_MIN_LENGTH = 5;
    private const int NUMBER_MAX_LENGTH = 10;

    private string facultyNumber;

    public Student(string firstname, string lastname, string facultyNumber)
        :base(firstname,lastname)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        set
        {
            if (value.Length < NUMBER_MIN_LENGTH ||
                value.Length > NUMBER_MAX_LENGTH ||
                !value.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"Faculty number: {FacultyNumber}\n"; 
    }
}