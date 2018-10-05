using System;

class Program
{
    static void Main()
    {
        var lenght = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        Box box = new Box(lenght, width, height);

        Console.WriteLine(box.SurfaceArea());
        Console.WriteLine(box.LateralSurfaceArea());
        Console.WriteLine(box.Volume());
    }
}

