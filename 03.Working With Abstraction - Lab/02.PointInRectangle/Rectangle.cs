using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rectangle
{
    public Point TopLeft { get; set; }
    public Point BottomRight { get; set; }

    public Rectangle(int leftX, int leftY, int rightX, int rightY)
    {
        TopLeft = new Point(leftX, leftY);
        BottomRight = new Point(rightX, rightY);
    }

    public Rectangle(Func<string> readRectangle)
        : this(readRectangle().Split().Select(int.Parse).ToArray())
    {

    }

    public Rectangle(int[] coords)
        : this(coords[0], coords[1], coords[2], coords[3])
    {

    }

    public bool Contains(Point point)
    {
        return (TopLeft.X <= point.X && TopLeft.Y <= point.Y) &&
            (BottomRight.X >= point.X && BottomRight.Y >= point.Y);
    }
}

