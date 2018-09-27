using System;

public class Program
{
    public static void Main()
    {
        Person stamat = new Person();
        stamat.Name = "Stamat Stamatov";
        stamat.Age = 39;

        Console.WriteLine(stamat.Age);
        Console.WriteLine(stamat.Name);
    }
}

