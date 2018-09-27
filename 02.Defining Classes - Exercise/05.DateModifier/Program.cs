using System;

public class Program
{
    public static void Main()
    {
        var dateOne = Console.ReadLine();
        var dateTwo = Console.ReadLine();

        DateModifier diff = new DateModifier();

        var result = diff.FindDiffrence(dateOne, dateTwo);
        Console.WriteLine(result);
    }
}

