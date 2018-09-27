using System;

public class DateModifier
{
    public int FindDiffrence(string dateOne, string dateTwo)
    {
        DateTime first = DateTime.Parse(dateOne);
        DateTime second = DateTime.Parse(dateTwo);

        return Math.Abs((first - second).Days);
    }
}

