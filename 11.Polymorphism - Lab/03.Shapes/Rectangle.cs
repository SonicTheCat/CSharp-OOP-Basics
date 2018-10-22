using System;

public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Height
    {
        get
        {
            return this.height;
        }

        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            this.height = value;
        }
    }

    public double Width
    {
        get
        {
            return this.width;
        }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            this.width = value;
        }
    }

    public override double CalculatePerimeter()
    {
        var perimeter = (this.Height + this.Width) * 2;
        return perimeter;
    }

    public override double CalculateArea()
    {
        var area = this.Height * this.Width;
        return area;
    }

    public override string Draw()
    {
        return base.Draw() + $"     {this.GetType().Name}";
    }
}