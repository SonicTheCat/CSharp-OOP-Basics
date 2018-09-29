using System;
using System.Linq;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point(Func<string> readPoint)
    {
        var coords = readPoint().Split().Select(int.Parse).ToArray();
        X = coords[0];
        Y = coords[1]; 
    }
}

